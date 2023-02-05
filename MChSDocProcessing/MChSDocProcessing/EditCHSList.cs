using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChSDocProcessing
{
    public partial class IncinentsList : Form
    {
        public IncinentsList()
        {
            InitializeComponent();
        }

        private void btn_delchs_Click(object sender, EventArgs e)
        {

            if (lst_chslist.SelectedItems.Count < 1) { return; }
            string it = lst_chslist.SelectedItem.ToString();
            //DirectoryInfo incid = new DirectoryInfo("..\\net5.0-windows\\events\\"+ it+".txt");
            //string pathdel = Path.GetDirectoryName("..\\net5.0-windows\\events\\"+ it+".txt");
            string pathdel = AppDomain.CurrentDomain.BaseDirectory + "..\\net5.0-windows\\events\\" + it + ".txt";
            File.Delete(pathdel);
            if (lst_chslist.SelectedItems.Count < 1) { return; }

            lst_chslist.Items.Remove(it);
        }

        private void btn_addchs_Click(object sender, EventArgs e)
        {
            WorkDistribution workDistribution = new WorkDistribution(null);
            this.Close();
            workDistribution.Show();
            workDistribution.Location = new Point(this.Left, this.Top);



        }

        private void IncinentsList_Load(object sender, EventArgs e)
        {
            DirectoryInfo incid = new DirectoryInfo("..\\net5.0-windows\\events");
            string namein = "";
            foreach (var ar in incid.GetFiles())
            {
                namein = ar.Name;
                char[] minus = { '.', 't', 'x' };
                namein = namein.TrimEnd(minus);
                lst_chslist.Items.Add(namein);
            }
        }

        private void lst_chslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            //SODstart sODstart = new SODstart();
            //sODstart.Show();

        }

        private void btn_editchs_Click(object sender, EventArgs e)
        {
            if (lst_chslist.SelectedItems.Count < 1) { return; }
            string even = (lst_chslist.SelectedItem.ToString());
            WorkDistribution workDistribution = new WorkDistribution(even);
            this.Close();
            workDistribution.Show();
            workDistribution.Location = new Point(this.Left, this.Top);
        }
    }
}
