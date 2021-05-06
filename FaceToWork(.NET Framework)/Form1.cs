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
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\Windows 10\source\repos\FaceToWork(.NET Framework)\FaceToWork(.NET Framework)\facefrontal_data.xml");

        //dragging variables
        bool draggable;
        int mouseX;
        int mouseY;

        //variables for video = pormenne pro device 
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        internal Image<Gray, Byte> GrayFrame;
        ResizeBilinear filter_cubic = new ResizeBilinear(640, 360);

        bool oblicejdetekovan;
        


        //variables for Azure Face API
        private static string subscriptionKey = "1bb9e797051348698dc5c58a509646c8";
        private static string endpoint = "https://facetowork-endpoint.cognitiveservices.azure.com";

        private readonly IFaceClient faceClient = new FaceClient(
            new ApiKeyServiceClientCredentials(subscriptionKey),
            new System.Net.Http.DelegatingHandler[] { });




        public Form1()
        {
            faceClient.Endpoint = endpoint;
            
            InitializeComponent();

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            oblicejdetekovan = false;
            ListVideoDevices();

        }
        private void ListVideoDevices()
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                cboCameraDevices.Items.Add(device.Name);
            cboCameraDevices.SelectedIndex = 0;
            device = new VideoCaptureDevice();
            
        }
        private void cboCameraDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            Bitmap newImage = filter_cubic.Apply(video);
            GrayFrame = new Image<Gray, byte>(newImage);


            



            pictureBox1.Image = newImage;

            if (oldimage != null) //kdyz nebude predchozi frame v pictureBox1 smaze se a uvolni se Memory
            {
                oldimage.Dispose();
            }

            GC.Collect();
        }
        /*
                private async Task<IList<DetectedFace>> UploadNdetect(string imageFilePath)
                {
                    try
                    {
                        using (Stream imageFileStream = File)
                        {
                            IList<DtectedFace> faceList = await faceClient.Face.DetectWithStreamAsync()
                        }
                    }
                }
        */

        private void StopCamera_Click(object sender, EventArgs e)
        {
            device.Stop();

            
        }

        #region User Interface = UI
        //======================

        private void domu_btn_Click(object sender, EventArgs e)
        {
            SidePanel_blue.Height = domu_btn.Height;
            SidePanel_blue.Top = domu_btn.Top;
        }

        private void dochazka_btn_Click(object sender, EventArgs e)
        {
            SidePanel_blue.Height = dochazka_btn.Height;
            SidePanel_blue.Top = dochazka_btn.Top;
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
        #endregion //  //  

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

      /*  private Bitmap MakeBMP(byte[] data)
		{
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)tc.ConvertFrom(byteArray);
		}
      */
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
		{
            using (var ms = new MemoryStream())
			{
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
			}
		}
		
	}
}
