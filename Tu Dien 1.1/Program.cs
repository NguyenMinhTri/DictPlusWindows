using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
namespace Tu_Dien_1._1
{

    internal static class Program
    {
        private static Question form1;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Question form1 = new Question();

            Program.form1 = form1;
            SingleInstance.Run(form1, new StartupNextInstanceEventHandler(Program.StartupNextInstanceHandler));
        }

        public static void StartupNextInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {
            Program.form1.Show();

        }
    }
}