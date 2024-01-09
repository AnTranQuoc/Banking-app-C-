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

namespace TH3
{
    public partial class SavingDone : Form
    {
        public SavingDone()
        {
            InitializeComponent();
        }
        Saving Saving = new Saving();
        DateTime currentTime = DateTime.Now;
        Modify Modify = new Modify();
        Home Home = new Home();
        string query = "select * from Taikhoan where TenTk ='" + Properties.Settings.Default.getTenTK + "'";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.StartPosition = FormStartPosition.CenterScreen;
            home.SetText(query);
            home.ShowDialog();
            this.Close();
        }
        public void setdata(int sotien, int sotk, string tenbank, string noidung)
        {
            string cm = "select * from Taikhoan where SoTK ='" + sotk + "'";
            string date = currentTime.Hour + ":" + currentTime.Minute + " " + currentTime.Month + "/" + currentTime.Day + "/" + currentTime.Year;
            label1_datetime.Text = date;
            label2_TkNguon.Text = Modify.Taikhoans(query)[0].Sotk.ToString();
            label3_name.Text = Modify.Taikhoans(cm)[0].Name.ToString();
            label4_money.Text = sotien.ToString("N0", System.Globalization.CultureInfo.InvariantCulture) + "$";
            label5_period.Text = tenbank;
            label6_NoiDungCK.Text = noidung;
            label_SOTIEN.Text = sotien.ToString("N0", System.Globalization.CultureInfo.InvariantCulture) + "$";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saving.StartPosition = FormStartPosition.CenterScreen;
            Saving.setdata(query);
            Saving.ShowDialog();
            this.Close();
        }
    }
}
