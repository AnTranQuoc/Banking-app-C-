using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TH3
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        public void OpenChildform(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        Modify Modify = new Modify();
        public void setdata(string text)
        {
            balance.Text =Modify.Taikhoans(text)[0].Sodu.ToString("N0", System.Globalization.CultureInfo.InvariantCulture) + "$";
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.StartPosition = FormStartPosition.CenterScreen;
            home.SetText("select * from Taikhoan where TenTk ='" + Properties.Settings.Default.getTenTK + "'");
            home.ShowDialog();
            this.Close();
        }

        private void pictureBox2UITBank_Click(object sender, EventArgs e)
        {
                pictureBox2_UITBank.Image = Properties.Resources.uitclick;
                pictureBox4_OtherBank.Image = Properties.Resources.others;
                pictureBox3_QRCode.Image = Properties.Resources.QRcode;
                OpenChildform(new Transfer_UIT(this));
        }

        private void pictureBox4_OtherBank_Click(object sender, EventArgs e)
        {
                pictureBox4_OtherBank.Image = Properties.Resources.othersclick;
                pictureBox2_UITBank.Image = Properties.Resources.UITBANK;
                pictureBox3_QRCode.Image = Properties.Resources.QRcode;
                OpenChildform(new Transfer_others(this));
        }

        private void pictureBox3_QRCode_Click(object sender, EventArgs e)
        {
                pictureBox3_QRCode.Image = Properties.Resources.QRclcik;
                pictureBox4_OtherBank.Image = Properties.Resources.others;
                pictureBox2_UITBank.Image = Properties.Resources.UITBANK;
                OpenChildform(new TrasferQR(this));
        }
        public void hide()
        {
            this.Hide();
        }

        public void close()
        {
            this.Close(); 
        }
    }
}
