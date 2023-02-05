using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChSDocProcessing
{
    public partial class ARMwork : Form
    {
        int hour;
        int min;
        int sec;
        int hourleft;
        int minleft;
        int secleft;
        int over;
        string FilesPath = "";
        string fileis = "";
        string fileopens = "";
        int sends = 0;

        List<string> files = new List<string>() { };
        public ARMwork(string filee)
        {
            InitializeComponent();
            fileis = filee;
        }

        private void ARMwork_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("SODfile.txt");
            string left = reader.ReadLine();
            lab_chsstart.Text = "Начало происшествия: "+left;
            left = reader.ReadLine();
            reader.Close();
            minleft = (Int32.Parse(left));
            hourleft = minleft / 60;
            minleft = minleft % 60;
            StreamReader read = new StreamReader("config.txt");
            FilesPath = read.ReadLine();
            FilesPath = read.ReadLine();
            read.Close();

            label9.Text = "Начало отработки: " + DateTime.Now.ToString("dd.MM, HH:mm");

            string[] ArmNames;
            ArmNames = fileis.Split("|||");
            DirectoryInfo incid = new DirectoryInfo(FilesPath);
            foreach (string fname in ArmNames)
            {
                foreach (var ar in incid.GetFiles())
                {

                    if (ar.Name == fname)
                    {
                        //Process.Start(new ProcessStartInfo(FilesPath + "/" + fname) { UseShellExecute = true });
                        fileopens = fileopens + "}}" + fname;
                        File.Copy(FilesPath + "/"+ fname, "..\\TempFiles" + "/" + fname, true);
                        lst_filestatus.Items.Add("|X|" + fname);
                    }
                }

            }
            Mainstart._tcpmodule.SendText(fileopens);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if (over == 1)
            {
                label10.Text = "Время опоздания:";
                secleft += 1;

                if (secleft == 60)
                {
                    secleft = 0;
                    minleft += 1;
                }
                if (minleft == 60)
                {
                    minleft = 0;
                    hourleft += 1;
                }
            }
            else
            {
                secleft -= 1;

                if (secleft < 0)
                {
                    secleft = 59;
                    minleft -= 1;
                }
                if (minleft < 0)
                {
                    minleft = 59;
                    hourleft -= 1;
                }
            }
            if (sec == 60)
            {
                sec = 0;
                min += 1;
            }
            if (min == 60)
            {
                min = 0;
                hour += 1;
            }
            if (secleft < 1 && minleft < 1 && hourleft < 1)
            {
                over = 1;
            }

            lab_hour2.Text = Convert.ToString(hourleft);
            lab_min2.Text = Convert.ToString(minleft);
            lab_sec2.Text = Convert.ToString(secleft);
            lab_hour.Text = Convert.ToString(hour);
            lab_min.Text = Convert.ToString(min);
            lab_sec.Text = Convert.ToString(sec);
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files.Clear();
                //LB_ARM.Items.Clear();
                foreach (string fileName in dlg.FileNames)
                {
                    files.Add(fileName);
                }
                //txt_doc.Text = dlg.FileName;
            }
            foreach (string i in files)
            {
                //LB_ARM.Items.Add(i);
            }
        }

        private void txt_doc_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendfiles(string fal, int trys)
        {
            try
            {
                Mainstart._tcpmodule.SendFileName = fal;
                Thread t = new Thread(Mainstart._tcpmodule.SendData);
                t.Start();
            }
            catch
            {
                if (trys > 15)
                {
                    MessageBox.Show("Файл " + fal + "- Не удалось отправить");
                    Mainstart._tcpmodule.uploaded = 2;
                    return;
                }
                trys += 1;
                Thread.Sleep(125);
                sendfiles(fal, trys);
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (string file in files)
            {
                Mainstart._tcpmodule.uploaded = 0;
                Mainstart._tcpmodule.SendFileName = file;
                Thread t = new Thread(Mainstart._tcpmodule.SendData);
                t.Start();
                while (Mainstart._tcpmodule.uploaded < 2)
                {
                    /*if (Mainstart._tcpmodule.uploaded == 0)
                    {
                        Mainstart._tcpmodule.uploaded = 1;
                        sendfiles(file, 0);
                    }*/
                    Thread.Sleep(75);
                }
                Mainstart._tcpmodule.uploaded = 0;
                Thread.Sleep(25);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ss = Mainstart._tcpmodule.uploaded;
            //cmd.addsome(ss);
        }

        private void but_opentemplate_Click(object sender, EventArgs e)
        {
            if (lst_filestatus.SelectedItems.Count < 1) { return; }
            string file = lst_filestatus.SelectedItem.ToString();
            file = file.Remove(0, 3);
            Process.Start(new ProcessStartInfo(FilesPath + "/" + file) { UseShellExecute = true });
        }

        private void but_sendnudes_Click(object sender, EventArgs e)
        {
            int lstC = lst_filestatus.Items.Count;
            if (lst_filestatus.SelectedItems.Count < 1) { return; }
            string Fille = lst_filestatus.SelectedItem.ToString();
            string file = Fille.Remove(0, 3);
            if(Mainstart._tcpmodule.uploaded == 1)
            {
                MessageBox.Show("Предыдущий Файл еще не отправился");
                return;
            }
            Mainstart._tcpmodule.SendFileName = FilesPath + "/" + file;
            Thread t = new Thread(Mainstart._tcpmodule.SendData);
            t.Start();
            while (Mainstart._tcpmodule.uploaded < 2)
            {
                Thread.Sleep(75);
            }
            Mainstart._tcpmodule.uploaded = 0;
            Thread.Sleep(25);
            lst_filestatus.Items.Remove(Fille);
            lst_filestatus.Items.Add("|✓|" + file);
            sends += 1;
            if (lstC <= sends)
            {
                this.Close();
            }
        }

        private void ARMwork_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
