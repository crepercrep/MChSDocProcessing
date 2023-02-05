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
using System.Net.Sockets;
using System.Threading;

namespace MChSDocProcessing
{
    public partial class SODstart : Form
    {
        int exits = 0;
        int stateM = 0;
        int stateO = 0;
        string arm = "";
        //TcpModule _tcpmodule = new TcpModule();
        public SODstart()
        {
            InitializeComponent();

            // _tcpmodule.Receive += new TcpModule.ReceiveEventHandler(_tcpmodule_Receive);
            //_tcpmodule.Disconnected += new TcpModule.DisconnectedEventHandler(_tcpmodule_Disconnected);
            // _tcpmodule.Connected += new TcpModule.ConnectedEventHandler(_tcpmodule_Connected);
            // _tcpmodule.Accept += new TcpModule.AcceptEventHandler(_tcpmodule_Accept);
            //_tcpmodule.Parent = this;
            Mainstart._tcpmodule.Receive += new TcpModule.ReceiveEventHandler(_tcp_Receive);
        }

        private void _tcp_Receive(object sender, ReceiveEventArgs e)
        {
            if (e.sendInfo.message == "done")
            {
                this.lst_connarms.Items.Add(arm + ": подключен");
                //lst_connarms.Items.Add(arm + ": подключен");
                e.sendInfo.message = null;
                return;
            }
            arm = e.sendInfo.message;
            //string asss = e.sendInfo.message;
            //if (asss != null) { lst_connarms.Items.Add(asss + ": подключен"); }

        }

        private void SODstart_Load(object sender, EventArgs e)
        {
            DirectoryInfo incid = new DirectoryInfo("..\\net5.0-windows\\events");
            string namein = "";
            foreach (var ar in incid.GetFiles())
            {
                namein = ar.Name;
                char[] minus = { '.', 't', 'x' };
                namein = namein.TrimEnd(minus);
                cb_incidents.Items.Add(namein);
            }

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cb_incidents.Text == "")
            {
                MessageBox.Show("Вы не выбрали ЧС");
                return;
            }else if(txt_hour.Text == "" || txt_min.Text == "" || txt_worktime.Text == "")
            {
                MessageBox.Show("Вы не заполнили поля");
                return;
            }
            StreamReader reader = new StreamReader("..\\net5.0-windows\\events\\" + cb_incidents.Text + ".txt");
            string arms = reader.ReadLine();
            string docs = reader.ReadLine();
            reader.Close();
            Mainstart._tcpmodule.Armname(arms);
            Mainstart._tcpmodule.SendText(docs);
            //File.WriteAllText("..\\docs\\SODfile.txt", this.txt_hour.Text + ":" + this.txt_min.Text);
            ///////////////
            FileStream file1 = new FileStream("..\\docs\\SODfile.txt", FileMode.Create);
            file1.Close();
            StreamWriter writer = new StreamWriter("..\\docs\\SODfile.txt");
            string sodHour = this.txt_hour.Text;
            string sodMin = this.txt_min.Text;
            if (txt_hour.Text.Length == 1)
            {
                sodHour = "0" + this.txt_hour.Text;
            }
            if (txt_min.Text.Length == 1)
            {
                sodMin = "0" + this.txt_min.Text;
            }
            writer.WriteLine(sodHour + ":" + sodMin);
            writer.WriteLine(this.txt_worktime.Text);
            writer.Close();
            ///////////////
            Mainstart._tcpmodule.SendFileName = "..\\docs\\SODfile.txt";
            Thread t = new Thread(Mainstart._tcpmodule.SendData);
            t.Start();
            exits = 1;
            SODwork sODwork = new SODwork(sodHour, sodMin);
            //SODstart sODstart = this;
            sODwork.Show();
            this.Close();
            sODwork.Location = new Point(this.Left, this.Top);
            //Mainstart._tcpmodule.valu = 1;
            //int sss = Mainstart._tcpmodule.valuret();
            //cmd cmd = new cmd(sss);
            //cmd.Show();
            //Close();
            //Mainstart._tcpmodule.uploaded = 0;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

            IncinentsList incinentslist = new IncinentsList();
            incinentslist.Show();
            incinentslist.Location = new Point(this.Left, this.Top);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SODstart_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form mainstart = Application.OpenForms["Mainstart"];
            //mainstart.Show();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Mainstart._tcpmodule.CloseSocket();
            Close();
        }



        private void cb_incidents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_connarms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_incidents_Click(object sender, EventArgs e)
        {
            cb_incidents.Items.Clear();
            DirectoryInfo incid = new DirectoryInfo("..\\net5.0-windows\\events");
            string namein = "";
            foreach (var ar in incid.GetFiles())
            {
                namein = ar.Name;
                char[] minus = { '.', 't', 'x' };
                namein = namein.TrimEnd(minus);
                cb_incidents.Items.Add(namein);
            }
        }

        private void txt_hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txt_hour.Focus()) { return; }
            

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127)
            {
                e.Handled = true;
                return;
            }
            if (txt_hour.SelectionLength > 0) { return; }
            if ((txt_hour.Text.Length > 1) && number != 8 && number != 127)
            {
                e.Handled = true;
                return;
            }
            
            if (txt_hour.Text != "")
            {
                if (Int32.Parse(txt_hour.Text) > 23)
                {
                    e.Handled = true;
                }
            }
            
        }

        private void txt_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127)
            {
                e.Handled = true;
                return;
            }
            if (txt_min.SelectionLength > 0) { return; }
            if ((txt_min.Text.Length > 1) && number != 8 && number != 127)
            {
                e.Handled = true;
                return;
            }
            if (txt_min.Text != "")
            {
                if (Int32.Parse(txt_min.Text) > 59)
                {
                    e.Handled = true;
                }
            }
            //if (txt_min.Focused) { return; }
        }

        private void txt_worktime_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127)
            {
                e.Handled = true;
                return;
            }
            if (txt_worktime.SelectionLength > 0) { return; }
            if ((txt_worktime.Text.Length > 2) && number != 8 && number != 127)
            {
                e.Handled = true;
                return;
            }
            if (txt_worktime.Text != "")
            {
                if (Int32.Parse(txt_worktime.Text) > 600)
                {
                    e.Handled = true;
                }
            }
            //if (txt_worktime.Focused) { return; }
        }

        private void txt_hour_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_hour.Text != "")
            {
                if (Int32.Parse(txt_hour.Text) > 23)
                {
                    txt_hour.Text = "23";


                }
            }
        }

        private void txt_min_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_min.Text != "")
            {
                if (Int32.Parse(txt_min.Text) > 59)
                {
                    txt_min.Text = "59";


                }
            }
        }

        private void txt_worktime_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_worktime.Text != "")
            {
                if (Int32.Parse(txt_worktime.Text) > 600)
                {
                    txt_worktime.Text = "600";


                }
            }
        }

        private void btn_editway_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SODstart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exits == 1)
            {
                return;
            }
            if (DialogResult.No == MessageBox.Show("Вы уверены, что хотите выйти? Сервер закроется и придется заново подключаться.", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                e.Cancel = true;
            }
        }

    }
}