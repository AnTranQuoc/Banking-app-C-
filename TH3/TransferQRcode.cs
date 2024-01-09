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
    public partial class TransferQRcode : Form
    {
        private Transfer Transfer;
        public TransferQRcode(Transfer transfer)
        {
            InitializeComponent();
            this.Transfer = transfer;
        }
        Modify Modify = new Modify();
        Historyy History = new Historyy();
        DateTime currentTime = DateTime.Now;
        public void setdata(string a, string b,string c,string d)
        {
            textBox1_tenNganHang.Text = a+" "+b;
            textBox2_taiKhoanThuaHuong.Text = c;
            textBox_TKname.Text = d;
        }
        private void button1_xacNhan_Click(object sender, EventArgs e)
        {
            string queryes = "select * from Taikhoan where TenTk ='" + Properties.Settings.Default.getTenTK + "'";
            string SoTK = textBox2_taiKhoanThuaHuong.Text;
            int soTaiKhoan;
            string ST = textBox3_soTien.Text;
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
            if (textBox2_taiKhoanThuaHuong.Text == Modify.Taikhoans(queryes)[0].Sotk.ToString())
            {
                error_label.Text = "Please enter an account other than yours!"; return;
            }
            else { error_label.Text = ""; };
            int sodutaikhoan = Modify.Taikhoans(queryes)[0].Sodu;
            string tenBank = textBox1_tenNganHang.Text;
            string Noidung = textBox4_noiDung.Text;
            int.TryParse(ST, out SoTien);
            int.TryParse(SoTK, out soTaiKhoan);
            if (SoTien > sodutaikhoan)
            {
                error_label.Text = "The amount exceeds your balance!"; return;
            }
            else { error_label.Text = ""; };
            string query = "select * from Taikhoan where SoTK = " + soTaiKhoan + "";
            if (Modify.Taikhoans(query).Count != 0)
            {
                int sodu = Modify.Taikhoans(queryes)[0].Sodu - SoTien;
                string plus = "Update Taikhoan set SoDu = SoDu + " + ST + " where SoTK = " + SoTK + "";
                string minus = "Update Taikhoan set SoDu = SoDu - " + ST + " where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                Modify.command(plus);
                Modify.command(minus);
                TransferDone transferDone = new TransferDone();
                this.Hide();
                Transfer.hide();
                transferDone.StartPosition = FormStartPosition.CenterScreen;
                transferDone.setdata(SoTien, soTaiKhoan, tenBank, Noidung, sodu);
                string date = currentTime.Hour + ":" + currentTime.Minute + " " + currentTime.Month + "/" + currentTime.Day + "/" + currentTime.Year;
                History.AddUserControlToHistory(date, Noidung, ST);
                transferDone.ShowDialog();
                this.Close();
                Transfer.Close();
            }
            else
            {
                error_label.Text = "Account number is incorrect!"; return;
            }
        }

        private void textBox_TKname_Leave(object sender, EventArgs e)
        {
            string SoTK = textBox2_taiKhoanThuaHuong.Text;
            int soTaiKhoan;
            string nBank = textBox1_tenNganHang.Text;
            if (int.TryParse(SoTK, out soTaiKhoan) == false)
            {
                error_label.Text = "Please enter the correct account number!"; return;
            }
            string query = "select * from Taikhoan where BankName ='" + nBank + "' and SoTK = " + soTaiKhoan + "";
            if (Modify.Taikhoans(query).Count != 0)
            {
                textBox2_taiKhoanThuaHuong.Text = SoTK;
                textBox_TKname.Text = Modify.Taikhoans(query)[0].Name;
                error_label.Text = "";
            }
            else
            {
                error_label.Text = "Please enter the correct account number!";
                textBox2_taiKhoanThuaHuong.Text = string.Empty;
            }
        }
    }
}
