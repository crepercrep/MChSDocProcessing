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
    public partial class WorkDistribution : Form
    {
        string nameevent;
        public WorkDistribution(string even)
        {
            InitializeComponent();
            nameevent = even;
        }

        private void WorkDistribution_Load(object sender, EventArgs e)
        {
            DirectoryInfo incid = new DirectoryInfo("..\\filedoc");
            for (int x = 1; x < 6; x++)
            {
                lst_free.Items.Add("ARM" + x);

            }
            string chs = "";
            foreach (var ar in incid.GetFiles())
            {
                chs = ar.Name;
                lst_random.Items.Add(chs);
            }

            if (nameevent != null)
            {
                txt_chsname.Text = nameevent;
                StreamReader reader = new StreamReader("..\\net5.0-windows\\events\\" + nameevent + ".txt");
                string arms = reader.ReadLine();
                string docs = reader.ReadLine();
                reader.Close();
                string[] ArmNames;
                ArmNames = arms.Split("-");
                string[] FNames;
                FNames = docs.Split("|||");
                int coun = 0;
                for (int x = 1; x < 6; x++)
                {
                    foreach (string namearm in ArmNames)
                    {
                        if (namearm == "ARM" + x)
                        {
                            lst_free.Items.Remove(namearm);
                            lst_slaves.Items.Add(namearm);
                        }
                    }
                }
                string chss = "";
                foreach (var ar in incid.GetFiles())
                {
                    chss = ar.Name;
                    foreach (string namef in FNames)
                    {
                        if (namef == chss)
                        {
                            lst_random.Items.Remove(namef);
                            lst_morerandom.Items.Add(namef);
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_addslave_Click(object sender, EventArgs e)
        {
            if (lst_free.SelectedItems.Count < 1) { return; }
            string it = lst_free.SelectedItem.ToString();
            lst_free.Items.Remove(it);
            lst_slaves.Items.Add(it);
        }

        private void txt_chsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addnamechs_Click(object sender, EventArgs e)
        {
            if (nameevent != null)
            {
                string pathdel = AppDomain.CurrentDomain.BaseDirectory + "..\\net5.0-windows\\events\\" + nameevent + ".txt";
                File.Delete(pathdel);
            }
            string arms = string.Join("-", lst_slaves.Items.OfType<object>());
            string docs = string.Join("|||", lst_morerandom.Items.OfType<object>());

            FileStream file1 = new FileStream("..\\net5.0-windows\\events\\" + txt_chsname.Text + ".txt", FileMode.Create);
            file1.Close();
            StreamWriter writer = new StreamWriter("..\\net5.0-windows\\events\\" + txt_chsname.Text + ".txt");
            writer.WriteLine(arms);
            writer.WriteLine(docs);
            writer.Close();



            IncinentsList incinentslist = new IncinentsList();
            this.Close();
            incinentslist.Show();
            incinentslist.Location = new Point(this.Left, this.Top);

        }

        private void lst_random_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_morerandom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addwtf_Click(object sender, EventArgs e)
        {
            if (lst_random.SelectedItems.Count < 1) { return; }
            string it = lst_random.SelectedItem.ToString();
            lst_random.Items.Remove(it);
            lst_morerandom.Items.Add(it);
        }

        private void btn_delarm_Click(object sender, EventArgs e)
        {
            if (lst_slaves.SelectedItems.Count < 1) { return; }
            string it = lst_slaves.SelectedItem.ToString();
            lst_slaves.Items.Remove(it);
            lst_free.Items.Add(it);
        }

        private void btn_exitchslist_Click(object sender, EventArgs e)
        {
            IncinentsList incinentslist = new IncinentsList();
            this.Close();
            incinentslist.Show();
            incinentslist.Location = new Point(this.Left, this.Top);
        }

        private void btn_delwtf_Click(object sender, EventArgs e)
        {
            if (lst_morerandom.SelectedItems.Count < 1) { return; }
            string it = lst_morerandom.SelectedItem.ToString();
            lst_morerandom.Items.Remove(it);
            lst_random.Items.Add(it);
        }
    }
}
