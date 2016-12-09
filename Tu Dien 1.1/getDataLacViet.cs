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
    class  getDataLacViet
    {

        string AllMeaningFile;
        string hold;
        public getDataLacViet()
        {

            AllMeaningFile = tb.fsData.ReadToEnd();
        }

        public string meanAV(bool TT, bool of, string inPut, string holdd)
        {
            hold = holdd;
            if (of == true)
            {
                return getMeanoffline(inPut);


            }
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {





                if (TT)
                {
                    int pos = hold.LastIndexOf("Tin học<");// Toán tin
                    if (pos != -1)
                    {
                        hold = hold.Substring(pos);
                        try
                        {// cat tu toan tin
                            hold = hold.Substring(0, hold.IndexOf("</span><br/></li>"));// lay duoc doan nghia
                            return hold;
                        }
                        catch (Exception)
                        {
                            hold = hold.Substring(0, hold.IndexOf("</span><a"));// lay duoc doan nghia
                            return hold;
                        }
                    }
                    else
                    {
                        pos = hold.LastIndexOf("Toán học<");// Toán tin
                        if (pos != -1)
                        {
                            hold = hold.Substring(pos);// cat tu toan tin
                            try
                            {// cat tu toan tin
                                hold = hold.Substring(0, hold.IndexOf("</span><br/></li>"));// lay duoc doan nghia
                                return hold;
                            }
                            catch (Exception)
                            {
                                hold = hold.Substring(0, hold.IndexOf("</span><a"));// lay duoc doan nghia
                                return hold;
                            }
                        }
                        else
                        {

                            pos = hold.LastIndexOf("Vật lý<");
                            if (pos != -1)
                            {
                                hold = hold.Substring(pos);// cat tu toan tin
                                try
                                {// cat tu toan tin
                                    hold = hold.Substring(0, hold.IndexOf("</span><br/></li>"));// lay duoc doan nghia
                                    return hold;
                                }
                                catch (Exception)
                                {
                                    hold = hold.Substring(0, hold.IndexOf("</span><a"));// lay duoc doan nghia
                                    return hold;
                                }
                            }
                            else
                            {
                                pos = hold.LastIndexOf("Kỹ thuật<");
                                if (pos != -1)
                                {
                                    hold = hold.Substring(pos);// cat tu toan tin
                                    try
                                    {// cat tu toan tin
                                        hold = hold.Substring(0, hold.IndexOf("</span><br/></li>"));// lay duoc doan nghia
                                        return hold;
                                    }
                                    catch (Exception)
                                    {
                                        hold = hold.Substring(0, hold.IndexOf("</span><a"));// lay duoc doan nghia
                                        return hold;
                                    }
                                }
                                else
                                {

                                    string a = "<span class='fb'";
                                    pos = hold.IndexOf(a);
                                    if (pos != -1)
                                    {
                                        hold = hold.Substring(pos);// cat tu toan tin
                                        try
                                        {// cat tu toan tin
                                            hold = hold.Substring(0, hold.IndexOf("</span><br/></li>"));// lay duoc doan nghia
                                            return hold;
                                        }
                                        catch (Exception)
                                        {
                                            hold = hold.Substring(0, hold.IndexOf("</span><a"));// lay duoc doan nghia
                                            return hold;
                                        }
                                    }
                                    else
                                    {
                                        return getMeanoffline(inPut);
                                    }

                                }
                            }
                        }
                    }
                }
                else// kinh tế
                {

                    int pos = hold.LastIndexOf("Kinh tế<");
                    if (pos != -1)
                    {
                        hold = hold.Substring(pos);// cat tu toan tin
                        try
                        {// cat tu toan tin
                            hold = hold.Substring(0, hold.IndexOf("</span><br/></li>"));// lay duoc doan nghia
                            return hold;
                        }
                        catch (Exception)
                        {
                            hold = hold.Substring(0, hold.IndexOf("</span><a"));// lay duoc doan nghia
                            return hold;
                        }
                    }
                    else
                    {
                        string a = "<span class='fb'";
                        pos = hold.IndexOf(a);
                        if (pos != -1)
                        {
                            hold = hold.Substring(pos);// cat tu toan tin
                            try
                            {// cat tu toan tin
                                hold = hold.Substring(0, hold.IndexOf("</span><br/></li>"));// lay duoc doan nghia
                                return hold;
                            }
                            catch (Exception)
                            {
                                hold = hold.Substring(0, hold.IndexOf("</span><a"));// lay duoc doan nghia
                                return hold;
                            }
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


