using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;
namespace Tu_Dien_1._1
{
    //class SingleInstance để cho chỉ mở được 1 app.
    internal class SingleInstance : WindowsFormsApplicationBase
    {
        private SingleInstance()
        {
            base.IsSingleInstance = true;
        }

        public static void Run(Form f, StartupNextInstanceEventHandler startupHandler)
        {
            SingleInstance app = new SingleInstance()
            {
                MainForm = f
            };
            app.StartupNextInstance += startupHandler;
            app.Run(Environment.GetCommandLineArgs());
        }
    }
}