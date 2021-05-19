using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.ComponentModel;

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using System.Diagnostics;
using System.Net.Mail;
using Microsoft.Win32.SafeHandles;

using System.Resources;
using System.Reflection;
using System.Linq;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;



namespace FaceToWork_.NET_Framework_
{
    public partial class Form1 : Form
    {

        
        static readonly CascadeClassifier oclface = new CascadeClassifier(@"facefrontal_data.xml");

        //dragging variables
        bool draggable;
        int mouseX;
        int mouseY;

        //variables for video = pormenne pro device 
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        internal Image<Gray, Byte> GrayFrame;
        internal Image<Bgr, Byte> videoframe;
        ResizeBilinear filter_cubic = new ResizeBilinear(640, 360);
        bool oblicejdetekovan;
        byte[] jpegparams;
        MemoryStream memory = new MemoryStream();


        public string _groupId = null;


        //variables for Azure Face API
        private static string subscriptionKey = "1bb9e797051348698dc5c58a509646c8";
        private static string endpoint = "https://facetowork-endpoint.cognitiveservices.azure.com";
        
        public static IFaceClient faceClient = new FaceClient(
            new ApiKeyServiceClientCredentials(subscriptionKey),
            new System.Net.Http.DelegatingHandler[] { });

        public IList<DetectedFace> faceList;
        

        const string Recognition_model = RecognitionModel.Recognition04;


        public Form1()
        {
            faceClient.Endpoint = endpoint;
            
            InitializeComponent();
            dochazkaControl1.Hide();
            btnAddFace.Enabled = false;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            oblicejdetekovan = false;
            timeTxt.Text = DateTime.Now.ToString();
            ListVideoDevices();

        }
        private void ListVideoDevices() //Finds all available video devices on computer - Najde všechna dostupná zařízení pro vstup videa.
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                cboCameraDevices.Items.Add(device.Name);
            cboCameraDevices.SelectedIndex = 0;
            device = new VideoCaptureDevice();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (device.IsRunning == true) device.Stop();
            device = new VideoCaptureDevice(filter[cboCameraDevices.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var oldimage = pictureBox1.Image;
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            videoframe = new Image<Bgr, byte>(video);
            GrayFrame = new Image<Gray, byte>(video);
            Rectangle[] rectangles = oclface.DetectMultiScale(GrayFrame, 1.2, 1);

            foreach(Rectangle rectangle in rectangles)
			{
                using(Graphics graphics = Graphics.FromImage(video))
				{
                    using(Pen pen=new Pen(Color.Red, 1))
					{
                        graphics.DrawRectangle(pen, rectangle);
					}
				}
			}
            
           
            
            Bitmap newImage = video;
            pictureBox1.Image = newImage;

            if (oldimage != null) //kdyz nebude predchozi frame v pictureBox1 smaze se a uvolni se Memory
            {
                oldimage.Dispose();
            }
            GC.Collect();
        }

        /*
        private async Task<IList<DetectedFace>> UploadNdetect( imageFilePath)
        {
            try
            {
                {
                    IList<DetectedFace> faceList = await faceClient.Face.DetectWithStreamAsync(imageFilePath, true, false, null, recognitionModel: RecognitionModel.Recognition04);
                    return faceList.ToList();
                }
            }
			catch (Exception e)
			{
                MessageBox.Show(e.Message);
			}
        */


        #region User Interface = UI
        //======================


        //zastaví kameru
        private void StopCamera_Click(object sender, EventArgs e)
        {
            device.Stop();
        }


        private void domu_btn_Click(object sender, EventArgs e)
        {
            SidePanel_blue.Height = domu_btn.Height;
            SidePanel_blue.Top = domu_btn.Top;

            dochazkaControl1.Hide();
            dochazkaControl1.SendToBack();
        }

        private void dochazka_btn_Click(object sender, EventArgs e)
        {
            //design modry panel
            SidePanel_blue.Height = dochazka_btn.Height;
            SidePanel_blue.Top = dochazka_btn.Top;

            
            dochazkaControl1.Show();
            dochazkaControl1.BringToFront();
            btnExit.BringToFront();
            
        }

        private void nastaveni_btn_Click(object sender, EventArgs e)
        {
            SidePanel_blue.Height = nastaveni_btn.Height;
            SidePanel_blue.Top = nastaveni_btn.Top;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }

        private void QnA_btn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
            {
                device.Stop();
            }

            DialogResult dialog = MessageBox.Show("Opravdu chcete ukončit program?", "Ukončení aplikace", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion //  //  




        

        //Upload na Azure Face API pomocí stream z kamery
        public static async Task<List<DetectedFace>> UploadAndDetect(Stream stream)
		{
            try
            {
                IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithStreamAsync(stream, false, false, recognitionModel: Recognition_model);
                return detectedFaces.ToList();
            }
            catch (APIErrorException f) //pokud najde API chybu nahlasi
			{
                MessageBox.Show(f.Message);
                return new List<DetectedFace>();
			}
        }

		private async void btnProcess_Click(object sender, EventArgs e)
		{
            if (device.IsRunning == false)// pokud kamera nema vstup - error
			{
                MessageBox.Show("Chybí obrazový vstup z kamery", "Camera Input");
                return;
			}

            jpegparams = videoframe.ToJpegData(60);// snímá uloží jpeg data do memory 
            Stream m1 = new MemoryStream(jpegparams);//preměna do streamu
            List<DetectedFace> detectedFaces = await UploadAndDetect(m1);// send stream

            await faceClient.PersonGroup.DeleteAsync("lidi");
            
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
            timeTxt.Text = DateTime.Now.ToLongTimeString();
            dateTxt.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
            if (txtNewUser.Text == "") return;
            listUsers.Items.Add(txtNewUser.Text);
            
		}
        private void btnBrowseFaceFile_Click(object sender, EventArgs e)
        {
            //Vycisti folder textbox
            txtFolderFace.Text = null;

            using (var od = new OpenFileDialog())
            {
                od.Filter = "JPEG Image(*.jpg)| *.jpg";
                if (od.ShowDialog() == DialogResult.OK)
				{
                    txtFolderFace.Text = od.FileName;
				}
            }
        }
        private async void btnCreateGroup_Click(object sender, EventArgs e)
		{
            try
			{
                _groupId = txtGroupName.Text.ToLower().Replace(" ", "");
                try
				{
                    await faceClient.PersonGroup.DeleteAsync(_groupId);
				} catch { }

                await faceClient.PersonGroup.CreateAsync(_groupId, txtGroupName.Text);

                foreach (var u in listUsers.Items)
				{
                    Person person = await faceClient.PersonGroupPerson.CreateAsync(_groupId, u.ToString());

                        using (Stream s = File.OpenRead(txtFolderFace.Text))
                        {
                            await faceClient.PersonGroupPerson.AddFaceFromStreamAsync(_groupId, person.PersonId, s);
                        }

                    await Task.Delay(1000);

                }
                MessageBox.Show("Group successfully created");
			} catch (Exception ex)
			{
                MessageBox.Show(ex.ToString());
			}
		}

		private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
            Console.WriteLine(listUsers.SelectedItem.ToString());
        }

		private void btnAddFace_Click(object sender, EventArgs e)
		{
            
            
            using (var od = new OpenFileDialog())
            {
                
                od.Filter = "JPEG Image(*.jpg)| *.jpg";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    string FaceFile = od.FileName;
                }
            }
        }

		private async void btnTrain_Click(object sender, EventArgs e)
		{
            try
			{
                await faceClient.PersonGroup.TrainAsync(_groupId);

                
                while (true)
				{
                    await Task.Delay(1000);
                    var trainingStatus = await faceClient.PersonGroup.GetTrainingStatusAsync(_groupId);

                    if (trainingStatus.Status == TrainingStatusType.Succeeded)
					{
                        break;
					}
                    await Task.Delay(1000);
				}

                MessageBox.Show("Training successfully completed!");
			} catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
			}
		}

		private async void btnIdentify_Click(object sender, EventArgs e)
		{
            try
			{
                if (device.IsRunning == false)// pokud kamera nema vstup - error
                {
                    MessageBox.Show("Chybí obrazový vstup z kamery", "Camera Input");
                    return;
                }

                jpegparams = videoframe.ToJpegData(60);// snímá uloží jpeg data do memory 
                Stream m1 = new MemoryStream(jpegparams);//preměna do streamu
                List<DetectedFace> detectedFaces = await UploadAndDetect(m1);// send stream
                List<Guid> sourceFaceIdsCamera = new List<Guid>();

                idList.Items.Clear();
                
                foreach (var detectedFace in detectedFaces)
				{
                    sourceFaceIdsCamera.Add(detectedFace.FaceId.Value);
				}

                var identifyResults = await faceClient.Face.IdentifyAsync(sourceFaceIdsCamera, _groupId);

                foreach (var identifyResult in identifyResults)
				{
                    if (identifyResult.Candidates.Count != 0)
					{
                        var candidateId = identifyResult.Candidates[0].PersonId;
                        Person person = await faceClient.PersonGroupPerson.GetAsync(_groupId, candidateId);
                        idList.Items.Add(person.Name);
                    }
                    else
					{
                        idList.Items.Add("Unknown person");
					}
                    
				}
                MessageBox.Show("Identification successfully completed.");
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
			}
		}
	}	
}
