using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.CenterScreen;
            form3.ShowDialog();
        }
        Modify Modify = new Modify();
        private void button1_dangnhap_Click(object sender, EventArgs e)
        {
            string tentk = textBox1_tk.Text;
            string mk = textBox2_mk.Text;
            if (tentk.Trim() =="") { MessageBox.Show("Please enter the account");}
            else if (mk.Trim() == "") { MessageBox.Show("Please enter the password");}
            else
            {
                string query = "select * from Taikhoan where TenTk ='" + tentk + "' and MK = '" + mk + "'";
                if(Modify.Taikhoans(query).Count!= 0)
                {
                    MessageBox.Show("Logged in successfully", "Nontification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.getTenTK = tentk;
                    if (savepass.Checked)
                    {
                        Properties.Settings.Default.Username = tentk;
                        Properties.Settings.Default.Password = mk;
                        Properties.Settings.Default.Save();
                    }
                    this.Hide();
                    Home home = new Home();
                    home.StartPosition = FormStartPosition.CenterScreen;
                    home.SetText(query);
                    home.ShowDialog();  
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect account name or password!", "Nontification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2_mk.Text = string.Empty;
                }
            }
        }
       

        private void textBox2_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_dangnhap.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1_tk.Text = Properties.Settings.Default.Username;
            textBox2_mk.Text = Properties.Settings.Default.Password;
        }
        private bool isEyeOpen = true;
        private void eye_Click(object sender, EventArgs e)
        {
            if (isEyeOpen)
            {
                eye.Image = Properties.Resources._8530610_eye_icon;
                textBox2_mk.PasswordChar = '\0';
            }
            else
            {
                eye.Image = Properties.Resources._8530588_eye_slash_icon; 
                textBox2_mk.PasswordChar = '*';
            }
            isEyeOpen = !isEyeOpen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
