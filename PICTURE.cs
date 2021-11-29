using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;
using System.Threading;
namespace SOFTWARE
{
    public partial class PICTURE : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;


        
      

        private void CaptureCameraCallback()
        {

           

            
        }
        public PICTURE()
        {
            InitializeComponent();
        }

        private void PICTURE_Load(object sender, EventArgs e)
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);
            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                }
            }


            if (isCameraRunning)
            {
                Bitmap snapshot = new Bitmap(pictureBox1.Image);
                snapshot.Save(string.Format(@"H:\{0}.png", Guid.NewGuid()), ImageFormat.Png);
            }
            else
            {
                Console.WriteLine("Cannot take picture, camera isn't capturing image!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
