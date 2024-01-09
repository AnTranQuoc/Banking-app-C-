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
    public partial class savingcheck : Form
    {
        public savingcheck()
        {
            InitializeComponent();
        }
        Modify Modify = new Modify();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
          this.Close();
        }
        public void setdata()
        {
            string text = "select * from Taikhoan where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
            label2.Text = Modify.Taikhoans(text)[0].Sav.ToString("N0", System.Globalization.CultureInfo.InvariantCulture) + "$";
            label3_name.Text = Modify.Taikhoans(text)[0].Name;
            label5_period.Text = Modify.Taikhoans(text)[0].Period;
            label6_introducer.Text = Modify.Taikhoans(text)[0].Introducer;
            label2_SoTk.Text = Modify.Taikhoans(text)[0].Sotk.ToString();
        }
    }
}
