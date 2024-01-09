using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TH3
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        Modify Modify = new Modify();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.StartPosition = FormStartPosition.CenterScreen;
            home.SetText("select * from Taikhoan where TenTk ='" + tentk + "'");
            home.ShowDialog();
            this.Close();
        }
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
        string tentk;
        public void setdata(string text)
        {
            textBox1_date.Text = Modify.Taikhoans(text)[0].Date;
            textBox2_gmail.Text = Modify.Taikhoans(text)[0].Gmail;
            textBox3_account.Text = Modify.Taikhoans(text)[0].TenTaikhoan;
            textBox4_password.Text = Modify.Taikhoans(text)[0].Matkhau;
            label1_name.Text = Modify.Taikhoans(text)[0].Name;
            tentk = Modify.Taikhoans(text)[0].TenTaikhoan;
            if (IsImagePath(Modify.Taikhoans(text)[0].Anh)) {
                pictureBox1.Image = System.Drawing.Image.FromFile(Modify.Taikhoans(text)[0].Anh);
            }
        }
        private bool isEyeOpen = true;
        private void eye_Click(object sender, EventArgs e)
        {
            if (isEyeOpen)
            {
                eye.Image = Properties.Resources._8530610_eye_icon;
                textBox4_password.PasswordChar = '\0';
            }
            else
            {
                eye.Image = Properties.Resources._8530588_eye_slash_icon;
                textBox4_password.PasswordChar = '*';
            }
            isEyeOpen = !isEyeOpen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signed out successfully", "Nontification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.ShowDialog();
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string query = "Update Taikhoan set ImagePath = '" + imagePath + "' where TenTK = '" + tentk + "'";
                Modify.command(query);
                string path = "select * from Taikhoan where TenTk ='" + tentk + "'";
                if (IsImagePath(Modify.Taikhoans(path)[0].Anh))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(Modify.Taikhoans(path)[0].Anh);
                }
            }
            MessageBox.Show("Changed avatar successfully!");
        }
        private void Change_pass_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.StartPosition = FormStartPosition.CenterScreen;
            changePassword.ShowDialog();
            this.Close();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            int a = Modify.Taikhoans("select* from Taikhoan where TenTk = '" + tentk + "'")[0].Sav;
            if (a != 0)
            {
                savingcheck savingcheck = new savingcheck();
                savingcheck.StartPosition = FormStartPosition.CenterScreen;
                savingcheck.setdata();
                savingcheck.ShowDialog();
            }
            else
            {
                MessageBox.Show("Haven't registered a savings account yet!");
            }
        }
    }
}
