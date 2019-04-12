using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV;


namespace Deteksi_wajah
{
    public partial class Form1 : Form
    {
        Capture capture;
        bool captureprogres;
        HaarCascade Haar;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_camera_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NoNullAllowedException exc)
                {
                    MessageBox.Show("Camera tidak aktiv");
                }
            }
            if (capture != null)
            {
                if (captureprogres)
                {
                    Application.Idle -= prosesframe;
                }
                else
                {
                    Application.Idle += prosesframe;
                }
                captureprogres = !captureprogres;
            }
        }
    


        private void prosesframe(object sender, EventArgs arg){
        
            Image<Bgr, byte> ImageFrame = capture.QueryFrame();
            if (ImageFrame != null)
            {
                Image<Gray, Byte> grayframe = ImageFrame.Convert<Gray, Byte>();
                var face = grayframe.DetectHaarCascade(Haar, 1.4, 4, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20))[0];
                foreach (var faces in face)
                {
                    ImageFrame.Draw(faces.rect, new Bgr(Color.Red), 3);
                }
            }
            imageBox1.Image = ImageFrame;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Haar = new HaarCascade("haarcascade_frontalface_default.xml");
        }

    }

}