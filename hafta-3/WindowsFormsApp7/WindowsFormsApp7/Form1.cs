using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in secimSirasi)
            {
                listBox3.Items.Add(item);
            }

            foreach (var item in secimSirasi.ToList())
            {
                listBox2.Items.Remove(item);
            }

            secimSirasi.Clear();
        }

        private List<object> secimSirasi = new List<object>();
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                var item = listBox2.Items[i];
                bool seciliMi = listBox2.GetSelected(i);

                if (seciliMi && !secimSirasi.Contains(item))
                {
                    secimSirasi.Add(item);
                }
                else if (!seciliMi && secimSirasi.Contains(item))
                {
                    secimSirasi.Remove(item);
                }
            }
        }
    }
}
