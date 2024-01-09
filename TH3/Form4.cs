using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace TH3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Modify Modify = new Modify();
        public bool CheckMail(string em)
        {
            return Regex.IsMatch(em,@"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string gmail = textBox1.Text;
            if (gmail.Trim() == "") { label_error.Text = "Please enter the gmail!"; return; } 
            else
            {
                if (!CheckMail(gmail)) { label_error.Text = "Please enter the correct gmail!"; return; } else { label_error.Text = ""; };
                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress(textBox1.Text);
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "kczi mxdu pgkf fapw");
                smtp.Host = "smtp.gmail.com";
                mail.To.Add(new MailAddress(textBox1.Text));
                mail.IsBodyHtml = true;
                mail.Subject = "Get new banking app password";
                mail.Body = "Your new password: zk213Ndsxiz";
                string mknew = "zk213Ndsxiz";
                string query = "Update Taikhoan set MK = '" + mknew + "' where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                Modify.command(query);
                smtp.Send(mail);
                MessageBox.Show("Please check your email!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }
    }
}
