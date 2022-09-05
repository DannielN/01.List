using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();

            for (int k = 0; k < n; k++)
            {
                list.Add(rnd.Next(1, 101));
                listBox1.Items.Add(list[k]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Sort();
            string text = string.Empty;

            for (int k = 0; k < list.Count(); k++)
            {
                text += list[k];
                text += ",";
            }
            MessageBox.Show(text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
