using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
namespace Tu_Dien_1._1
{
    class getDataOxford
    {
        string AllMeaningFile;
       
        public getDataOxford()
        {
            AllMeaningFile = tb.fsData.ReadToEnd();
        }
        public string meanAV(string inPut)
        {
            try
            {
                
               
                
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                     HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.oxfordlearnersdictionaries.com/definition/english/" + inPut);
                     HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    string hold = read.ReadToEnd();
                    hold = hold.Remove(hold.IndexOf("mainsearch responsive_row"), hold.IndexOf("responsive_hide_on_hd responsive_center_on_smartphone") - hold.IndexOf("mainsearch responsive_row"));

                    hold = hold.Remove(hold.IndexOf("entry-header"), hold.IndexOf("ox-wrapper") - hold.IndexOf("entry-header"));

                    // hold = hold.Remove(hold.IndexOf("responsive_display_on_smartphone"), hold.IndexOf("mainsearch responsive_row") - hold.IndexOf("responsive_display_on_smartphone"));
                    //hold = hold.Remove(hold.IndexOf("responsive_hide_on_hd responsive_center_on_smartphone"), hold.IndexOf("responsive_row") - hold.IndexOf("responsive_hide_on_hd responsive_center_on_smartphone"));
                    string aa = "<div id=" + '"' + "cookieLaw" + '"';
                    string cc = "<div class=" + '"' + "responsive_row" + '"' + ">";
                    //   int a = hold.IndexOf("transparent");

                    int a = hold.IndexOf(aa);
                    hold = hold.Remove(hold.IndexOf(aa), 303);
                    int t = hold.IndexOf("responsive_display_on_smartphone") - 12;
                    int h = hold.IndexOf(cc);
                    hold = hold.Remove(t, h - t);
                    string kk = "<li><a href=" + '"' + "http://global.oup.com/cookiepolicy" + '"' + ">Cookie Policy</a></li>";
                    hold = hold.Replace(kk, "");
                    t = hold.IndexOf("responsive_entry_left") - 12;
                    h = hold.IndexOf("responsive_entry_center") - 12;
                    hold = hold.Remove(t, h - t);
                    return hold;
                        
                    
                }
                else
                {
                    return getMeanoffline(inPut);
                }
            }
            catch
            {
                return "No data or error";
            }

        }
        string getMeanoffline(string inPut)
        {
            string meaning = "";
            try
            {
                tb.fsData.BaseStream.Position = 0;
                AllMeaningFile = tb.fsData.ReadToEnd();
                int posIndex = 0;
                // find position wordInput in string AllMeaningFile
                posIndex = AllMeaningFile.IndexOf("@" + inPut + " ");
                if (posIndex == -1)
                    posIndex = AllMeaningFile.IndexOf("@" + inPut + "\n");
                AllMeaningFile = AllMeaningFile.Substring(posIndex + 1, AllMeaningFile.Length - posIndex - 1);

                int posNextA = AllMeaningFile.IndexOf('@');
                meaning = AllMeaningFile.Substring(0, posNextA);

                meaning = meaning.Insert(inPut.Length + 1, "</b></font>");
                meaning = "<font color=\"#FF0000\"><b>" + meaning;
                meaning = meaning.Replace("\n*", "<br/><b>*");
                meaning = meaning.Replace("\n-", "</b><br/>&nbsp;-");
                meaning = meaning.Replace("\n", "<br/>");
            }
            catch (Exception)
            {
                meaning = "No data or error";
            }
            return meaning;
        }
    }
}


