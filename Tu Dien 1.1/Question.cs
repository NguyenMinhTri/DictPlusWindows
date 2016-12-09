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
    public partial class Question : DevExpress.XtraEditors.XtraForm
    {
        
      
        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {

        }
       
        private void btnLoad_Click(object sender, EventArgs e)
        {


            tb.soAV = 513781;//513781;
            tb.sotu = 99175; //99175;
            tb formMain = new tb();
            formMain.FormClosing += FormIsClosing;
            formMain.Show();

            this.Hide();
            
        }

        private void btnNoload_Click(object sender, EventArgs e)
        {

            tb.soAV = 1;
            tb.sotu = 0;
            tb formMain = new tb();
            tb.tabOffline.Controls.RemoveAt(0);
            formMain.FormClosing += FormIsClosing;
            formMain.Show();
           
            this.Hide();
        }
        

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }
            this.Close();

            Application.Exit();
        }

        private void btnAV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            tb.soAV = 1;
            tb.sotu = 99175;
            tb formMain = new tb();
           
            formMain.FormClosing += FormIsClosing;
            formMain.Show();

            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tb.soAV = 513781;
            tb.sotu = 0;
            tb formMain = new tb();
            formMain.FormClosing += FormIsClosing;
            formMain.Show();
            tb.comboBox1.Enabled = false;
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            tb.soAV = 1;
            tb.sotu = 99175;
            tb formMain = new tb();
            formMain.FormClosing += FormIsClosing;
            formMain.Show();
            tb.comboBox1.SelectedIndex = 0;
            tb.comboBox1.Enabled = false;
            this.Hide();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
