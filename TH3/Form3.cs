using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TH3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
         
        public bool CheckAccount(string account) {
            return Regex.IsMatch(account,"^[a-zA-z0-9]{6,24}$");
        }
        public bool CheckGmail(string gmail)
        {
            return Regex.IsMatch(gmail, @"^[a-zA-z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify Modify = new Modify();
        Form1 form1 = new Form1();
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            string Tentk = textBox1_TenTk.Text; 
            string MK = textBox2_MK.Text;
            string XNMK = textBox3_XacNhanMK.Text;
            string gmail = textBox4_Gmail.Text;
            string name = textBox6_name.Text;
            string date = textBox5_Date.Text;
            int randomNumber = random.Next(1000, 10000);
            if (!CheckAccount(Tentk)) { MessageBox.Show("Please enter an account name 6-24 characters long, using only letters and numbers"); return; };
            if (!CheckAccount(MK)) { MessageBox.Show("Please enter a password name 6-24 characters long, using only letters and numbers"); return; };
            if (XNMK != MK) { MessageBox.Show("Password confirm was wrong"); return; };
            if (!CheckGmail(gmail)) { MessageBox.Show("Please enter the correct gmail"); return; };
            if (Modify.Taikhoans("select * from Taikhoan where Email = '" + gmail+"'").Count != 0) { MessageBox.Show("Gmail has been registered, please choose another gmail."); return; };
            try
            { 
                string nbank = "UIT Bank";
                string query = "Insert into Taikhoan values ('" + Tentk + "','" + MK + "','" + gmail + "','" + name + "','" + date + "','" + 0 + "'," + 50000 + "," + randomNumber + ",'" + randomNumber + "','" + randomNumber + "'," + 0 + ",'" + nbank + "')";
                MessageBox.Show("Sign Up Success");
                Modify.command(query);
                this.Hide();
                form1.StartPosition = FormStartPosition.CenterScreen;
                form1.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("This account name is already registered, please create another account name.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
