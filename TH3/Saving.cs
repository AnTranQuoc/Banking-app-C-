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
    public partial class Saving : Form
    {
        public Saving()
        {
            InitializeComponent();
        }
        Modify Modify = new Modify();
        string query = "select * from Taikhoan where TenTk ='" + Properties.Settings.Default.getTenTK + "'";
        public void setdata(string text)
        {
            balance.Text = "Balance " + Modify.Taikhoans(text)[0].Sodu.ToString("N0", System.Globalization.CultureInfo.InvariantCulture) + "$";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.StartPosition = FormStartPosition.CenterScreen;
            home.SetText(query);
            home.ShowDialog();
            this.Close();
        }

        private void button1_dangnhap_Click(object sender, EventArgs e)
        {
            string SoTK = textBox1_acnumber.Text;
            int soTaiKhoan;
            string ST = textBox2_money.Text;
            int SoTien;
            if (int.TryParse(ST, out SoTien) == false)
            {
                error_label.Text = "Please enter the correct amount!"; return;
            }
            else { error_label.Text = ""; };
            if (int.TryParse(SoTK, out soTaiKhoan) == false)
            {
                error_label.Text = "Please enter the correct account number!"; return;
            }
            else { error_label.Text = ""; };
            int sodutaikhoan = Modify.Taikhoans(query)[0].Sodu;
            int.TryParse(ST, out SoTien);
            int.TryParse(SoTK, out soTaiKhoan);
            string kyhan = comboBox1.Text;
            string NguoiPR = textBox3_introducer.Text;
            if (SoTien > sodutaikhoan)
            {
                error_label.Text = "The amount exceeds your balance!"; return;
            }
            else { error_label.Text = ""; };
            string querys = "select * from Taikhoan where SoTK = " + soTaiKhoan + "";
            if (Modify.Taikhoans(querys).Count != 0)
            {
                string minus = "Update Taikhoan set SoDu = SoDu - " + ST + " where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                string addsotien = "Update Taikhoan set Saving = " + ST + " where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                string addkihan = "Update Taikhoan set Period = '" + kyhan + "' where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                string addnguoipr = "Update Taikhoan set Introducer = '" + NguoiPR + "' where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                Modify.command(minus);
                Modify.command(addsotien);
                Modify.command(addkihan);
                Modify.command(addnguoipr);
                SavingDone SavingDone = new SavingDone();
                this.Hide();
                SavingDone.StartPosition = FormStartPosition.CenterScreen;
                SavingDone.setdata(SoTien, soTaiKhoan, kyhan, NguoiPR);
                SavingDone.ShowDialog();
                this.Close();
            } 
            else
            {
                error_label.Text = "Account number is incorrect!"; return;
            }
        }
    }
}
