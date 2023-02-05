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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChSDocProcessing
{
    public partial class Mainstart : Form
    {
        public static TcpModule _tcpmodule = new TcpModule();
        int close = 0;
        cmd cmd = new cmd(213);
        int start = 0;
        
        public Mainstart()
        {
            InitializeComponent();
            _tcpmodule.Parent = this;
            
            _tcpmodule.Receive += new TcpModule.ReceiveEventHandler(_tcpmodule_Receive);
        }

        private void btn_SOD_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (start == 0)
            {
                _tcpmodule.StartServer();
                start = 1;
            }
            
            SODstart sODstart = new SODstart();
            //this.Hide();
            sODstart.Show();
            sODstart.Location = new Point(this.Left, this.Top);

        }

        private void Mainstart_Load(object sender, EventArgs e)
        {
            /*SODwork sODwork = new SODwork("33","22");
            sODwork.Show();
            ARMwork aRMwork = new ARMwork();
            aRMwork.Show();*/
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            close = 1;
            Close();
        }

        private void btn_ARM_Click(object sender, EventArgs e)
        {
            this.Hide();
            ARMmain aRMmain = new ARMmain();
            //this.Hide();
            aRMmain.Show();
            aRMmain.Location = new Point(this.Left, this.Top);


            //ARMwork aRMwork = new ARMwork();
            //aRMwork.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (!File.Exists("config.txt"))
            {
                FileStream file1 = new FileStream("config.txt", FileMode.Create);
                file1.Close();
                StreamWriter writer = new StreamWriter("config.txt");
                writer.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n");
                writer.Close();

            }
            MainSetting mainSetting = new MainSetting();
            mainSetting.ShowDialog();
        }

        private void Mainstart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == 0)
            {
                e.Cancel = true;
                this.Hide();
                Mainstart_icon.BalloonTipTitle = "Программа свернута";
                Mainstart_icon.BalloonTipText = "Но она еще работает";
                Mainstart_icon.ShowBalloonTip(500);
            }
        }

        private void Mainstart_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        void _tcpmodule_Receive(object sender, ReceiveEventArgs e)
        {

            if (e.sendInfo.message != null)
            {
                if (_tcpmodule.who < 1)
                {

                    if (e.sendInfo.message[0] == 'A')
                    {
                        _tcpmodule.addarm(e.sendInfo.message);
                    }


                    //cmd.addsome(asss);
                }


            }

        }

        private void Mainstart_Resize(object sender, EventArgs e)
        {

        }
        public void SODstart()
        {

        }
    }
}
