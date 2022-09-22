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

namespace Pr02
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
            list.Clear();

            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            
            for (int k = 0; k < n; k++)
            {
                list.Add(rnd.Next(-5, 21));
            }

            Knih.Vypis(listBox1, list);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int k = Convert.ToInt32(textBox2.Text);

            Knih.Smazani(k, list);
            Knih.Vypis(listBox2, list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int k = Convert.ToInt32(textBox2.Text);

            Knih.SmazaniLam(list, k);
            Knih.Vypis(listBox2, list);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox2.Text);

            int SecondMax = Knih.DruheMax(list, out int poradi);
            
            MessageBox.Show("Druhe maximum je " + SecondMax + " jeho index je " + poradi);
        }
    }
}
