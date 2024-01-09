using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TH3
{
    public partial class uscHistory : UserControl
    {
        public uscHistory()
        {
            InitializeComponent();
        }
        public void SetText(string date, string noidung, string Sotien)
        {
            label1_date.Text = date;
            label2_noidung.Text = noidung;
            label3_Sotien.Text = Sotien;
        }
    }
}
