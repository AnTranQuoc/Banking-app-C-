using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TH3
{
    public partial class Home : Form
    {
        public Home()
        { 
            InitializeComponent();

        }
        Modify Modify = new Modify();
        Profile profile = new Profile();
        Transfer transfer = new Transfer(); 
        Saving Saving = new Saving();
        
        static bool IsImagePath(string path)
        {
            if (!File.Exists(path))
            {
                return false;
            }
            string extension = Path.GetExtension(path)?.ToLower();
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp")
            {
                return true;
            }
            return false;
        }
       
        string TenTK;
        public void SetText(string text)
        {
            label1_name.Text = Modify.Taikhoans(text)[0].Name;
            TenTK = Modify.Taikhoans(text)[0].TenTaikhoan;
            if (Modify.Taikhoans(text)[0].Anh != "0" && IsImagePath(Modify.Taikhoans(text)[0].Anh))
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(Modify.Taikhoans(text)[0].Anh);
            }
            balance.Text = Modify.Taikhoans(text)[0].Sodu.ToString("N0", System.Globalization.CultureInfo.InvariantCulture) + "$";
            label2.Text = Modify.Taikhoans(text)[0].Sotk.ToString();
        }
        private void balance_Click(object sender, EventArgs e)
        {

        }
        
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile.StartPosition = FormStartPosition.CenterScreen;
            string text = "select * from Taikhoan where TenTK ='" + TenTK + "'";
            profile.setdata(text);
            profile.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            transfer.StartPosition = FormStartPosition.CenterScreen;
            string text = "select * from Taikhoan where TenTK ='" + TenTK + "'";
            transfer.setdata(text);
            transfer.ShowDialog();
            this.Close();
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Historyy history = new Historyy();
            this.Hide();
            history.StartPosition = FormStartPosition.CenterScreen;
            history.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saving.StartPosition = FormStartPosition.CenterScreen;
            string text = "select * from Taikhoan where TenTK ='" + TenTK + "'";
            Saving.setdata(text); 
            Saving.ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

    }
}
