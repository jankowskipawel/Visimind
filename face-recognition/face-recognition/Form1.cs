using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace face_recognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateImage(img);
        }

        //initialize classifier
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");

        //initialize web client for downloading images
        private static WebClient wc = new WebClient();
        private static byte[] bytes = wc.DownloadData("https://thispersondoesnotexist.com/image");
        private static MemoryStream ms = new MemoryStream(bytes);
        private System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
        private bool isCameraModeActive = false;
        private Capture videoCapture;

        private void randomImageButton_Click(object sender, EventArgs e)
        {
            //download new image
            bytes = wc.DownloadData("https://thispersondoesnotexist.com/image");
            ms = new MemoryStream(bytes);
            img = System.Drawing.Image.FromStream(ms);
            UpdateImage(img);
        }

        private Image DetectFaces(Image img)
        {
            Bitmap bitmap = new Bitmap(img);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            //detect faces
            Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 5);
            //draw rectangles where faces were detected
            foreach (var face in faces)
            {
                CvInvoke.Rectangle(grayImage, face, new Bgr(Color.Magenta).MCvScalar, 2);
            }
            return grayImage.ToBitmap();
        }

        //resize and replace image
        private void UpdateImage(Image img)
        {
            img = ResizeImage(img, pictureBox1.Size);
            pictureBox1.Image = DetectFaces(img);
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!isCameraModeActive)
            {
                UpdateImage(img);
            }
        }

        private void customImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                img = Image.FromFile(openFileDialog1.FileName);
                UpdateImage(img);
            }
        }

        private void swapModeButton_Click(object sender, EventArgs e)
        {
            swapModeButton.Text = isCameraModeActive ? "Image" : "Camera";
            isCameraModeActive = !isCameraModeActive;

            if (isCameraModeActive)
            {
                randomImageButton.Enabled = false;
                customImageButton.Enabled = false;
                videoCapture = new Emgu.CV.Capture(0);
                videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
                videoCapture.Start();
            }
            else
            {
                randomImageButton.Enabled = true;
                customImageButton.Enabled = true;
                videoCapture.Stop();
                videoCapture = null;
                UpdateImage(img);
            }
        }

        private void VideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat m = new Mat();
            videoCapture.Retrieve(m);
            img = m.ToImage<Bgr, byte>().Bitmap;
            UpdateImage(img);
        }
    }
}
