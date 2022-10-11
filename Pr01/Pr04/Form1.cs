using Knihovna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04
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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            list.Clear();
            Random rnd = new Random();

            for (int k = 0; k < Convert.ToInt32(textBox1.Text); k++)
            {
                list.Add(rnd.Next(-5, 24));
            }

            Knih.Vypis(listBox1, list);
            Knih.Reverze(list);
            Knih.Vypis(listBox2, list);

            Knih.PoradiMin(list, listBox3);
        }
    }
}
