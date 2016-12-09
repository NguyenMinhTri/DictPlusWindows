using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace Tu_Dien_1._1
{
    public partial class studyVocabulary : DevExpress.XtraEditors.XtraForm
    {
        Button btnTemp;
      
        public studyVocabulary(Button btnTemp)
        {
           
            this.btnTemp = btnTemp;
            InitializeComponent();
            pictureBox1.Visible = false;
            cbExp.Enabled = cbViet.Checked;
            lbMean.Visible = cbViet.Checked;
            lbVoca.Visible = cbAnh.Checked;
        }

        private void studyVocabulary_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnTemp.Enabled = false;
            errorProvider1.Icon = Properties.Resources.iconError;
            errorProvider1.SetError(textBox1, "False");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (textBox1.Text.ToLower() == tb.iVocabulary.Split('|')[0].ToLower().Trim())
                {
                    errorProvider1.Icon = Properties.Resources.iconCheck;
                    errorProvider1.SetError(textBox1, "True");

                }
                else
                {
                    errorProvider1.Icon = Properties.Resources.iconError;
                    errorProvider1.SetError(textBox1, "False");

                }
            }
        }
     
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`' && !cbAnh.Checked)
            {
                lbVoca.Visible = true;
                e.Handled = true;
            }
            

        }
    
       
      
        private void studyVocabulary_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter writeScore = new StreamWriter(string.Concat(Application.StartupPath, "\\Score.txt"));
            
            writeScore.WriteLine(tb.countTrue.ToString());
            writeScore.WriteLine(tb.countFalse.ToString());
            tb.cbNext.Checked = false;
            writeScore.Close();
            btnTemp.Enabled = true;
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDung.Text = tb.countTrue.ToString() + "/" + tb.countFalse.ToString();
            if (checkBox1.Checked)
            {
                if (textBox1.Text.ToLower() == tb.iVocabulary)
                {
                    errorProvider1.Icon = Properties.Resources.iconCheck;
                    errorProvider1.SetError(textBox1, "True");

                }
                else
                {
                    errorProvider1.Icon = Properties.Resources.iconError;
                    errorProvider1.SetError(textBox1, "False");

                }
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.iconError;
                errorProvider1.SetError(textBox1, "False");
            }
            if (tb.numberTB == 0)
                this.Close();
            try
            {
               // if (cbViet.Checked)
                {
                    try
                    {
                        if (cbExp.Checked)
                            lbMean.Text = tb.iMean.Replace("/", "\r\nEXP:").Replace(tb.iVocabulary.Split('|')[0].ToLower().Trim(), ".....");
                        else
                            lbMean.Text = tb.iMean.Split('/')[0];
                    }
                    catch
                    {
                        lbMean.Text=tb.iMean;
                    }
                }
               // if (cbAnh.Checked)
                {
                    
                    {
                        lbVoca.Text = tb.iVocabulary.Split('|')[0].ToLower().Trim();
                    }
                }
            }
            catch(Exception)
                {

                }
            try
            {
                pictureBox1.Image = tb.iImage;
            }
            catch
            {

            }
        }

        private void cbViet_CheckedChanged(object sender, EventArgs e)
        {
            cbExp.Enabled = cbViet.Checked;
             lbMean.Visible = cbViet.Checked;
            textBox1.Focus();
        }

        private void cbAnh_CheckedChanged(object sender, EventArgs e)
        {
           
                lbVoca.Visible = cbAnh.Checked;
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if ((textBox1.Text.ToLower() == tb.iVocabulary.Split('|')[0].ToLower().Trim()))
                    {
                        if (tb.cbNext.Checked)
                        {
                            tb.aTimer.Interval = 100;
                            tb.loopTB++;
                        }



                        if (tb.cbXoaTbSpeech.Checked && tb.iVocabulary.Split('|')[0].ToLower().Trim() == tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Header.Split('|')[0].ToLower().Trim())
                        {
                            tb.toastNotificationsManager1.Notifications.Remove(tb.toastNotificationsManager1.Notifications[tb.loopTB - 1]);
                            
                            tb.loopTB--;
                            tb.numberTB--;
                            if (tb.cbNext.Checked == false)
                                tb.aTimer.Interval = 100;
                        }
                        tb.countTrue++;
                        cbAnh.Checked = false;
                    }
                    else
                    {
                        if (tb.cbNext.Checked)
                        tb.aTimer.Interval = 100;
                        tb.countFalse++;
                    }
                   
                    textBox1.Text = "";
                  
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
               
            }
            catch(Exception)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
         
      
    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tb.countTrue = 0;
            tb.countFalse = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = checkBox2.Checked;
            textBox1.Focus();
        }

        private void cbExp_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void studyVocabulary_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemtilde || !cbAnh.Checked)
           {
               lbVoca.Visible = false;
           }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tb.aTimer.Interval = 100;
            if (tb.loopTB != 0)
            tb.loopTB++;
            textBox1.Focus();
        }
    }
}
