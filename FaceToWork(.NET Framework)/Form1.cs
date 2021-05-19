﻿using System;
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
        static readonly CascadeClassifier oclface = new CascadeClassifier(@"C:\Users\Windows 10\source\repos\FaceToWork(.NET Framework)\FaceToWork(.NET Framework)\facefrontal_data.xml");

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

        


        //variables for Azure Face API
        private static string subscriptionKey = "1bb9e797051348698dc5c58a509646c8";
        private static string endpoint = "https://facetowork-endpoint.cognitiveservices.azure.com";
        
        public static IFaceClient faceClient = new FaceClient(
            new ApiKeyServiceClientCredentials(subscriptionKey),
            new System.Net.Http.DelegatingHandler[] { });

        private IList<DetectedFace> faceList;

        const string Recognition_model = RecognitionModel.Recognition04;


        public Form1()
        {
            faceClient.Endpoint = endpoint;
            
            InitializeComponent();
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            oblicejdetekovan = false;
            dochazkaControl1.Hide();
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
            videoframe = new Image<Bgr, byte>(video);
            GrayFrame = new Image<Gray, byte>(video);

           

            Rectangle orig_area;
            /*
                        if (GrayFrame != null)
                        {
                            Rectangle[] faces = null;
                            faces = oclface.DetectMultiScale(GrayFrame, 1.2, 1);
                            if ((faces.Length == -1) || (faces == null)) return;


                            foreach (Rectangle face in faces)
                            {
                                using (Graphics graphics = Graphics.FromImage(video))
                                {
                                    using (Pen pen = new Pen(Color.Red, 1))
                                    {
                                        graphics.DrawRectangle(pen, face);
                                    }
                                }
                            }
                        }
            */
            Bitmap newImage = filter_cubic.Apply(video);

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
        }

        private void dochazka_btn_Click(object sender, EventArgs e)
        {
            //design modry panel
            SidePanel_blue.Height = dochazka_btn.Height;
            SidePanel_blue.Top = dochazka_btn.Top;

            btnExit.BringToFront();
            dochazkaControl1.Show();
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

        

        /*
        public static Stream ToStream()
        {
            
            jpegparams = videoframe.ToJpegData(60);
            MyImage.Save(m1, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] header = new byte[] { 255, 216 };
            header = m1.ToArray();
            return (header);
            
        }

        */

		private void QnA_btn_Click(object sender, EventArgs e)
		{

        }

        //Upload na Azure Face API pomocí stream z kamery
        private static async Task<List<DetectedFace>> UploadAndDetect(Stream stream)
		{
            try
            {
                IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithStreamAsync(stream, false, false, recognitionModel: Recognition_model);
                Console.WriteLine($"There are {detectedFaces.Count} faces in the camera");
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
            jpegparams = videoframe.ToJpegData(60);
            Stream m1 = new MemoryStream(jpegparams);
            List<DetectedFace> detectedFaces = await UploadAndDetect(m1);
            
            foreach (var faces in detectedFaces)
			{

			}
		}
	}
}