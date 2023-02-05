using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChSDocProcessing
{
    public partial class MainSetting : Form
    {
        
        public MainSetting()
        {
            InitializeComponent();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainSetting_Load(object sender, EventArgs e)
        {
            //FileStream file1 = new FileStream("config.txt", FileMode.Open);
            StreamReader reader = new StreamReader("config.txt");
            txt_ipserv.Text = reader.ReadLine();
            reader.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //FileStream file1 = new FileStream("config.txt", FileMode.Create);
            //StreamWriter writer = new StreamWriter("config.txt");
            //writer.WriteLine(txt_ipserv.Text);
            //writer.Close();
            string[] lines = File.ReadAllLines("config.txt");
            lines[0] = txt_ipserv.Text;
            File.WriteAllLines("config.txt", lines);
            Close();
        }
    }
}
