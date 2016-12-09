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
    class getDataSOHA
    {
        //StreamReader fsData = new StreamReader(@"G:\Download\Compressed\AnhViet\AnhViet\anhviet109K.dict");
        string AllMeaningFile;
       
        public getDataSOHA()
        {
            AllMeaningFile = tb.fsData.ReadToEnd();
        }
        public string meanAV(bool TT, bool of, string inPut)
        {
            try
            {
                if (of == true)
                {
                    return getMeanoffline(inPut);


                }
               
                
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://tratu.soha.vn/dict/en_vn/" + inPut);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    string hold = read.ReadToEnd();
                    if (tb.FullPage)
                    {
                        hold = hold.Substring(hold.IndexOf("<!-- start content -->"), hold.IndexOf("<!-- Saved") - hold.IndexOf("<!-- start content -->"));
                        return hold;
                    }
                    if(FormSOHA.bcThongDung.Checked)
                    {
                        return NghiaThongDung(inPut, hold);
                    }
                    if (TT)
                    {
                        int pos = hold.LastIndexOf("tin </span>");// Toán tin
                        if (pos != -1)
                        {
                            hold = hold.Substring(pos - 11, hold.LastIndexOf("<!-- end content -->") - pos + 11);
                            try//trường hợp nằm cuối trag bị lỗi
                            {
                                hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("</span></h5>") - hold.IndexOf("<a"));
                            }
                            catch (Exception)
                            {
                                hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("Lấy từ « <a") - hold.IndexOf("<a"));
                            }
                            // hold = "-" + hold;
                            return hold;
                        }
                        else
                        {
                            pos = hold.LastIndexOf("Điện tử &amp; viễn thông</span>");// Điện Tử & Viện Thông
                            if (pos != -1)
                            {
                                hold = hold.Substring(pos, hold.LastIndexOf("<!-- end content -->") - pos);
                                try
                                {
                                    hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("</span></h5>") - hold.IndexOf("<a"));
                                }
                                catch (Exception)
                                {
                                    hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("Lấy từ « <a") - hold.IndexOf("<a"));
                                }

                                return hold;
                            }
                            else
                            {
                                pos = hold.LastIndexOf("Kỹ thuật chung </span>");// Kỹ thuật chung
                                if (pos != -1)
                                {
                                    hold = hold.Substring(pos, hold.LastIndexOf("<!-- end content -->") - pos);
                                    try
                                    {
                                        hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("</span></h5>") - hold.IndexOf("<a"));
                                    }
                                    catch (Exception)
                                    {
                                        hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("Lấy từ « <a") - hold.IndexOf("<a"));
                                    }

                                    return hold;
                                }
                                else
                                {
                                    pos = hold.LastIndexOf("Thông dụng</span>");
                                    if (pos != -1)
                                    {
                                        hold = hold.Substring(pos, hold.LastIndexOf("<!-- end content -->") - pos);
                                        try
                                        {
                                            hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("</span></h5>") - hold.IndexOf("<a"));
                                        }
                                        catch (Exception)
                                        {
                                            hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("Lấy từ « <a") - hold.IndexOf("<a"));
                                        }

                                        return hold;

                                    }
                                    else
                                    {
                                        return getMeanoffline(inPut);
                                    }
                                }
                            }
                        }
                    }
                    else// kinh tế
                    {

                        int pos = hold.LastIndexOf("Kinh tế </span>");
                        if (pos != -1)
                        {
                            hold = hold.Substring(pos, hold.LastIndexOf("<!-- end content -->") - pos);
                            try//trường hợp nằm cuối trag bị lỗi
                            {
                                hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("</span></h5>") - hold.IndexOf("<a"));
                            }
                            catch (Exception)
                            {
                                hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("Lấy từ « <a") - hold.IndexOf("<a"));
                            }

                            return hold;
                        }
                        else
                        {
                            pos = hold.LastIndexOf("Thông dụng</span>");
                            if (pos != -1)
                            {

                                hold = hold.Substring(pos, hold.LastIndexOf("<!-- end content -->") - pos);
                                try
                                {
                                    hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("</span></h5>") - hold.IndexOf("<a"));
                                }
                                catch (Exception)
                                {
                                    hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("Lấy từ « <a") - hold.IndexOf("<a"));
                                }

                                return hold;
                            }
                            else
                            {
                                return getMeanoffline(inPut);
                            }
                        }
                    }
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
        string NghiaThongDung(string inPut,string hold)
        {
            int pos = hold.LastIndexOf("Thông dụng</span>");
            if (pos != -1)
            {

                hold = hold.Substring(pos, hold.LastIndexOf("<!-- end content -->") - pos);
                try
                {
                    hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("</span></h5>") - hold.IndexOf("<a"));
                }
                catch (Exception)
                {
                    hold = hold.Substring(hold.IndexOf("<a"), hold.IndexOf("Lấy từ « <a") - hold.IndexOf("<a"));
                }

                return hold;
            }
            else
            {
                return getMeanoffline(inPut);
            }
        }
    }
}
