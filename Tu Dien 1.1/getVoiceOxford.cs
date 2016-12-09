using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Net;
using System.Timers;
namespace Tu_Dien_1._1
{
    class getVoiceOxford
    {
        System.Timers.Timer tmr = new System.Timers.Timer();
        string[] tempInput;
        WindowsMediaPlayer SpeakOxFord;
        WindowsMediaPlayer SpeakOxFord2;
        SpeechSynthesizer readerEX;
        int DemTU=1;
        int SoTu = 0;
        public getVoiceOxford()
        {
            SpeakOxFord = new WindowsMediaPlayer();
            SpeakOxFord2 = new WindowsMediaPlayer();
            SpeakOxFord.PlayStateChange += new  _WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
            SpeakOxFord2.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange2);
            readerEX = new SpeechSynthesizer();
            tmr.Elapsed += new ElapsedEventHandler(tmr_Tick);
            tmr.Interval = 10;
            readerEX.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
        }
        private void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            if (SoTu != 1 && DemTU <= SoTu &&  !tb.cbOffline.Checked)
            {

                tmr.Start();
            }
            if (DemTU == SoTu && DemTU != 1 || (DemTU == SoTu && SoTu == 1 ))
            {
               
                    if (!tb.cbAutoTime.Checked)
                        return;
                    if (SoTu != 1)
                    {
                        if (!tb.cbTV.Checked)
                        tb.aTimer.Interval = 500;
                        else

                            SpeechVN(tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Body);
                    }
                    else
                    {
                        if (!tb.cbTV.Checked)
                            tb.aTimer.Interval = 5000;
                        else
                            if(SoTu!=1)
                            SpeechVN(tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Body);
                    }
                
               
                
            }
            if(tb.cbOffline.Checked ||!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                
                    if (!tb.cbAutoTime.Checked)
                        return;
                    if (!tb.cbTV.Checked)
                    tb.aTimer.Interval = 5000;
                
                else
                        if (SoTu != 1)
                    SpeechVN(tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Body);
            }
        }
        void tmr_Tick(object sender, ElapsedEventArgs e)
        {
            try
            {
                tmr.Stop();
            }
            catch
            { 

            }
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() )
                try
                {

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.oxfordlearnersdictionaries.com/definition/english/" + tempInput[DemTU].Trim().ToLower());
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    string hold = read.ReadToEnd();
                    hold = hold.Substring(hold.IndexOf(".mp3") + 5);

                    hold = hold.Substring(hold.IndexOf("mp3=") + 5, hold.IndexOf(".mp3") + 4 - (hold.IndexOf("mp3=") + 5));
                    SpeakOxFord.URL = hold;

                    // SpeakOxFord.controls.stop();
                    SpeakOxFord.controls.play();


                }
                catch
                {
                    try
                    {
                        if (tempInput[DemTU] != "")
                        {
                            readerEX.SpeakAsyncCancelAll();
                            readerEX.SpeakAsync(tempInput[DemTU]);
                          
                        }
                    }
                    catch
                    {

                    }
                }
            else
                try
                {
                    if (tempInput[DemTU] != "")
                    {
                        readerEX.SpeakAsyncCancelAll();
                        readerEX.Speak(tempInput[DemTU]);
                    }
                }
                catch
                {

                }
            DemTU++;


        }
        void wplayer_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded && SoTu!=1 && DemTU<=SoTu )
            {

                tmr.Start();
                
            }
            if ((DemTU == SoTu && DemTU != 1 && NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded) || (DemTU == SoTu && SoTu == 1 && NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded))
            {
                if (!tb.cbAutoTime.Checked)
                    return;
                if (SoTu != 1)
                {
                    if (!tb.cbTV.Checked)
                        tb.aTimer.Interval = 500;
                    else

                        SpeechVN(tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Body);
                }
                else
                {
                    if (!tb.cbTV.Checked)
                        tb.aTimer.Interval = 5000;
                    else
                        if (SoTu != 1)
                        SpeechVN(tb.toastNotificationsManager1.Notifications[tb.loopTB - 1].Body);
                }
            }
          
           
            
        }

        public void StopSpeak()
        {
           
        }
        public void GirlSpeak(string inPut)
        {
            SoTu = 1;
            DemTU = 1;
            inPut = inPut.Split('|')[0];
            inPut = inPut.ToLower().TrimEnd();
            SoTu=inPut.Split(',').Length;
              tempInput=new string[SoTu];
            try
            {
                tempInput = inPut.Split(',');
            }
            catch
            {
                tempInput[1] = inPut;
            }
           // for (int i = 0; i < SoTu; i++)
            {

               
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() && !tb.cbOffline.Checked)
                {
                    
                    inPut = tempInput[0].Trim();
                    try
                    {

                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.oxfordlearnersdictionaries.com/definition/english/" + inPut);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                        string hold = read.ReadToEnd();
                        hold = hold.Substring(hold.IndexOf(".mp3") + 5);

                        hold = hold.Substring(hold.IndexOf("mp3=") + 5, hold.IndexOf(".mp3") + 4 - (hold.IndexOf("mp3=") + 5));
                        SpeakOxFord.URL = hold;
                        double hello = SpeakOxFord.controls.currentPosition;
                        // SpeakOxFord.controls.stop();
                        SpeakOxFord.controls.play();


                    }
                    catch
                    {
                        try
                        {
                            if (inPut != "")
                            {
                                readerEX.SpeakAsyncCancelAll();
                                readerEX.SpeakAsync(inPut);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                else

                    try
                    {
                        if (inPut != "")
                        {
                            readerEX.SpeakAsyncCancelAll();
                            readerEX.SpeakAsync(inPut);
                          
                        }
                    }
                    catch
                    {

                    }


                if (SoTu == 1 && tb.cbTV.Checked)
                    SpeechVN(tb.toastNotificationsManager1.Notifications[tb.loopTB].Body);
            
        }

        }
        public void BoySpeak(string inPut)
        {
            inPut = inPut.Trim();
            inPut = inPut.ToLower();

            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.oxfordlearnersdictionaries.com/definition/english/" + inPut);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string hold = read.ReadToEnd();
                hold = hold.Substring(hold.IndexOf("mp3=") + 5, hold.IndexOf(".mp3") + 4 - (hold.IndexOf("mp3=") + 5));
                SpeakOxFord.URL = hold;
                SpeakOxFord.controls.play();
            }
            catch
            {
                try
                {
                    SpeakOxFord.URL = "http://translate.google.com/translate_tts?tl=en&q=" + inPut;
                    SpeakOxFord.controls.play();
                }
                catch
                {
                    try
                    {
                        if (inPut != "")
                            readerEX.Speak(inPut);
                    }
                    catch
                    {

                    }
                }
            }

        }
        void SpeechVN(string text)
        {
            try
            {
                text = text.Split('/')[0];
                text = text.Replace("(v)", "");
                text = text.Replace("(n)", "");
                text = text.Replace("(adv)", "");
                text = text.Replace("(adj)", "");
                text = text.Replace("[v]", "");
                text = text.Replace("[n]", "");
                text = text.Replace("[adv]", "");
                text = text.Replace("[adj]", "");
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

                SpeakOxFord2.URL = mp3Link;

                SpeakOxFord2.controls.play();
            }
            catch
            {
                tb.aTimer.Interval = 5000;
            }
        }
        void wplayer_PlayStateChange2(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (SoTu != 1)
                    tb.aTimer.Interval = 500;
                else
                    tb.aTimer.Interval = 5000;
                
                   
            }
        }

    }
}

