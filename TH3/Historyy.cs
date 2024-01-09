using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TH3
{
    public partial class Historyy : Form
    {
        public Historyy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.StartPosition = FormStartPosition.CenterScreen;
            home.SetText("select * from Taikhoan where TenTk ='" + Properties.Settings.Default.getTenTK + "'");
            home.ShowDialog();
            this.Close();
        }
        
        int y = 1;
        Modify Modify = new Modify();
        List<uscHistory> userControlList = new List<uscHistory>();
        public void AddUserControlToHistory(string a, string b, string c)
        {
            string cm1 = "Update History set Date = '" + a + "' where id = " + Properties.Settings.Default.Count + "";
            string cm2 = "Update History set Noidung = '" + b + "' where id = " + Properties.Settings.Default.Count + "";
            string cm3 = "Update History set Sotien = '" + c + "' where id = " + Properties.Settings.Default.Count + "";
            Modify.command(cm1);
            Modify.command(cm2);
            Modify.command(cm3);
            Properties.Settings.Default.Count += 1;
        }
      
        private void History_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < Properties.Settings.Default.Count; i++)
            {
                string a = "select * from History where id =" + i + "";
                string b = "select * from History where id =" + i + "";
                string c = "select * from History where id =" + i + "";
                uscHistory uscHistory = new uscHistory();
                string aa = Modify.Historys(a)[0].Date;
                string bb = Modify.Historys(b)[0].Noidung;
                string cc = Modify.Historys(c)[0].Sotien + "$";
                uscHistory.SetText(aa,bb,cc);
                this.flowLayoutPanel1.Controls.Add(uscHistory);
                userControlList.Add(uscHistory);
                uscHistory.Location = new System.Drawing.Point(0, y);
                y = y - 40;
            }
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
