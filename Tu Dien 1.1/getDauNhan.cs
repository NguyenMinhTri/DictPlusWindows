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
    class getDauNhan
    {
        public static string dauNhanOffline(string Voca)
        {
            try
            {
                tb.fsData.BaseStream.Position = 0;
                string AllofMean = tb.fsData.ReadToEnd();
                int index = AllofMean.IndexOf("@" + Voca.ToLower().Trim());
                if (index != -1)
                {
                    AllofMean = AllofMean.Substring(index);
                    AllofMean = AllofMean.Substring(0, AllofMean.IndexOf("\n"));
                    try
                    {
                        AllofMean = AllofMean.Split('/')[1];

                        return AllofMean;
                    }
                    catch
                    {
                        return "♥";
                    }

                }
                else

                    return "♥";
            }
            catch
            {
                return "♥";
            }
        }
        public static string getDau(string mean)
        {

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() && !tb.cbOffline.Checked)
            {
                string hold = "";
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.oxfordlearnersdictionaries.com/definition/english/" + mean);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    hold = read.ReadToEnd();
                    hold = hold.Substring(hold.LastIndexOf("/</span><span class=\"wrap\">/</span>"));
                    hold = hold.Substring(35);
                    if (hold.Substring(0, 1) == "<")
                    {
                        hold = hold.Substring(52);
                        hold = hold.Substring(0, hold.IndexOf("</span>ekt<"));
                    }
                    else
                        hold = hold.Substring(0, hold.IndexOf("<span class=\"wrap\">/</span><span"));
                    int temp = hold.IndexOf("<span");
                    int cc = hold.IndexOf("ald8book") + 7;
                    if (temp != -1)
                    {
                        hold = hold.Remove(temp, cc);
                        hold = hold.Replace("</span>", "");
                        hold = hold.Replace("/span>", "");
                    }
                    mean = hold;
                    return mean;
                }
                catch
                {
                    try
                    {
                        hold = hold.Substring(0, hold.LastIndexOf("<span class=\"wrap\">/</span>"));
                        int temp = hold.IndexOf("ok");
                        if (temp == -1)
                            temp = hold.IndexOf("k\"");
                        if (temp == 0)
                        {
                            hold = hold.Substring(4);
                            hold = hold.Replace("</span>", "");
                        }
                        else
                        {

                            hold = hold.Substring(hold.LastIndexOf(">"));

                            hold = hold.Substring(9);
                        }

                        mean = hold;
                        return mean;
                    }
                    catch
                    {
                        try
                        {
                            hold = hold.Substring(hold.LastIndexOf("psg=\"ald8book\">"));
                            hold = hold.Substring(0, hold.IndexOf("<span class"));
                            hold = hold.Replace("</span>", "");
                            return hold;
                        }
                        catch
                        {

                        }
                        return dauNhanOffline(mean);
                    }

                }
            }
            else
            {
                return dauNhanOffline(mean);
            }
        }
    }
}
