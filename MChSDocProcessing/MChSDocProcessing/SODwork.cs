using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChSDocProcessing
{
    public partial class SODwork : Form
    {
        int hour;
        int min;
        int sec;
        string[] fileNames;
        int recivs = 0;
        public SODwork(string val_txt_hour, string val_txt_min)
        {
            InitializeComponent();
            Mainstart._tcpmodule.Receive += new TcpModule.ReceiveEventHandler(_tcp_Receive);
            this.val_txt_hour = val_txt_hour;
            this.val_txt_min = val_txt_min;
        }
        private void _tcp_Receive(object sender, ReceiveEventArgs e)
        {
            int lstC = lst_docstate.Items.Count;
            if (e.sendInfo.filesize > 0)
            {
                if (lst_docstate.Items.Contains(e.sendInfo.filename) == true)
                {
                    lst_docstate.Items.Remove(e.sendInfo.filename);
                    lst_docstate.Items.Add("|✓|" + e.sendInfo.filename);
                    recivs += 1;
                }
                if (lstC <= recivs)
                {
                    this.Close();
                }
                return;

            }
            
            
            string filestring = e.sendInfo.message;
            
            fileNames = filestring.Split("}}");
            foreach(string ar in fileNames)
            {
                if (ar != "")
                {
                    lst_docstate.Items.Add(ar);
                }
                
            } 
        }

        string val_txt_hour;
        string val_txt_min;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sec += 1;
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
            lab_hour.Text = Convert.ToString(hour);
            lab_min.Text = Convert.ToString(min);
            lab_sec.Text = Convert.ToString(sec);

        }

        private void SODwork_Load(object sender, EventArgs e)
        {
            lab_txt_hour.Text ="Начало происшествия:" + val_txt_hour+":"+val_txt_min; 
            //lab_begin.Text = "Начало отработки: " + DateTime.Now.ToShortDateString("MM.dd") + ", " + DateTime.Now.ToLongTimeString("HH.mm.ss");
            lab_begin.Text = "Начало отработки: " + DateTime.Now.ToString("dd.MM, HH:mm");
        }

        private void lst_docstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
