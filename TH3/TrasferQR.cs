using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace TH3
{
    public partial class TrasferQR : Form
    {
        FilterInfoCollection cameras;
        VideoCaptureDevice cam;
        private Transfer Transfer;
        public TrasferQR(Transfer transfer)
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;
            this.Transfer = transfer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
        }
        private bool check = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
            TransferQRcode transferQRcode = new TransferQRcode(Transfer);
            if (result != null)
            {
                try
                {
                    string decoded = result.ToString().Trim();
                    string[] decoded_parts = decoded.Split(' ');
                    if (decoded_parts.Length == 4)
                    {
                        if (!string.IsNullOrEmpty(decoded))
                        {
                            check = false;
                            transferQRcode.setdata(decoded_parts[0], decoded_parts[1], decoded_parts[2], decoded_parts[3]);
                            ((Transfer)this.ParentForm).OpenChildform(transferQRcode);
                        }
                    }
                    else
                    {
                        check = false;
                        label1.Text = "QR dose not work in this app!";
                    }
                }
                catch(Exception ex)
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
