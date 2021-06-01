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
using System.Data.SqlClient;
using System.ComponentModel;
using System.Net.Http;


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



namespace FaceToWork
{
    public partial class Form1 : Form
    {

        
        static readonly CascadeClassifier oclface = new CascadeClassifier(@"facefrontal_data.xml");
        static readonly CascadeClassifier classifier = new CascadeClassifier(@"haarcascade_frontalface_alt.xml");

        //dragging variables(not so important)
        bool draggable;
        int mouseX;
        int mouseY;

        //variables for video = pormenne pro device 
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        VideoCaptureDevice device2;
        internal Image<Gray, Byte> GrayFrame;       
        internal Image<Bgr, Byte> videoframe;
        ResizeBilinear filter_cubic = new ResizeBilinear(527, 302);

        bool oblicejdetekovan;
        byte[] jpegparams;
        MemoryStream memory = new MemoryStream();


        


        //variables for Azure Face API
        private static string subscriptionKey = "<subs-key>";
        private static string endpoint = "<ENDPOINT>";
        
        public static IFaceClient faceClient = new FaceClient(
            new ApiKeyServiceClientCredentials(subscriptionKey),
            new System.Net.Http.DelegatingHandler[] { });
        
        

        public IList<DetectedFace> faceList;

        

        const string Recognition_model = RecognitionModel.Recognition04;


        //variables for database SQL
            



        public Form1()
        {
            faceClient.Endpoint = endpoint;
            
            InitializeComponent();
            dochazkaControl1.Hide();
            
            
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
			{
                cboCameraDevices.Items.Add(device.Name);
                cboCameraDevices2.Items.Add(device.Name);
            }
            cboCameraDevices.SelectedIndex = 0;
            

            device = new VideoCaptureDevice();
            device2 = new VideoCaptureDevice();
        }

        private void OnCamera_Click(object sender, EventArgs e)
        {
            if (device.IsRunning == true) device.Stop();
            device = new VideoCaptureDevice(filter[cboCameraDevices.SelectedIndex].MonikerString);
            
            device.NewFrame += Device_NewFrame;
            device.Start();

            if (device2.IsRunning == true) device2.Stop();
            if (cboCameraDevices2.SelectedItem != null)
            {
                device2 = new VideoCaptureDevice(filter[cboCameraDevices2.SelectedIndex].MonikerString);

                device2.NewFrame += Device_NewFrame2;
                device2.Start();
            }
            else device2.Stop();
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var oldimage = pictureBox1.Image;
            Bitmap video = filter_cubic.Apply((Bitmap)eventArgs.Frame.Clone());
            videoframe = new Image<Bgr, byte>(video);
            GrayFrame = new Image<Gray, byte>(video);

            Rectangle[] rectangles = oclface.DetectMultiScale(GrayFrame, 1.2, 10);
            if (rectangles != null)
			{
             
            }
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(video)) //ziska graphics z bitmap 
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                        oblicejdetekovan = true;
                        
                    }
                }
            }

            oblicejdetekovan = false;
            pictureBox1.Image = video;

            if (oldimage != null) //kdyz nebude predchozi frame v pictureBox1 smaze se a uvolni se Memory
            {
                oldimage.Dispose();
            }
            GC.Collect();
        }



        private void Device_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            var oldimage = pictureBox2.Image;
            Bitmap video = filter_cubic.Apply((Bitmap)eventArgs.Frame.Clone());
            videoframe = new Image<Bgr, byte>(video);
            GrayFrame = new Image<Gray, byte>(video);

            Rectangle[] rectangles2 = classifier.DetectMultiScale(GrayFrame, 1.2, 10);

            foreach (Rectangle rectangle in rectangles2)
            {
                using (Graphics graphics = Graphics.FromImage(video)) //ziska graphics z bitmap 
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                        oblicejdetekovan = true;
                        //Console.WriteLine("OBLIČEJ DETEKOVÁN");
                    }
                }
            }
            pictureBox2.Image = video;
            if (oldimage != null) //kdyz nebude predchozi frame v pictureBox1 smaze se a uvolni se Memory
            {
                oldimage.Dispose();
            }
            GC.Collect();
        }

            //USER INTERFACE - Hlavni Nabidka

            #region User Interface = UI
            //======================


            //zastaví kameru
        private void StopCamera_Click(object sender, EventArgs e)
        {
            device.Stop();
            device2.Stop();
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

        private async void QnA_btn_Click(object sender, EventArgs e)
        {
            try //zatim nic nedela Jen deletuje group "lidi" aby nebyl bordel :)
            {
                await faceClient.PersonGroup.DeleteAsync("lidi");
            }
            catch (APIErrorException apiex)
			{
                MessageBox.Show(apiex.Message);
			}
			
	    System.Diagnostics.Process.Start("http://google.com/");
       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning || device2.IsRunning)
            {
                device.Stop();
                device2.Stop();
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

        //USER INTERFACE - Hlavni Nabidka


        //Upload na Azure Face API pomocí stream z kamery - získá JPEG parametry.
        public static async Task<List<DetectedFace>> UploadAndDetect(Stream stream)
		{
            try
            {
                //string url = "https://raw.githubusercontent.com/lexa105/Azure-Cup-FaceToWork/main/obrazky/billgates.jpg";
                //IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithUrlAsync(url, true, true, recognitionModel: Recognition_model);
                // TEST URL - pouzivano pri testovani...

                IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithStreamAsync(stream, true, true, recognitionModel: Recognition_model);
                Console.WriteLine($"There are {detectedFaces.Count} faces in the webcam");
                return detectedFaces.ToList();
            }
            catch (APIErrorException f) //pokud najde API chybu nahlasi
			{
                MessageBox.Show(f.Message);
                return new List<DetectedFace>();
			}
        }

		private async void btnProcess_Click(object sender, EventArgs e) //posílá údaje do Face API
		{
            if (device.IsRunning == false)// pokud kamera nema vstup - error
			{
                MessageBox.Show("Chybí obrazový vstup z kamery", "Camera Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}

            jpegparams = videoframe.ToJpegData(60);// snímá uloží jpeg data do memory 
            Stream m1 = new MemoryStream(jpegparams);//preměna do streamu
            List<DetectedFace> detectedFaces = await UploadAndDetect(m1);// send stream
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
            timeTxt.Text = DateTime.Now.ToLongTimeString();
            dateTxt.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
		}

		private async void btnTrain_Click(object sender, EventArgs e)
		{
            List<string> groupIds = new List<string>();

            groupIds.Clear();
            DataSet1TableAdapters.PersonGroupTBLTableAdapter groupTBL = new DataSet1TableAdapters.PersonGroupTBLTableAdapter();
            DataTable dt_person = groupTBL.GetPersonGroupID();

            foreach (DataRow dr in dt_person.Rows)
            {
                groupIds.Add(dr["_groupId"].ToString());
            }

            foreach (string _groupId in groupIds)
            {
                Train(_groupId);
            }
        }

		private async void btnIdentify_Click(object sender, EventArgs e) //Identifikace obrazku pomoci tlacitka -- tato funkce bude pouzita automaticky pomoc Oflline detekovani.
		{
            List<string> groupIds = new List<string>();

            groupIds.Clear();
            DataSet1TableAdapters.PersonGroupTBLTableAdapter groupTBL = new DataSet1TableAdapters.PersonGroupTBLTableAdapter();
            DataTable dt_person = groupTBL.GetPersonGroupID();

            foreach (DataRow dr in dt_person.Rows)
            {
                groupIds.Add(dr["_groupId"].ToString());
            }

            foreach(string _groupId in groupIds)
			{
                Identify(_groupId);
			}

            
		}

		private void fill_Click(object sender, EventArgs e)
		{
            
        }

        public async void Train(string _groupId)
		{
            try
            {
                await Task.Delay(1000);
                await faceClient.PersonGroup.TrainAsync(_groupId);


                while (true)
                {
                    await Task.Delay(5000);
                    var trainingStatus = await faceClient.PersonGroup.GetTrainingStatusAsync(_groupId);

                    if (trainingStatus.Status == TrainingStatusType.Succeeded)
                    {
                        break;
                    }
                    await Task.Delay(1000);
                }

                MessageBox.Show("Training successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void Identify(string _groupId)
		{
            try
            {
                if (device.IsRunning == false)// pokud kamera nema vstup - error
                {
                    MessageBox.Show("Chybí obrazový vstup z kamery", "Camera Input");
                    return;
                }

                IList<Guid> sourceFaceIdsCamera = new List<Guid>();
                jpegparams = videoframe.ToJpegData(60);// snímá uloží jpeg data do memory 
                Stream m1 = new MemoryStream(jpegparams);//preměna do streamu
                IList<DetectedFace> detectedFaces = await UploadAndDetect(m1);// send stream


                idList.Items.Clear();

                foreach (var detectedFace in detectedFaces)
                {
                    Console.WriteLine($"{detectedFace.FaceId.Value}");
                    Console.WriteLine("Identifying Picture");
                    sourceFaceIdsCamera.Add(detectedFace.FaceId.Value);
                }



                var identifyResults = await faceClient.Face.IdentifyAsync(sourceFaceIdsCamera, _groupId);

                foreach (var identifyResult in identifyResults)
                {
                    if (identifyResult.Candidates.Count != 0)
                    {
                        var candidateId = identifyResult.Candidates[0].PersonId;
                        Person person = await faceClient.PersonGroupPerson.GetAsync(_groupId, candidateId);
                        idList.Items.Add($"{DateTime.Now.Date.ToString("dd.MM.yyyy")} {person.Name} přišel v {DateTime.Now.ToString("HH:mm:ss")}");
                    }
                    else
                    {
                        idList.Items.Add("Unknown person");
                    }
                }
                MessageBox.Show("Identification successfully completed.");
            }
            catch (APIErrorException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
	}	
}

