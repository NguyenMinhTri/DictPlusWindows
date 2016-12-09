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
using System.Net;
using System.Globalization;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Management;
using System.Threading;
using System.Configuration;
using WMPLib;
using System.Windows.Automation;
using System.Timers;
using Google.API.Search;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
namespace Tu_Dien_1._1
{
    public partial class tb : DevExpress.XtraEditors.XtraForm
    {
        getVoiceOxford SPEECH;
        public static System.Timers.Timer aTimer = new System.Timers.Timer(); // vòng lặp thông báo
        static public bool FullPage = false;
        /// <summary>
        /// Đa tiến trình tải anh từ google image
        /// </summary>
        static Thread loadImage;
        /// <summary>
        /// Số câu đúng / sai để xếp hạng từ
        /// </summary>
        public static int countTrue = 0;
        public static int countFalse = 0;
        /// <summary>
        /// đếm số lượng từ đưa vào nhận giọng nói
        /// </summary>
        static int slSpeak = 0;// dư
        /// <summary>
        /// Biến để nhận dạng giọng nói
        /// </summary>
        static SpeechRecognitionEngine recEngineTB = new SpeechRecognitionEngine();
        /// <summary>
        /// Đọc file mp3 của gióng nói tiếng việt
        /// </summary>
        static WindowsMediaPlayer nghedoanvanVIET = new WindowsMediaPlayer();
        /// <summary>
        /// Đếm số lượng các thông báo sẽ hiện thị
        /// </summary>
        static public int numberTB = 0;// đếm số lượng thông báo
        /// <summary>
        /// xuất thông báo tiếp theo
        /// </summary>
        static public int loopTB = 0;//xuất thông báo tiếp theo     
        /// <summary>
        /// Số lương từ Việt - Anh
        /// </summary>
        public static int sotu;
        /// <summary>
        /// Số lượng từ Anh - Việt
        /// </summary>
        public static int soAV ;                     
        public string AllMeaningFile;
        /// <summary>
        /// List chứa các button nghe Việt - Anh
        /// </summary>
        static string AnhViet;        
        /// <summary>
        /// đọc dữ liệu từ file Anh Việt
        /// </summary>
        public static StreamReader fsData = new StreamReader(string.Concat(Application.StartupPath, "\\anhviet109K.dict"));
        /// <summary>
        /// đọc dữ liệu từ file Việt Anh
        /// </summary>
        static StreamReader fs = new StreamReader(string.Concat(Application.StartupPath, "\\vietanh.dict"));            
        /// <summary>
        /// chứa dữ liệu không dấu tiếng việt
        /// </summary>
        public ListBox KhongDau = new ListBox(); 
        /// <summary>
        /// Các biến để hiện từ gọi ý trên form học từ
        /// </summary>
        static public string iVocabulary="";
        static public string iMean="";
        static public Image iImage = null;
        /// <summary>
        /// Phát âm từ vựng khi tra từ offline
        /// </summary>
        static SpeechSynthesizer reader = new SpeechSynthesizer();
        // vòng lặp thông báo
        private static readonly KeyboardHookListener m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {

            if (aTimer.Interval == 100 || aTimer.Interval == 500 || aTimer.Interval == 5000)
            {
                aTimer.Interval = int.Parse(tbCK.Text) * 7500;
            }
            
            button5_Click(sender, e);
  
        }
        DuLieuLichSu daTa;
   
        public tb()
        {
            m_KeyboardHookManager.Enabled = true;
            m_KeyboardHookManager.KeyDown += HookManager_KeyDown;
 
            fs.BaseStream.Position = 0;
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 7500;
            InitializeComponent();
            this.Icon = Properties.Resources.abcde;
            SPEECH = new getVoiceOxford();
            comboBox1.SelectedIndex = 0;
            cbbSelectLang.SelectedIndex = 0;
            {
                string mean = "";
                string[] cut;
                int i = 1;
                int tempsoAV = soAV;
                if (soAV == 1 && sotu!=0)
                    tempsoAV = sotu;
                while (i != tempsoAV)
                {
                    {
                        if(i<sotu)
                        {
                            mean = fs.ReadLine();
                            try
                            {
                                if (mean.Substring(0, 1) == "@")
                                {
                                    cut = mean.Split('/');
                                    listWord.Items.Add(cut[0].Substring(1, cut[0].Length - 1));
                                    KhongDau.Items.Add(RemoveUnicode(cut[0].Substring(1, cut[0].Length - 1)));
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                        if (soAV != 1)
                        {
                            mean = fsData.ReadLine();
                            try
                            {
                                if (mean.Substring(0, 1) == "@")
                                {
                                    cut = mean.Split('/');
                                    English.Items.Add(cut[0].Substring(1, cut[0].Length - 2));
                                }
                            }
                            catch 
                            {

                            }
                        }
                        i++;
                    }
                }
                fsData.DiscardBufferedData();
            }
            //nạp dữ liệu lên lịch sử
            daTa = new DuLieuLichSu(ref dataGridView1);
            dataGridView1.Sort(dataGridView1.Columns["STT"], ListSortDirection.Descending);
            StreamReader readScore = new StreamReader(string.Concat(Application.StartupPath, "\\Score.txt"));
            //nạp điểm
            countTrue = int.Parse(readScore.ReadLine());
            countFalse = int.Parse(readScore.ReadLine());
            readScore.Close();
           
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.D1))
            {
                if(cbHTB.Checked)
                {
                    cbHTB.Checked = false;
                }
                else
                    cbHTB.Checked = true;
            }
            if (e.KeyData == (Keys.Control | Keys.D2))
            {
                if (cbTA.Checked)
                {
                    cbTA.Checked = false;
                }
                else
                    cbTA.Checked = true;
            }
            if(e.KeyData==(Keys.Control|Keys.D3))
            {
                if (cbTV.Checked)
                    cbTV.Checked = false;
                else
                    cbTV.Checked = true;
            }
            if(e.KeyData==(Keys.Control|Keys.Right))
            {
                tb.aTimer.Interval = 100;
                
                tb.loopTB++;
           
            }
            if (e.KeyData == (Keys.Control | Keys.Left))
            {
                tb.aTimer.Interval = 100;
                if(tb.loopTB!=0)
                tb.loopTB--;
            }
            if (e.KeyData == (Keys.Control | Keys.Down))
            {
                tb.aTimer.Interval = 100;
                
            }

            if (e.KeyData == (Keys.Control | Keys.Oemtilde))
            {
              if ( cbXoaTbSpeech.Checked)
                     cbXoaTbSpeech.Checked = false;
                else
                    cbXoaTbSpeech.Checked = true;
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            English.Visible = false;
            comboBox1.SelectedIndex = 1;
        }
        /// <summary>
        /// Loại dấu trong tiếng việt
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public string RemoveUnicode(string inputText)
        {
            string stFormD = inputText.Normalize(System.Text.NormalizationForm.FormD);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string str = "";
            for (int i = 0; i <= stFormD.Length - 1; i++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[i]);
                if (uc == UnicodeCategory.NonSpacingMark == false)
                {
                    if (stFormD[i] == 'đ')
                        str = "d";
                    else if (stFormD[i] == 'Đ')
                        str = "D";
                    else if (stFormD[i] == '\r' | stFormD[i] == '\n')
                        str = "";
                    else
                        str = stFormD[i].ToString();
                    sb.Append(str);
                }
            }
            return sb.ToString();
        }      
        void initTextChanged()
        {
            try
            {
                if (comboBox1.Text == "Việt - Anh")
                {
                    //Việt Anh
                    int x = -1;
                    string A = RemoveUnicode(txtWord.Text);
                    if (A.Length != 0)
                    {
                        do
                        {
                            x = KhongDau.FindString(A, x);
                            if (x != -1)
                            {
                                listWord.TopIndex = x;
                                listWord.SetSelected(x, true);
                                return;
                            }
                        } while (x != -1);
                    }
                    else
                    {
                        listWord.SetSelected(0, true);
                    }
                }
                // Anh Việt
                else
                {
                    int x = -1;
                    string A = RemoveUnicode(txtWord.Text);
                    if (A.Length != 0)
                    {
                        do
                        {

                            x = English.FindString(A, x);
                            if (x != -1)
                            {
                                English.TopIndex = x;
                                English.SetSelected(x, true);
                                return;
                            }
                        } while (x != -1);
                    }
                    else
                    {
                        English.SetSelected(0, true);
                    }

                }
            }
            catch
            {

            }
        }
        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            //Anh Việt
            Thread TextChanged = new Thread(initTextChanged);
            TextChanged.Start();
        }
       /// <summary>
       /// Tìm kiếm từ offline
       /// </summary>
       /// <param name="wordInput"></param>
       /// <returns></returns>
        private string GetMeaning(string wordInput)
        {
            string meaning = "";
            try
            {
                int pos = 0;
                if(comboBox1.SelectedIndex==0)
                {
                    fs.BaseStream.Position = 0;
                    AllMeaningFile = fs.ReadToEnd();
                }
                else
                {
                fsData.BaseStream.Position = 0;
                AllMeaningFile = fsData.ReadToEnd();
                }
                // find position wordInput in string AllMeaningFile
                pos = AllMeaningFile.IndexOf("@" + wordInput);
                // get substring from pos to end string
                AllMeaningFile = AllMeaningFile.Substring(pos + 1, AllMeaningFile.Length - pos - 1);
                // find next @
                int posNextA = AllMeaningFile.IndexOf('@');
                meaning = AllMeaningFile.Substring(0, posNextA);
                // html style for meaning 
                meaning = meaning.Insert(wordInput.Length + 1, "</b></font>");
                meaning = "<font color=\"#FF0000\"><b>" + meaning;
                meaning = meaning.Replace("\n*", "</b></font><br/><b>*");
                if (comboBox1.SelectedIndex == 0)
                {
                    meaning = meaning.Replace("\n-", "<font color=\"blue\"><b></b><br/>&nbsp;-");
                }
                else

                meaning = meaning.Replace("\n-", "</b><br/>&nbsp;-");
                if (comboBox1.SelectedIndex == 0)
                {
                    //btnNghe.Visible = false;
                    AnhViet = meaning.Substring(meaning.IndexOf("</b><br/>&nbsp;-")+16,meaning.Substring(meaning.IndexOf("</b><br/>&nbsp;-")+16).IndexOf("\n"));
                    AnhViet = AnhViet.Replace("</b><br/>&nbsp;-", "");
                }
                meaning = meaning.Replace("\n", "</b></font><br/>");
            }
            catch
            {
                meaning = "No data or error";
            }
            return meaning;
        }
        /// <summary>
        /// Nạp ảnh vào khung nghĩa
        /// </summary>
        private void ImagePic()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() )
            {

                try
                {
                    PicVA.Image = null;
                    if (comboBox1.SelectedIndex == 0)
                    {

                        PicVA.Image = ImageGoogle(listWord.SelectedItem.ToString());
                    }
                    else

                        PicVA.Image = ImageGoogle(English.GetItemText(English.SelectedItem));

                }
                catch
                {

                }
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtWord.Text=="" || txtWord.Text.Substring(0,1)==" ")
                return;
            if (comboBox1.Text == "Việt - Anh")
            {               
                AnhViet = txtWord.Text;               
                string tempSelect = listWord.GetItemText(listWord.SelectedItem);
                if (cbloadImOF.Checked)
                {
                    PicVA.Image = null;
                    loadImage = new Thread(ImagePic);
                    loadImage.Start();
                }
                webBrowser1.DocumentText = GetMeaning(listWord.GetItemText(listWord.SelectedItem));
                txtWord.Text = listWord.Text;
            }
            else if (comboBox1.Text == "Anh - Việt")
            {               
                AnhViet = txtWord.Text;               
                string tempSelect = English.GetItemText(English.SelectedItem);
                if (cbloadImOF.Checked)
                {
                    PicVA.Image = null;
                    loadImage = new Thread(ImagePic);
                    loadImage.Start();
                }
                webBrowser1.DocumentText = GetMeaning(English.GetItemText(English.SelectedItem));
                txtWord.Text = English.Text;
            }
            txtWord.Focus();
            txtWord.SelectionStart = txtWord.Text.Length;
        }
        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox1.Text == "Việt - Anh")
                    txtWord.Text = listWord.GetItemText(listWord.SelectedItem);
                else
                    txtWord.Text = English.GetItemText(English.SelectedItem);
                this.AcceptButton = button1;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void listWord_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Việt - Anh")
                txtWord.Text = listWord.GetItemText(listWord.SelectedItem);
            else
                txtWord.Text = English.GetItemText(English.SelectedItem);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Anh - Việt")
            {
                
                webBrowser1.DocumentText = null;
               // btnNghe.Visible = true;
                English.Visible = true;

            }
            if (listWord.Items.Count != 0)
                if (comboBox1.Text == "Việt - Anh")
                {
                    webBrowser1.DocumentText = null;
                    English.Visible = false;
                   // btnNghe.Visible = false;
                }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            toastNotificationsManager2.ShowNotification(toastNotificationsManager2.Notifications[0]);
            if (AnhViet != null)
            {
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(AnhViet);
            }
        }
        //tab2
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                if (cbbSelectLang.Text == "Anh - Việt")
                {
                    TranslatorBing Bing = new TranslatorBing();
                    textOutput.Text = Bing.Translator(textInput.Text, "en", "vi");
                    //textOutput.Text = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", textInput.Text, "en", "vi");
                }
                else
                {
                    TranslatorBing Bing = new TranslatorBing();
                    textOutput.Text = Bing.Translator(textInput.Text, "vi", "en");

                }
            else
                textOutput.Text = "Mất kết nối";
        }
        WindowsMediaPlayer nghedoanvan = new WindowsMediaPlayer();
        /// <summary>
        /// Nghe online
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {

                    WindowsMediaPlayer nghedoanvan = new WindowsMediaPlayer();
                    if (cbbSelectLang.Text == "Anh - Việt")
                    {
                        nghedoanvan.URL = "http://api.microsofttranslator.com/V2/Http.svc/Speak?language=en&format=audio/mp3&options=MaxQuality&appid=6CE9C85A41571C050C379F60DA173D286384E0F2&text=" + textInput.Text;
                        nghedoanvan.controls.play();
                    }
                    else
                    {
                        nghedoanvan.URL = "http://api.microsofttranslator.com/V2/Http.svc/Speak?language=en&format=audio/mp3&options=MaxQuality&appid=6CE9C85A41571C050C379F60DA173D286384E0F2&text=" + textOutput.Text;
                        nghedoanvan.controls.play();
                    }
                }
            }
            catch
            {

            }
        }
       
        /// <summary>
        /// List chứa các từ chọn hiện thông báo
        /// </summary>
        static List<string> charSpeak;
        /// <summary>
        /// Hàm này để khởi tạo thông báo kiểm tra dấu check trong lịch sử tra từ nếu có check thì nạp và khởi tạo các thông báo
        /// .Nếu thông báo đã tồn tại thì xóa trước khi nạp mới vào
        /// .Khi có chọn hình ảnh thì đợi khi nào ảnh load về đủ thì mới hiện thông báo
        /// </summary>
        void timeinitTB()
        {
            int demCheck = 0;
            aTimer.Interval = 100;
            try// loi nap du lieu
            {
                daTa.Update(ref dataGridView1);
                dataGridView1.Sort(dataGridView1.Columns["STT"], ListSortDirection.Descending);
            }
            catch (Exception)
            {

            }
            try
            {
                for (int k = numberTB - 1; k >= 0; )
                {
                    try
                    {
                        toastNotificationsManager1.Notifications.Remove(toastNotificationsManager1.Notifications[k]);
                        k--;
                    }
                    catch (Exception)
                    {

                    }
                }
                numberTB = 0;
                loopTB = 0;
                aTimer.Enabled = false;
            }
            catch (Exception)
            {
                loopTB = 0;
                numberTB = 0;
                aTimer.Enabled = false;
            }
            slSpeak = 0;            
            charSpeak = new List<string>();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                try
                {
                    string kk = dataGridView1.Rows[dr.Index].Cells["Check"].Value.ToString();
                    if (kk=="1" || kk =="True") 
                    {
                        charSpeak.Add(dataGridView1.Rows[dr.Index].Cells["Vocabulary"].Value.ToString());
                        slSpeak++;
                    }
                }
                catch (Exception)
                {
                    
                }
                demCheck++;
            }
            charSpeak.Add("net net");
            slSpeak++;
            try
            {
                startListener(charSpeak);
            }
            catch 
            {

            }
            List<int> iRandom = UniqueRandomGenerator(0, demCheck-1);
            for (int iCheck = 0; iCheck < demCheck; iCheck++)
            {
                try
                {
                    string kk = dataGridView1.Rows[iRandom[iCheck]].Cells["Check"].Value.ToString();
                    if (kk=="1" || kk =="True")  //Cells[0] Because in cell 0th cell we have added checkbox
                    {

                        {
                            toastNotificationsManager1.Notifications.Add(
                            new DevExpress.XtraBars.ToastNotifications.ToastNotification(numberTB.ToString(), null, "hello", "hello", "hello", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text02));

                            //toastNotificationsManager1.BeginUpdate();

                            toastNotificationsManager1.Notifications[numberTB].Body = dataGridView1.Rows[iRandom[iCheck]].Cells["Mean"].Value.ToString();


                            if (cbImage.Checked)
                            {
                                PictureBox tempPic = new PictureBox();

                                GimageSearchClient client = new GimageSearchClient("www.c-sharpcorner.com");
                                IList<IImageResult> results = client.Search(dataGridView1.Rows[iRandom[iCheck]].Cells["Vocabulary"].Value.ToString(), 1, ImageSize.GetDefault(), Colorization.GetDefault(), ImageType.GetDefault(), ImageFileType.GetDefault());
                                foreach (IImageResult result in results)
                                {

                                    tempPic.Load(result.TbImage.Url);
                                    tempPic.Image = resizeImage(tempPic.Image, new Size(150, 150));

                                    try
                                    {
                                        toastNotificationsManager1.Notifications[numberTB].Image = tempPic.Image;
                                    }
                                    catch (Exception)
                                    {

                                    }

                                }
                            }
                            toastNotificationsManager1.Notifications[numberTB].Sound = DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.NoSound;
                            toastNotificationsManager1.Notifications[numberTB].Template = DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02;
                            if (dataGridView1.Rows[iRandom[iCheck]].Cells["PhienAm"].Value.ToString() != "♥" && dataGridView1.Rows[iRandom[iCheck]].Cells["PhienAm"].Value.ToString() != "")
                                toastNotificationsManager1.Notifications[numberTB].Header = dataGridView1.Rows[iRandom[iCheck]].Cells["Vocabulary"].Value.ToString() + "   |" + dataGridView1.Rows[iRandom[iCheck]].Cells["PhienAm"].Value.ToString() + "|";
                            else
                                toastNotificationsManager1.Notifications[numberTB].Header = dataGridView1.Rows[iRandom[iCheck]].Cells["Vocabulary"].Value.ToString();
                            numberTB++;
                        }
                    }
                }
                catch
                {

                }

            }
            try
            {
                if (numberTB != 0)
                    btnHoctu.Enabled = true;
                else
                    btnHoctu.Enabled = false;
            }
            catch
            {

            }
          
            aTimer.Enabled = true;
           
        }

        static Thread initTB;
        private void btnTBHis_Click(object sender, EventArgs e)
        {

            daTa.Update(ref dataGridView1);
            initTB = new Thread(new ThreadStart(timeinitTB));
            initTB.Start();
             Nofition noti = new Nofition(ref cbHTB);
            noti.Show();

        }
        /// <summary>
        /// Khởi tạo các biến cần thiết để dùng nhận dạng giọng nói
        /// </summary>
        /// <param name="inPut"></param>
        public void startListener(List<string> inPut)
        {
            try
            {
                string[] listerer = new string[inPut.Count];
                for (int t = 0; t < inPut.Count; t++)
                {
                    listerer[t] = inPut[t];
                }

                Choices commands = new Choices();
                commands.Add(listerer);
                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(commands);
                Grammar grammar = new Grammar(gBuilder);
                recEngineTB.LoadGrammarAsync(grammar);

                recEngineTB.SetInputToDefaultAudioDevice();
                recEngineTB.SpeechRecognized += recEngine_SpeechRecognized;

            }
            catch 
            {

            }
        }
        private void btnXoaHis_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa", "Chú Ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                daTa.Delete(ref dataGridView1);
                dataGridView1.Sort(dataGridView1.Columns["STT"], ListSortDirection.Descending);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void cbSelectALL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectALL.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].Cells["Check"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].Cells["Check"].Value = false;
                }
            }
        }
        SpeechSynthesizer readerEX= new SpeechSynthesizer();
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
           
            try
            {

                try
                {
                    if (cbNext.Checked)
                    {
                        if (e.Result.Text.ToLower() == toastNotificationsManager1.Notifications[loopTB].Header.ToLower() && cbTHUAM.Checked)
                        {
                            aTimer.Interval = 100;
                            loopTB++;
                        }
                    }
                }
                catch
                {

                }
                if (e.Result.Text.ToLower() == toastNotificationsManager1.Notifications[loopTB - 1].Header.ToLower() && cbTHUAM.Checked)
                {
                    if (!cbNext.Checked && !cbXoaTbSpeech.Checked)
                    {
                        
                        readerEX.SpeakAsync("Good");
                    }



                    if (cbXoaTbSpeech.Checked)
                    {
                        toastNotificationsManager1.Notifications.Remove(toastNotificationsManager1.Notifications[loopTB - 1]);
                        loopTB--;
                        numberTB--;
                        if (cbNext.Checked == false)
                        aTimer.Interval = 100;
                    }

                    if(frmStudy.Visible==true)
                    {
                        countTrue++;
                    }
                }

            }
            catch
            {
                return;
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {

            if (loopTB >= numberTB)
            {
                loopTB = 0;
            }
            try
            {

                
                iVocabulary = toastNotificationsManager1.Notifications[loopTB].Header.ToLower();
                iMean = toastNotificationsManager1.Notifications[loopTB].Body.ToLower();
                iImage = toastNotificationsManager1.Notifications[loopTB].Image;
                SpeechSynthesizer readerTB = new SpeechSynthesizer();
                try
                {
                    recEngineTB.RecognizeAsyncCancel();
                }
                catch
                {

                }
                try
                {
                    recEngineTB.RecognizeAsyncStop();
                }
                catch
                {

                }
                try
                {
                    if (cbHTB.Checked)
                    {
                        if(cbToast.Checked)
                        toastNotificationsManager2.ShowNotification(toastNotificationsManager1.Notifications[loopTB]);

                    }


                }
                catch (Exception)
                {

                }
                if (cbTA.Checked)
                {
                    SPEECH.StopSpeak();
                    SPEECH.GirlSpeak(toastNotificationsManager1.Notifications[loopTB].Header);
                    SPEECH.StopSpeak();
                    //readerTB.Speak(toastNotificationsManager1.Notifications[loopTB].Header);

                }
                //nghedoanvan.controls.play();
               
                if (cbTV.Checked)
                    try
                    {

                        //SpeechVN(toastNotificationsManager1.Notifications[loopTB].Body);
                    }
                    catch (Exception)
                    {

                    }
                try
                {


                    recEngineTB.RecognizeAsync(RecognizeMode.Multiple);


                }
                catch
                {

                }
                if (cbNext.Checked == false)
                    loopTB++;

            }
            catch
            {
                aTimer.Enabled = false;
            }


        }
        /// <summary>
        /// From Tra nhanh.
        /// </summary>
        FormSOHA frm;
        private void btnSOHA_Click(object sender, EventArgs e)
        {
            frm = new FormSOHA();
            btnSOHA.Enabled = false;
            frm.Show();
        }
        static string adHisMean;
        static string istempCut;
        private void tbHistory_TextChanged(object sender, EventArgs e)
        {
            if (tbHistory.Text == "" || tbHistory.Text == frm.DemotextMean.ToLower() || frm.DemotextMean == "Loading...." || frm.DemotextMean == "No data or error")
                return;
           // Lọc ra dòng cuối cùng để nạp vào lịch sử tra từ
            adHisMean = frm.DemotextMean;
            if (!FullPage && !FormSOHA.bcThongDung.Checked)
            {
                int isBING = frm.DemotextMean.IndexOf("\r\n");
                if (isBING != -1)
                {

                    istempCut = adHisMean;
                    adHisMean = (frm.DemotextMean.Substring(isBING + 2));

                    if (adHisMean == "")
                        adHisMean = istempCut;
                    else
                    {
                        try
                        {
                            istempCut = adHisMean;
                            if (adHisMean.IndexOf("\r\n") != -1)
                            {
                                adHisMean = adHisMean.Substring(adHisMean.IndexOf("\r\n") + 2);
                                if (adHisMean == "")
                                    adHisMean = istempCut;
                                if (adHisMean.IndexOf("\r\n") != -1)
                                    adHisMean = adHisMean.Substring(0, adHisMean.IndexOf("\r\n") + 2);
                            }
                            else
                                adHisMean = istempCut;


                        }
                        catch
                        {
                            adHisMean = istempCut;
                        }
                    }
                }
                daTa.Write(ref dataGridView1, tbHistory.Text, adHisMean);
                dataGridView1.Sort(dataGridView1.Columns["STT"], ListSortDirection.Descending);
                return;
            }
            if(FormSOHA.bcThongDung.Checked)
            {
                adHisMean = adHisMean.Replace("Danh từ\r\n", "[n] ");
                adHisMean = adHisMean.Replace("Trạng từ\r\n", "[adv] ");
                adHisMean = adHisMean.Replace("Tính từ\r\n", "[adj] ");
                adHisMean = adHisMean.Replace("Động từ\r\n", "[v] ");
                adHisMean = adHisMean.Replace("\r\n", " ");
                daTa.Write(ref dataGridView1, tbHistory.Text, adHisMean.Replace('\t', ' '));
                dataGridView1.Sort(dataGridView1.Columns["STT"], ListSortDirection.Descending);
                return;
            }
         
        }
        /// <summary>
        ///  Gửi request lên cloudtalk để nhận đoạn mp3 tiếng việt
        /// </summary>
        /// <param name="text"></param>
        void SpeechVN(string text)
        {
            try
            {
                text = text.Split('/')[0];
                text = text.Replace("(v)", "");
                text = text.Replace("(n)", "");
                text = text.Replace("(adv)", "");
                text = text.Replace("(adj)", "");
                String reqHost = "http://cloudtalk.vn/tts";
                WebRequest request = WebRequest.Create(reqHost);
                String reqUserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:32.0) Gecko/20100101 Firefox/32.0";
                // Setup Data
                string postData = "text=" + text + "&style=poem&ref=&sig=reserved&pid=reserved&uid=reserved&otp=reserved!";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Setup Header Request
                request.Credentials = CredentialCache.DefaultCredentials;
                ((HttpWebRequest)request).UserAgent = reqUserAgent;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                request.ContentLength = byteArray.Length;

                // Getting resource
                Stream dataStream = request.GetRequestStream();

                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();

                String mp3Link = "http://cloudtalk.vn/ttsoutput?id=" + responseFromServer;

                nghedoanvanVIET.URL = mp3Link;

                nghedoanvanVIET.controls.play();
            }
            catch
            {

            }
        }

        private void tbCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbCK_TextChanged(object sender, EventArgs e)
        {
            if (tbCK.Text == "0" || tbCK.Text == "")
                tbCK.Text = "1";
            try
            {
                aTimer.Interval = int.Parse(tbCK.Text) * 7500;
            }
            catch 
            {

            }
        }
        /// <summary>
        /// Nén kích thước anh lại để đúng tỉ lệ  với thanh thông báo học từ
        /// </summary>
        /// <param name="imgToResize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
     

       
        Image ImageGoogle(string namePic)
        {

            PictureBox tempPic = new PictureBox();

            GimageSearchClient client = new GimageSearchClient("www.c-sharpcorner.com");
            IList<IImageResult> results = client.Search(namePic.Split('|')[0].Trim(), 1, ImageSize.Medium, Colorization.GetDefault(), ImageType.GetDefault(), ImageFileType.GetDefault());
            foreach (IImageResult result in results)
            {
                tempPic.Load(result.Url);

            }

            return tempPic.Image;

        }

        public static void ThreadProc()
        {
            Application.Run(new Predictive(btnTD));
        }
       
       
        private void btnTD_Click(object sender, EventArgs e)
        {
            Predictive pre = new Predictive(btnTD);
            pre.Show();
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            //t.Start();
        }

        private void cbHTB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHTB.Checked)
            {
                cbImage.Enabled = true;
            }
            else
            {
                cbImage.Enabled = false;
                cbImage.Checked = false;
            }
        }
        studyVocabulary frmStudy;
        private void btnHoctu_Click(object sender, EventArgs e)
        {
            if (numberTB != 0)
            {
                 frmStudy = new studyVocabulary(btnHoctu);
                frmStudy.Show();
                cbNext.Checked = true;
            }
        }

        private void tb_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
        public List<int> UniqueRandomGenerator(int minVal, int maxVal)
        {
            Random rand = new Random();
            SortedList<int, int> uniqueList = new SortedList<int, int>();
            for (int i = minVal; i <= maxVal; i++)
                uniqueList.Add(rand.Next(), i);

            return uniqueList.Values.ToList();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbloadImOF.Checked)
            {
                
                PicVA.Visible = true;
            }
            else
            {
                
                PicVA.Visible = false;
            }
        }
        public static System.Data.DataTable table;
        public  void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                txStatus_Leave(null,null);
                try
                {
                    dataXepHang.DataSource = table;
                }
                catch 
                {

                }
                dataXepHang.Sort(dataXepHang.Columns["ITILE"], ListSortDirection.Descending);
            }
        }
        void initCapnhat()
        {
            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    StreamWriter wrStatus = new StreamWriter(string.Concat(Application.StartupPath, "\\status.dict"));
                    wrStatus.WriteLine(txStatus.Text);
                    wrStatus.Close();
                    StreamReader readScore = new StreamReader(string.Concat(Application.StartupPath, "\\Score.txt"));
                    int dung = int.Parse(readScore.ReadLine());
                    int sai = int.Parse(readScore.ReadLine());
                    readScore.Close();
                    GetDataMySQLOnline.inSertdatamysql(System.Net.Dns.GetHostName(), dung, sai, tb.txStatus.Text);
                   
                    tb.table = GetDataMySQLOnline.loadDL();
                    btnCapNhat.Enabled = true;
                    
                  
                    txStatus.Enabled = true;
                }
            }
            catch 
            {

            }
        }

        private void txStatus_Leave(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            txStatus.Enabled = false;
            Thread cnStatus = new Thread(initCapnhat);
            cnStatus.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
        }

        private void tbVoca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMean.Text != "" && tbVoca.Text != "")
                {
                    daTa.Write(ref dataGridView1, tbVoca.Text.Replace("\t", "").Replace("\r\n", "").Replace("\n", ""), tbVoca.Text.Replace("\t", "").Replace("\r\n", "").Replace("\n", ""));
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                    this.tbVoca.Text = "";
                    this.tbMean.Text = "";
                    this.tbVoca.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ 2 khung");
                    if (tbVoca.Text == "")
                        this.tbVoca.Focus();
                    else
                        this.tbMean.Focus();
                }
            }
        }

        private void tbMean_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMean.Text != "" && tbVoca.Text != "")
                {
                    daTa.Write(ref dataGridView1, tbVoca.Text.Replace("\t", "").Replace("\r\n", "").Replace("\n", ""), tbMean.Text.Replace("\t", "").Replace("\r\n", "").Replace("\n", ""));
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                    this.tbVoca.Text = "";
                    this.tbMean.Text = "";
                    this.tbVoca.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ 2 khung");
                    if (tbVoca.Text == "")
                        this.tbVoca.Focus();
                    else
                        this.tbMean.Focus();
                }
            }

        }

        private void tbCK_Leave(object sender, EventArgs e)
        {
            if (tbCK.Text == "")
                tbCK.Text = "5";
        }

        private void tbLaplai_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void tbLaplai_Leave(object sender, EventArgs e)
        {
            if (tbLaplai.Text == "")
                tbLaplai.Text = "1";
        }
    }
}

