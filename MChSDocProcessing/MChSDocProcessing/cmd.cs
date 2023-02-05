using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChSDocProcessing
{
    public partial class cmd : Form
    {
        int ass;
        List<string> array = new List<string>() {};
        //string[] array;
        public cmd(int kindalikeasus)
        {
            InitializeComponent();
            ass = kindalikeasus;
        }

        private void LB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void addsome(string asa)
        {
            LB.Items.Add(asa);
        }
        public void addsome(int asa)
        {
            LB.Items.Add(asa);
        }
        private void cmd_Load(object sender, EventArgs e)
        {
            //array.Add("123");
            //array.Add("12223");
            //array.Add("12333333");
            //foreach(string i in array)
            //{
                //LB.Items.Add(i);
           // }
            //LB.Items.Add(ass);
            //LB.Items.Add("sds");

        }
    }
}
