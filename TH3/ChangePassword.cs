using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TH3
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        Form1 form1 = new Form1();  
        Profile profile = new Profile();
        Modify Modify = new Modify();
        string text = "select * from Taikhoan where TenTK ='" + Properties.Settings.Default.getTenTK + "'";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile.StartPosition = FormStartPosition.CenterScreen;
            profile.setdata(text);
            profile.ShowDialog();
            this.Close();
        }
        public bool CheckMK(string mkNew)
        {
            return Regex.IsMatch(mkNew, "^[a-zA-z0-9]{6,24}$");
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {
            string gmail = textBox1_gmail.Text;
            string mk = textBox2_oldpass.Text;
            string mkNew = textBox3_newpass.Text;
            string mkNewCheck = textBox4_confirm.Text;
            if (gmail != Modify.Taikhoans(text)[0].Gmail){label1_email.Text = "Wrong gmail confirm!"; return;}
            else { label1_email.Text = ""; };
            if (mk != Modify.Taikhoans(text)[0].Matkhau) { label1_email.Text = "Wrong old password!"; return; }
            else { label1_email.Text = ""; };
            if (!CheckMK(mkNew)) { label1_email.Text = "Please enter a password 6-24 characters long"; return; }
            else { label1_email.Text = ""; };
            if (mkNew == Modify.Taikhoans(text)[0].Matkhau) { label1_email.Text = "Password matches old password!"; return; }
            else { label1_email.Text = ""; };
            if (mkNewCheck != mkNew) { label1_email.Text = "Password authentication incorrect!"; return; }
            else { label1_email.Text = ""; };
                string query = "Update Taikhoan set MK = '" + mkNewCheck + "' where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                MessageBox.Show("Password changed, please log in again!");
                Modify.command(query);
                this.Hide();
                form1.StartPosition = FormStartPosition.CenterScreen;
                form1.ShowDialog();
                this.Close();
        }
    }
}
