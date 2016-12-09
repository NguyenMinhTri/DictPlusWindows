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
    class DuLieuLichSu
    {
        Thread waitPA;
        string Vocabulary = "";
        static int i = 0;

        public DuLieuLichSu(ref DataGridView dataGridView1)
        {

            StreamReader history = new StreamReader(string.Concat(Application.StartupPath, "\\history.txt"));
            try
            {
                while (true)
                {

                    string[] cut = history.ReadLine().Split('\t');
                    try
                    {
                        DataGridViewRowCollection rows = dataGridView1.Rows;
                        object[] lower = new object[] { int.Parse(cut[0]), int.Parse(cut[1]), cut[2], cut[3], cut[4] };
                        rows.Add(lower);
                        i = int.Parse(cut[0]);
                    }
                    catch
                    {

                    }

                }
            }
            catch
            {
                history.Close();
            }


        }
        public DuLieuLichSu()
        {
            try
            {
                i = int.Parse(tb.dataGridView1.Rows[0].Cells["STT"].Value.ToString());
            }
            catch
            {
                i = 0;
            }
        }
        string PhienAm = "";
        void waitPhienAm()
        {
            for (int i = 0; i < tb.dataGridView1.Rows.Count; )
            {
                string Voca = tb.dataGridView1.Rows[i].Cells["Vocabulary"].Value.ToString().ToLower().Trim();
                string PhA = tb.dataGridView1.Rows[i].Cells["PhienAm"].Value.ToString();
                if (Voca.ToLower().Trim() != "" && PhA == "")
                {
                    tb.dataGridView1.Rows[i].Cells["PhienAm"].Value = getDauNhan.getDau(Voca);
                    Update(ref tb.dataGridView1);
                }
                i++;
            }
        }
        public void Update(ref DataGridView dataGridView1)
        {
            StreamWriter wHistory = new StreamWriter(string.Concat(Application.StartupPath, "\\history.txt"));

            for (int dt = 0; dt < dataGridView1.Rows.Count; )
            {
                try
                {
                    //if (dataGridView1.Rows[dt].Cells["Vocabulary"].Value.ToString() != textBox1.Text)
                    {
                        int temp = 0;
                        string kk = dataGridView1.Rows[dt].Cells["Check"].Value.ToString();
                        try
                        {
                            if (kk == "1" || kk == "True")
                                temp = 1;
                        }
                        catch
                        {

                        }
                        wHistory.WriteLine(dataGridView1.Rows[dt].Cells["STT"].Value.ToString() + "\t" + temp.ToString() + "\t" + dataGridView1.Rows[dt].Cells["Vocabulary"].Value.ToString() + "\t" + dataGridView1.Rows[dt].Cells["PhienAm"].Value.ToString() + "\t" + dataGridView1.Rows[dt].Cells["Mean"].Value.ToString());
                    }

                }
                catch
                {

                }
                dt++;
            }

            wHistory.Close();
        }
        public void Write(ref DataGridView dataGridView1, string Voca, string Mean)
        {

            StreamWriter wHistory = new StreamWriter(string.Concat(Application.StartupPath, "\\history.txt"));
            try
            {
                i = int.Parse(tb.dataGridView1.Rows[0].Cells["STT"].Value.ToString());
            }
            catch
            {
                i = 0;
            }

            for (int dt = 0; dt < dataGridView1.Rows.Count; )
            {
                try
                {
                    if (dataGridView1.Rows[dt].Cells["Vocabulary"].Value.ToString() != Voca)
                    {
                        int temp = 0;
                        try
                        {
                            if ((bool)dataGridView1.Rows[dt].Cells["Check"].Value == true)
                                temp = 1;
                        }
                        catch
                        {

                        }
                        wHistory.WriteLine(dataGridView1.Rows[dt].Cells["STT"].Value.ToString() + "\t" + temp.ToString() + "\t" + dataGridView1.Rows[dt].Cells["Vocabulary"].Value.ToString() + "\t" + dataGridView1.Rows[dt].Cells["PhienAm"].Value.ToString() + "\t" + dataGridView1.Rows[dt].Cells["Mean"].Value.ToString());
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(dt);
                        dt--;
                    }
                }
                catch
                {

                }
                dt++;
            }
            i++;
            wHistory.WriteLine(i.ToString() + "\t0\t" + Voca + "\t" + PhienAm + "\t" + Mean);
            DataGridViewRowCollection rows = dataGridView1.Rows;
            object[] lower = new object[] { i, 0, Voca, PhienAm, Mean };
            rows.Add(lower);
            wHistory.Close();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            waitPA = new Thread(waitPhienAm);
            waitPA.Start();
        }
        public void Delete(ref DataGridView dataGridView1)
        {
            for (int dr = 0; dr < dataGridView1.Rows.Count; )
            {
                try
                {
                    string kk = dataGridView1.Rows[dr].Cells["Check"].Value.ToString();
                    //bool a=(bool)dataGridView1.Rows[dr].Cells["Check"].Value;
                    if (kk == "1" || kk == "True")//Cells[0] Because in cell 0th cell we have added checkbox
                    {
                        int d = dataGridView1.Rows.Count;
                        dataGridView1.Rows.RemoveAt(dr);
                        int c = dataGridView1.Rows.Count;
                        dr--;
                    }
                }
                catch
                {

                }
                dr++;

            }
            StreamWriter wHistory = new StreamWriter(string.Concat(Application.StartupPath, "\\history.txt"));
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                try
                {

                    wHistory.WriteLine(dataGridView1.Rows[dr.Index].Cells["STT"].Value.ToString() + "\t" + ((int)dataGridView1.Rows[dr.Index].Cells["Check"].Value).ToString() + "\t" + dataGridView1.Rows[dr.Index].Cells["Vocabulary"].Value.ToString() + "\t" + dataGridView1.Rows[dr.Index].Cells["PhienAm"].Value.ToString() + "\t" + dataGridView1.Rows[dr.Index].Cells["Mean"].Value.ToString());
                }
                catch
                {

                }
            }
            wHistory.Close();
        }
        public void UpdatePhienAm()
        {
            waitPA = new Thread(waitPhienAm);
            waitPA.Start();


        }
    }
}