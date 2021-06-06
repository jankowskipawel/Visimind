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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace face_tracking
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

        private void getNewImageButton_Click(object sender, EventArgs e)
        {
            //download new image
            bytes = wc.DownloadData("https://thispersondoesnotexist.com/image");
            ms = new MemoryStream(bytes);
            img = System.Drawing.Image.FromStream(ms);
            //resize and replace
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
                CvInvoke.Rectangle(grayImage, face, new Bgr(Color.Red).MCvScalar, 2);
            }
            return grayImage.ToBitmap();
        }

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
            UpdateImage(img);
        }
    }
}
