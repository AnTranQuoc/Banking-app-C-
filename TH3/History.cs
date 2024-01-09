using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH3
{
    class History
    {
        private int id;
        private string date;
        private string noidung;
        private string sotien;
        
        public History()
        {
        }
        public History(int id, string date, string noidung, string sotien)
        {
            this.date = date;
            this.noidung = noidung;
            this.sotien = sotien;
            this.id = id;
        }
        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Sotien { get => sotien; set => sotien = value; }
    }
}
