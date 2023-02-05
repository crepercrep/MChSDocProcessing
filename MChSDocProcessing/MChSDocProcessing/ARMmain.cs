using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChSDocProcessing
{
    public partial class ARMmain : Form
    {
        //string docfile;
        string files;
        public int exit = 0;
        //cmd cmd = new cmd(Mainstart._tcpmodule.valu);
        public ARMmain()
        {
            InitializeComponent();

            Mainstart._tcpmodule.Receive += new TcpModule.ReceiveEventHandler(_tcp_Receive);

        }

        private void _tcp_Receive(object sender, ReceiveEventArgs e)
        {

            if (e.sendInfo.message != null)
            {
                files = e.sendInfo.message;
                if (files == "free")
                {
                    files = null;
                    label3.Text = "Подключен";
                    Mainstart._tcpmodule.SendText("done");
                    return;

                }else if (files == "busy")
                {
                    files = null;
                    MessageBox.Show("Клиент под таким логином уже подключен");
                    Mainstart._tcpmodule.recon = 1;
                    return;
                }
                else
                {
                    
                    //string[] lines = File.ReadAllLines("config.txt");
                    //lines[1] = ass;
                    //File.WriteAllLines("config.txt", lines);
                }
            }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            //DirDialog.Description = "Выбор директории";
            //DirDialog.SelectedPath = @"C:\";

            if (DirDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] lines = File.ReadAllLines("config.txt");
                lines[1] = DirDialog.SelectedPath;
                File.WriteAllLines("config.txt", lines);
            }

            /*OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] lines = File.ReadAllLines("config.txt");
                lines[1] = dlg.FileName;
                File.WriteAllLines("config.txt", lines);
            }*/
            StreamReader reader = new StreamReader("config.txt");
            txt_doc.Text = reader.ReadLine();
            txt_doc.Text = reader.ReadLine();
            //docfile = txt_doc.Text;
            reader.Close();
        }
        private void ARMmain_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("config.txt");
            txt_doc.Text = reader.ReadLine();
            txt_doc.Text = reader.ReadLine();
            //docfile = txt_doc.Text;
            reader.Close();

            for (int x = 1; x < 6; x++)
            {
                cmb_armlist.Items.Add("ARM" + x);

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //////
            if (Mainstart._tcpmodule.valu > 0)
            {
                timer1.Stop();
                exit = 1;
                ARMwork aRMwork = new ARMwork(files);

                aRMwork.Show();
                aRMwork.Location = new Point(-5, -5);
                
                this.Close();
            }
        }

        private void cmb_armlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void sendedtxt(int trys, string tex)
        {
            try
            {
                Mainstart._tcpmodule.SendText(tex);
                this.btn_login.Enabled = false;
            }
            catch
            {
                if (trys > 15)
                {
                    MessageBox.Show("Не удалось отправить сообщение. Сервер не доступен или невозможно к нему подключиться");
                    return;
                }
                trys += 1;
                Thread.Sleep(125);
                sendedtxt(trys, tex);
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if (cmb_armlist.Text == "")
            {
                MessageBox.Show("Вы не выбрали логин");
                return;
            }
            StreamReader reader = new StreamReader("config.txt");
            string nameServ = reader.ReadLine();
            reader.Close();
            //cmd cmd = new cmd(5);
            //cmd.Show();
            try
            {
                string IPserv = "";
                IPHostEntry host = Dns.GetHostEntry(nameServ);
                foreach (IPAddress address in host.AddressList)
                {
                    IPserv = ($"{address}");
                }
                Mainstart._tcpmodule.ConnectClient(IPserv, cmb_armlist.Text);

            }
            catch
            {
                MessageBox.Show("Не удалось подключиться");
                return;
            }
            sendedtxt(0, cmb_armlist.Text);



        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }

        private void ARMmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exit == 1)
            {
                return;
            }
            if (DialogResult.No == MessageBox.Show("Вы уверены, что хотите выйти? Если вы уже подключились, то рекомендуется не выходить во избежание ошибок.", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                e.Cancel = true;
            }
        }
    }
}
