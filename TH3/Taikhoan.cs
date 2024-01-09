using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH3
{
    class Taikhoan {
        private string tenTaikhoan;
        private string matkhau;
        private string name;
        private string gmail;
        private string date;
        private string anh;
        private int sodu;
        private int sotk;
        private string period;
        private string introducer;
        private int sav;
        private string bankname;
        public Taikhoan()
        {
        }
        public Taikhoan(string tenTaikhoan, string matkhau, string name, string gmail, string date, string anh, int sodu, int sotk, string period, string introducer, int sav, string bankname)
        {
            this.tenTaikhoan = tenTaikhoan;
            this.matkhau = matkhau;
            this.name = name;
            this.gmail = gmail;
            this.date = date;
            this.anh = anh;
            this.sodu = sodu;
            this.sotk = sotk;
            this.period = period;
            this.introducer = introducer;
            this.sav = sav;
            this.bankname = bankname;
        }

        public string TenTaikhoan { get => tenTaikhoan; set => tenTaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Name { get => name; set => name = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string Date { get => date; set => date = value; }
        public string Anh { get => anh; set => anh = value; }
        public int Sodu { get => sodu; set => sodu = value; }
        public int Sotk { get => sotk; set => sotk = value; }
        public string Period { get => period; set => period = value; }
        public string Introducer { get => introducer; set => introducer = value; }
        public int Sav { get => sav; set => sav = value; }
        public string Bankname { get => bankname; set => bankname = value; }
    }
}
