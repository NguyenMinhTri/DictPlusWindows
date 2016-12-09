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
namespace Tu_Dien_1._1
{
    class SpeechEnglish
    {
 WindowsMediaPlayer SpeakOxFord;
        SpeechSynthesizer readerEX;
        public SpeechEnglish()
        {
             SpeakOxFord = new WindowsMediaPlayer();
              readerEX = new SpeechSynthesizer();
              double hello = SpeakOxFord.controls.currentPosition;
        }
        public void StopSpeak()
        {
            try
            {
                readerEX.SpeakAsyncCancelAll();

                
            }
            catch
            {
                try
                {
                 //   SpeakOxFord.controls.stop();
            
                }
                catch
                {

                }
            }
        }
        public void GirlSpeak(string inPut)
        {
            inPut = inPut.Trim();
            inPut = inPut.ToLower();
          
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
                        try
                        {
                            if (inPut != "")
                                readerEX.Speak(inPut);
                        }
                        catch
                        {

                        }
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
    }
}