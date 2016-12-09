using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Runtime.InteropServices;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using MouseKeyboardActivityMonitor.HotKeys;
using MouseKeyboardActivityMonitor.Controls;
using WMPLib;
using System.Diagnostics;
using System.Windows.Automation;

namespace Tu_Dien_1._1
{
    public partial class FormSOHA : DevExpress.XtraEditors.XtraForm
    {
        bool PressCtrl = false;
        Stopwatch watch;
        public bool isCloseForm=false;
        string tempClipBoard = "";
        private static readonly MouseHookListener m_MouseHookManager = new MouseHookListener(new GlobalHooker());
        string textBoxLog = " ";
        static string TranBing = "";
        getDataSOHA meanVASOHA;
        getDataOxford meanAnhAnh;
        //
        private static readonly KeyboardHookListener m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
       

        SpeechSynthesizer reader = new SpeechSynthesizer();
        string temp = ".........";
        static Point[] tempP = new Point[2];
        static int i = 0;
        StreamReader fsData = new  StreamReader(string.Concat(Application.StartupPath, "\\anhviet109K.dict"));
        bool isApear;
        string temp2 = "...";
        string AllMeaningFile;
        public string Demotext;
        public string DemotextMean;
        SpeechEnglish Speech;
        public Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;

        }      
        getDataLacViet meanVALV;
        public FormSOHA()
        {                       
           // tb.btnSOHA.Enabled = false;
            m_KeyboardHookManager.Enabled = true;
            m_KeyboardHookManager.KeyDown += HookManager_KeyDown;
            m_KeyboardHookManager.KeyPress += HookManager_KeyPress;
            m_KeyboardHookManager.KeyUp += HookManager_KeyUp;
            InitializeComponent();
            Speech = new SpeechEnglish();
            meanVASOHA = new getDataSOHA();
            meanVALV = new getDataLacViet();
            meanAnhAnh = new getDataOxford();
            //
            AllMeaningFile = fsData.ReadToEnd();
            //hook mouse 
            //timer2.Start();
            //
          
            m_MouseHookManager.Enabled = true;
           
            m_MouseHookManager.MouseDownExt += HookManager_Supress;
            m_MouseHookManager.MouseClickExt += HookManager_MouseClick;
            m_MouseHookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
            m_MouseHookManager.MouseMove += HookManager_MouseMove;
            webBrowser2.ScriptErrorsSuppressed = true;
            this.Location = hideForm;
            textBox2.Text = "";            
            this.TopMost = true;
        }
       
        Point hideForm = new Point(500, 500);
        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            
                hideForm = new Point(e.X, e.Y+13);
   
        }
        private void HookManager_Supress(object sender, MouseEventExtArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            
            watch = Stopwatch.StartNew();
        }
        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.KeyCode.ToString());
            if ((Keys)e.KeyCode == Keys.LControlKey)
            {
                if (barCheckItem1.Checked)
                    PressCtrl = true;
            }
        }
        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.LControlKey))
            {
                
                PressCtrl = false;
            }
        }
        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys) e.KeyChar==Keys.Cancel &&  bcCB.Checked)
            {              
                try
                {
                  
                    FormSOHA_Load(null, null);
            
                    timer1.Start();
                  
                }
                catch
                {

                }
            }
            
           
            
        }

        string tempText = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if ((bcCB.Checked|| bcHL.Checked||barCheckItem1.Checked))
                {
                    if ((tempP[0].X <= hideForm.X) && (hideForm.X <= (tempP[0].X + this.Width+12)) && (tempP[0].Y <= hideForm.Y) && (hideForm.Y <= (tempP[0].Y + this.Height+43)) && isApear == true)
                    {
                        if(textBox2.Text!="")
                        this.Visible = true;
                        else
                        {
                            webBrowser2.DocumentText = "Loading....";
                        }
                        
                    }
                    else
                    {
                       
                        this.Visible = false;
                        
                        if (bcOnly.Checked == false)
                            Speech.StopSpeak();
                     
                        webBrowser2.DocumentText = "Loading....";
                        textBox2.Text = "";
                        isApear = false;
                      
                        timer1.Stop();
                       
                    }
                 

                }
                if ((bcHL.Checked||barCheckItem1.Checked) && tempCLIPBOARD=="")
                {

                    if (textBox2.Text == "\r\n" && textBoxLog != "Double")
                        textBoxLog = "AAA";
                    var element = AutomationElement.FocusedElement;
                    if (element != null)
                    {
                        object pattern;
                        if (element.TryGetCurrentPattern(TextPattern.Pattern, out pattern))
                        {
                            var tp = (TextPattern)pattern;
                            var sb = new StringBuilder();

                            foreach (var r in tp.GetSelection())
                            {
                                sb.AppendLine(r.GetText(-1));
                            }

                            if (textBoxLog == "Left" || textBoxLog == "Double")
                            {

                                //if (textBoxLog == "double")
                                //Thread.Sleep(100);
                                textBox2.Text = sb.ToString();

                                //Debug.WriteLine(textBox2.Text);
                                if (textBox2.Text == " " || textBox2.Text == "" || textBox2.Text == "\r\n")
                                    return;
                                textBoxLog = "AAA";


                            }
                        }

                        else
                        {
                            if ((textBoxLog == "Left" || textBoxLog == "Double") )
                            {
                           
                                textBoxLog = "AAA";
                                if (!bcOnly.Checked)
                                    Thread.Sleep(100);
                               
                                try
                                {                                  
                                    SendKeys.SendWait("^(c)");
                                    
                                    SendKeys.Flush();

                                    textBox2.Text = Clipboard.GetText();
                                    
                                   
                                    if (tempText != "")
                                        Clipboard.SetText(tempText);                               
                                }
                                catch (Exception)
                                {
                                    textBox2.Text = "";
                                    Debug.WriteLine("A");
                                    return;
                                }

                                    tempClipBoard = textBox2.Text;
                            }
                        }
                        if (textBox2.Text == tempText)
                           // if (!bcOnly.Checked)
                                Thread.Sleep(200);
                           
                        
                        if (textBox2.Text == " " || textBox2.Text == "" || textBox2.Text == "\r\n" )
                        {
                           
                            return;
                        }
                      
                        if (i % 2 == 0)
                        {
                            temp = textBox2.Text;

                        }
                        else
                        {
                            try
                            {
                                temp2 = textBox2.Text;
                            }
                            catch (Exception)
                            {
                                Debug.WriteLine("3" + textBox2.Text);
                                return;
                            }

                        }
                        
                    }
                   
                }
                else if (bcCB.Checked  && tempCLIPBOARD == "")
                {
                   
                    IDataObject ClipData = System.Windows.Forms.Clipboard.GetDataObject();
                    if (ClipData.GetDataPresent(DataFormats.Text))
                    {
                        textBox2.Text = System.Windows.Forms.Clipboard.GetData(DataFormats.Text).ToString().ToLower();
                        textBox2.Text = textBox2.Text.Trim();
                        if (i % 2 == 0)

                            temp = textBox2.Text;
                        else
                            temp2 = textBox2.Text;
                    }
                   
                    if (temp == temp2)
                        return;
                    isApear = false;
                }
                Debug.WriteLine("5"+textBox2.Text);

                if (textBox2.Text == " " || textBox2.Text == "" || textBox2.Text == "\r\n")
                    return;
                if (/*temp != temp2 &&*/ textBox2.Text != "" && textBox2.Text != "\r\n" && isApear == false)
                {


                    if (bcOnly.Checked == true)
                        Speech.StopSpeak();

                    textBox2.Text = outChuanHoa(textBox2.Text);

                    if ((TranBing == "B" || bcBing.Checked) && bcOF.Checked == false)
                    {
                        if (bcSpeak.Checked)
                            txtSpeech = textBox2.Text;
                        speechEnglish(bcSpeak.Checked, textBox2.Text);
                        if (bcOnly.Checked == false)
                        {
                            stransBING = new Thread(initBing);
                            stransBING.Start();
                        }
                    }
                    else
                    {
                        if (bcSpeak.Checked)
                            txtSpeech = textBox2.Text;
                        speechEnglish(bcSpeak.Checked, textBox2.Text);
                        if (bcOnly.Checked == false)
                        {
                            if (bcOxF.Checked)
                            {
                                getOXford = new Thread(getOxford);
                                getOXford.Start();
                            }
                            else
                            if (bcSOHA.Checked)
                            {
                                demoTH = new Thread(initTH);

                                demoTH.Start();
                            }
                            else if(bcLV.Checked && !bcOxF.Checked)
                            {
                                runBrowserThread("http://mobile.coviet.vn/tratu.aspx?k=" + textBox2.Text + "&t=ALL");
                            }
                            
                            else
                            {
                                runBrowserThread("http://mobile.coviet.vn/tratu.aspx?k=" + textBox2.Text + "&t=ALL");

                            }

                        }
                    }
                    textBoxLog = "AAA";
                   
                    if (bcOnly.Checked == false)
                        this.FormSOHA_Load(sender, e);
                }
               
                i++;
            }
            catch (Exception)
            {
                return;
            }
            
        }
        static Thread demoTH;
        Thread getOXford;
        void getOxford()
        {
            webBrowser2.DocumentText = meanAnhAnh.meanAV(textBox2.Text);
        }
        void initTH()
        {
            
            string DocumentText = meanVASOHA.meanAV(bcTT.Checked, bcOF.Checked, textBox2.Text);
            if (!tb.FullPage)
            {
                string cccc = "<p><font color=" + '"' + "red" + '"';
                DocumentText = DocumentText.Replace("<h3>", "<h4>");
                DocumentText = DocumentText.Replace("<h5>", "<h3>" + cccc);
            }
            try
            {
                webBrowser2.DocumentText = DocumentText;
            }
            catch
            {
                webBrowser2.DocumentText = "No data or error";
            }
        }
        static Thread stransBING;
        void initBing()
        {
            try
            {
                webBrowser2.DocumentText = stranslatorBing(textBox2.Text);
            }
            catch
            {

            }
           
        }
        private void FormSOHA_Load(object sender, EventArgs e)
        { //308,207//1366 767
            tempP[0] = hideForm;
            if (tempP[0].Y > (SystemInformation.VirtualScreen.Height -this.Height))
                tempP[0].Y = tempP[0].Y - this.Height;
            else
                tempP[0].Y = tempP[0].Y + 13;
            if (tempP[0].X > (SystemInformation.VirtualScreen.Width -this.Width))
                tempP[0].X = tempP[0].X - this.Width;
            tempP[0].Y = tempP[0].Y - 13;
            isApear = true;
            this.Location = tempP[0];
            
            
        }

        private string GetMeaning(string wordInput)
        {
            string meaning = "";
            try
            {

                AllMeaningFile = fsData.ReadToEnd();
                int posIndex = 0;
                fsData.BaseStream.Position = 0;

                // find position wordInput in string AllMeaningFile
                posIndex = AllMeaningFile.IndexOf("@" + wordInput + " ");
                if (posIndex == -1)
                    posIndex = AllMeaningFile.IndexOf("@" + wordInput + "\n");
                AllMeaningFile = AllMeaningFile.Substring(posIndex + 1, AllMeaningFile.Length - posIndex - 1);
                // find next @
                int posNextA = AllMeaningFile.IndexOf('@');
                meaning = AllMeaningFile.Substring(0, posNextA);
                // html style for meaning 
                meaning = meaning.Insert(wordInput.Length + 1, "</b></font>");
                meaning = "<font color=\"#FF0000\"><b>" + meaning;
                meaning = meaning.Replace("\n*", "<br/><b>*");
                meaning = meaning.Replace("\n-", "</b><br/>&nbsp;-");
                meaning = meaning.Replace("\n", "<br/>");
            }
            catch
            {
                meaning = "No data or error";
            }
            return meaning;
        }
        public static bool isBing = false;
        TranslatorBing Bing;
        string stranslatorBing(string inPut)
        {
            if (bcOF.Checked || System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == false)
                return "No data or error";
            try
            {
                if (isBing == false)
                {
                    isBing = true;
                    Bing = new TranslatorBing();
                    
                }
                return Bing.TranslateMethod(inPut);
            }
            catch
            {
                return "No data or error";
            }
           
                
        }
        string outChuanHoa(string text)
        {

            //1 la vao " \r\n" xoa bo
            //2 la vao " "
            //3 la vao "\r\n"
            text = text.Trim();
            text = text.ToLower();
            try
            {
                if (text.Split(' ')[1] != null && text.Split(' ')[1] != "\r\n" && text.Split(' ')[1] != " " && text.Split(' ')[1] != "" && text.Split(' ')[1] != "\r\r\n")
                {
                    TranBing = "B";
                    return text;
                }
                else
                {

                    text = text.Split(' ')[0];
                    TranBing = "";
                    return text;

                }
            }
            catch
            {
                try
                {
                    if (text.Substring(text.Length - 2) == "\r\n")
                        text = text.Substring(0, text.Length - 2);
                    TranBing = "";
                    return text;
                }
                catch
                {
                    TranBing = "";
                    return text;
                }

            }



        }
        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bcHL.Checked && !bcCB.Checked && !barCheckItem1.Checked)
                return;
            
                
            if (e.Button.ToString() == "Left")
            {
                try
                {
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    if (elapsedMs > 500||PressCtrl)
                    {
                        if (bcHL.Checked||PressCtrl )
                        {
                            if (!bcOnly.Checked)
                            {
                               
                                FormSOHA_Load(sender, e);
                              
                            }
                            try
                            {
                                tempText = Clipboard.GetText();
                            }
                            catch
                            {

                            }

                            timer1.Start();
                        }
                        textBoxLog = e.Button.ToString();
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
      
        private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (!bcHL.Checked && !bcCB.Checked && !barCheckItem1.Checked)
                return;
            
                if (bcHL.Checked || PressCtrl )
                {
                    if (!bcOnly.Checked)
                    {                   
                        FormSOHA_Load(sender, e);
                    }
                    try
                    {
                        tempText = Clipboard.GetText();
                    }
                    catch
                    {

                    }
                    
                    timer1.Start();
                }
                textBoxLog = "Double";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (bcHL.Checked)
            {
                timer1.Start();

            }
            else
                if (bcCB.Checked)
                {
                    timer1.Start();
                }
                else if (bcNormal.Checked)
                {
                    timer1.Stop();
                }
                else if (barCheckItem1.Checked)

                    timer1.Start();
            
        }
        private void speakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bcSpeak.Checked == false)
            {
                bcOnly.Checked = false;
            }

        }
        public static string txtSpeech="";
        void initSpeech()
        {
            Speech.GirlSpeak(txtSpeech);
            txtSpeech = "";
        }
        Thread initSPeechVoice;
        void speechEnglish(bool check, string text)
        {
            if (check)
            {
                initSPeechVoice = new Thread(initSpeech);
                initSPeechVoice.Start();
                //Speech.GirlSpeak(text);
            }
        }

        private void speakOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bcSpeak.Checked = bcOnly.Checked;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCloseForm = true;
            this.Close();
        }

        private void HideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            bcHL.Checked = false;
            bcCB.Checked = false;
            bcNormal.Checked = true ;
            barCheckItem1.Checked = false;
        }
    
        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" &&( bcHL.Checked||barCheckItem1.Checked))
            {
              
                FormSOHA_Load(sender, e);
                isApear = false;
                
            }
        }
        string tempCLIPBOARD = "";

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (!bcOxF.Checked)
            {
                if (webBrowser2.DocumentText == "Loading...." || bcDD.Checked)
                    return;

                webBrowser2.Document.ExecCommand("SelectAll", false, null);
                tempCLIPBOARD = Clipboard.GetText();
                webBrowser2.Document.ExecCommand("Copy", false, null);
                webBrowser2.Document.ExecCommand("PASTE", false, null);
                DemotextMean = Clipboard.GetText();
                Clipboard.SetText(tempCLIPBOARD);
                Demotext = textBox2.Text;
                tb.tbHistory.Text = textBox2.Text;
                tempCLIPBOARD = "";
            }
            else
            {
                try
                {
                    //if (cccc == 5)
                    {
                        if (this.Width > 802)
                        {
                            webBrowser2.Document.Window.ScrollTo(0, 65);
                        }
                        if (565 < this.Width && this.Width <= 802)
                        {
                            webBrowser2.Document.Window.ScrollTo(0, 90);
                        }
                        if (446 < this.Width && this.Width <= 565)
                        {
                            webBrowser2.Document.Window.ScrollTo(0, 115);
                        }
                        if (377 < this.Width && this.Width <= 446)
                        {
                            webBrowser2.Document.Window.ScrollTo(0, 140);
                        }
                        if (this.Width < 377)
                        {
                            webBrowser2.Document.Window.ScrollTo(0, 165);
                        }
                    }

                }
                catch
                {

                }
            }
        }
      
        private void FormSOHA_FormClosed(object sender, FormClosedEventArgs e)
        {

            tb.btnSOHA.Enabled = true;
           
            m_MouseHookManager.MouseDoubleClick -= HookManager_MouseDoubleClick;
            m_MouseHookManager.MouseClickExt -= HookManager_MouseClick;
            m_MouseHookManager.MouseMove -= HookManager_MouseMove;
            m_KeyboardHookManager.KeyPress -= HookManager_KeyPress;
            m_KeyboardHookManager.KeyUp -= HookManager_KeyUp;
            m_KeyboardHookManager.KeyDown -= HookManager_KeyDown;
            m_KeyboardHookManager.Enabled = false;
            m_MouseHookManager.Enabled = false;
            isCloseForm = true;
        
        }
        

        private void offlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (bcOF.Checked)
                bcOnly.Checked = false;
        }

        
        //lac viet
        static Thread th;
        private void runBrowserThread(string url)
        {
             th = new Thread(() =>
            {
                var br = new WebBrowser();
                br.DocumentCompleted += browser_DocumentCompleted;
                br.Navigate(url);
                br.ScriptErrorsSuppressed = true;
                Application.Run();
                
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

            var br = sender as WebBrowser;
            if (br.Url == e.Url)
            {
                string DocumentText = meanVALV.meanAV(bcTT.Checked, bcOF.Checked, textBox2.Text, br.DocumentText);
                webBrowser2.DocumentText = DocumentText;
                Application.ExitThread();   // Stops the thread
            }
        }

     

        private void barCheckItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bcNormal.Checked)
            {

                bcHL.Checked = false;
                bcCB.Checked = false;
                barCheckItem1.Checked = false;
                timer1.Stop();
            }
            else
                bcNormal.Checked = true;
        }

        private void barCheckItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bcHL.Checked)
            {
                
                bcNormal.Checked = false;
                bcCB.Checked = false;
                barCheckItem1.Checked = false;
                timer1.Start();
                this.Visible = false;
            }
            bcHL.Checked = true;
        }

        private void barCheckItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bcCB.Checked)
            {
               
                bcHL.Checked = false;
                bcNormal.Checked = false;
                barCheckItem1.Checked = false;
                timer1.Start();
            }
            else
            bcCB.Checked = true;
        }

        private void barCheckItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb.FullPage = false ;
            if (bcTT.Checked)
            {
                bcKT.Checked = false;
                bcDD.Checked = false;
                bcThongDung.Checked = false;
                bcOxF.Checked = false;
            }
            else
                bcTT.Checked = true;
        }

        private void barCheckItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb.FullPage = false;
            if (bcKT.Checked)
            {
                bcTT.Checked = false;
                bcDD.Checked = false;
                bcOxF.Checked = false;
                bcThongDung.Checked = false;
            }
            else
                bcKT.Checked = true;
        }

        private void bcOF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bcOF.Checked)
            {
                bcLV.Checked = false;
                bcSOHA.Checked = false;
                bcBing.Checked = false;

            }
            else
                bcOF.Checked = true;

        }

        private void bcBing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bcBing.Checked)
            {
                bcLV.Checked = false;
                bcSOHA.Checked = false;
                bcOF.Checked = false;
            }
            else
                bcBing.Checked = true;
        }

        private void bcSOHA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bcSOHA.Checked)
            {
                bcLV.Checked = false;
                bcOF.Checked = false;
                bcBing.Checked = false;
            }
            else
                bcSOHA.Checked = true;
        }

        private void bcLV_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barSubItem4_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (bcSpeak.Checked == false)
            {
                bcOnly.Checked = false;

            }
           
        }

        private void bcOnly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bcSpeak.Checked = bcOnly.Checked;
        }
        
        private void bcDD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb.FullPage = bcDD.Checked;
            if (bcDD.Checked)
            {
                bcTT.Checked = false;
                bcKT.Checked = false;
                bcOxF.Checked = false;
                bcThongDung.Checked = false;
            }
            else
                bcDD.Checked = true;
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bcTT_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bcLV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bcLV.Checked)
            {
                bcOF.Checked = false;
                bcBing.Checked = false;
                bcSOHA.Checked = false;

            }
            else
                bcLV.Checked = true;
        }

        private void bcOxF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb.FullPage = bcDD.Checked;
            if (bcOxF.Checked)
            {
                bcTT.Checked = false;
                bcKT.Checked = false;
                bcDD.Checked = false;
            }
            else
                bcOxF.Checked = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (bcOnly.Checked == true)
                    Speech.StopSpeak();

                textBox2.Text = outChuanHoa(textBox2.Text);

                if ((TranBing == "B" || bcBing.Checked) && bcOF.Checked == false)
                {
                    if (bcSpeak.Checked)
                        txtSpeech = textBox2.Text;
                    speechEnglish(bcSpeak.Checked, textBox2.Text);
                    if (bcOnly.Checked == false)
                    {
                        stransBING = new Thread(initBing);
                        stransBING.Start();
                    }
                }
                else
                {
                    if (bcSpeak.Checked)
                        txtSpeech = textBox2.Text;
                    speechEnglish(bcSpeak.Checked, textBox2.Text);
                    if (bcOnly.Checked == false)
                    {
                        if (bcOxF.Checked)
                        {
                            getOXford = new Thread(getOxford);
                            getOXford.Start();
                        }
                        else
                            if (bcSOHA.Checked)
                            {
                                demoTH = new Thread(initTH);

                                demoTH.Start();
                            }
                            else if (bcLV.Checked && !bcOxF.Checked)
                            {
                                runBrowserThread("http://mobile.coviet.vn/tratu.aspx?k=" + textBox2.Text + "&t=ALL");
                            }

                            else
                            {
                                runBrowserThread("http://mobile.coviet.vn/tratu.aspx?k=" + textBox2.Text + "&t=ALL");

                            }

                    }
                }
            }
        }

        private void barCheckItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem1.Checked)
            {

                bcHL.Checked = false;
                bcNormal.Checked = false;
                bcCB.Checked = false;
                timer1.Start();
                this.Visible = false;
            }
            else
                barCheckItem1.Checked = true;
        }

        private void bcThongDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb.FullPage = bcDD.Checked;
            if (bcThongDung.Checked)
            {
                bcOxF.Checked = false;
                bcTT.Checked = false;
                bcKT.Checked = false;
                bcDD.Checked = false;
                bcSOHA.Checked = true;
            }
            else
                bcThongDung.Checked = true;
        }

       




    }

}
