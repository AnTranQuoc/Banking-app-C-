using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
namespace TH3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Historyy history = new Historyy();
            form1.StartPosition = FormStartPosition.CenterScreen;
            history.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form1);
        }
    }
}
