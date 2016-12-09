using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tu_Dien_1._1
{
    public partial class Nofition : Form
    {
        CheckBox HienTB;
        public Nofition(ref CheckBox HienTB)
        {
            InitializeComponent();
            this.HienTB = HienTB;
            timer2.Start();
            timer1.Start();

        }

        private void Nofition_Load(object sender, EventArgs e)
        {
            this.Location = new Point(SystemInformation.VirtualScreen.Width - this.Width, SystemInformation.VirtualScreen.Height - this.Height - 40);

        }

        public void lbVoca_TextChanged(object sender, EventArgs e)
        {

        }
        public void ShowNofition()
        {
            if (HienTB.Checked && !tb.cbToast.Checked)
            {
                timer1.Stop();
                this.Location = new Point(SystemInformation.VirtualScreen.Width - this.Width, SystemInformation.VirtualScreen.Height - this.Height - 40);
                timer1.Start();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Location.X == SystemInformation.VirtualScreen.Width - this.Width && !tb.cbLL.Checked)
            //if (this.Visible == true)
            {
                this.Location = new Point(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height - this.Height - 40);
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbCheckChange.Text = tb.loopTB.ToString();
            try
            {
                if (tb.loopTB != 0)
                {
                    lbVoca.Text = tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Header;
                    lbMean.Text = tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Body;
                }
                

            }
            catch
            {
                if (lbVoca.Text == "" && this.Location.X == SystemInformation.VirtualScreen.Width - this.Width)
                    this.Location = new Point(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height - this.Height - 40);
            }
        }

        private void lbCheckChange_TextChanged(object sender, EventArgs e)
        {
            ShowNofition();
        }


    }
}

