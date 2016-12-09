using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor.WinApi;
using MouseKeyboardActivityMonitor;
using System.IO;
namespace Tu_Dien_1._1
{
    public partial class Predictive : DevExpress.XtraEditors.XtraForm
    {
        StreamReader fr = new StreamReader(string.Concat(Application.StartupPath, "\\text1.dict"));
        private readonly KeyboardHookListener m_KeyboardHookManager;

        string AllMeaningFile;
        Button btnTemp;
        public Predictive(Button btn)
        {

            btnTemp = btn;
            btnTemp.Enabled = false;
            this.TopMost = true;
            m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            m_KeyboardHookManager.Enabled = true;
            m_KeyboardHookManager.KeyPress += HookManager_KeyPress;
            InitializeComponent();
        }
        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                {
                    textEdit1.Text = textEdit1.Text + e.KeyChar;
                    textEdit2.Text = GetMeaning(textEdit1.Text.ToLower());

                }

                if (e.KeyChar == '\b')
                {
                    textEdit1.Text = textEdit1.Text.Remove(textEdit1.Text.Length - 1);
                    
                        //textEdit2.Text = GetMeaning(textEdit1.Text);
                    

                }
                if (e.KeyChar == (char)Keys.Space)
                {
                    try
                    {


                        SendKeys.SendWait(textEdit2.Text.Substring(textEdit1.Text.Length));
                        textEdit1.Text = "";
                        textEdit2.Text = "";
                    }
                    catch (Exception)
                    {
                        textEdit1.Text = "";
                        textEdit2.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {
                textEdit1.Text = "";
                return;
            }

            // 
        }
        private string GetMeaning(string wordInput)
        {
            string meaning = "";
            try
            {

                AllMeaningFile = fr.ReadToEnd();
                int posIndex = 0;
                fr.BaseStream.Position = 0;

                // find position wordInput in string AllMeaningFile
                posIndex = AllMeaningFile.IndexOf("@" + wordInput);

                //if (comboBox1.Text=="Hight-Light")
                //{
                //    wordInput=wordInput.Substring(0, wordInput.Length - 3);
                //    pos = AllMeaningFile.IndexOf("@" + wordInput);
                //    pos = AllMeaningFile.IndexOf("@" + wordInput + " ");
                //    if (pos == -1)
                //        pos = AllMeaningFile.IndexOf("@" + wordInput + "\n");

                //    //cach khoang ra nua
                //}
                // get substring from pos to end string
                AllMeaningFile = AllMeaningFile.Substring(posIndex + 1, AllMeaningFile.Length - posIndex - 1);
                // find next @
                int posNextA = AllMeaningFile.IndexOf('@');
                meaning = AllMeaningFile.Substring(0, posNextA);
                // html style for meaning 
                // meaning = meaning.Insert(wordInput.Length + 1, "</b></font>");

            }
            catch (Exception ex)
            {
                meaning = "No data or error";
            }
            return meaning;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if(textEdit1.Text=="")
             textEdit2.Text = "";

        }

        private void Predictive_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnTemp.Enabled = true;
        }
       
    }
}
