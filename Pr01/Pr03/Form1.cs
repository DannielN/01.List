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

namespace Pr03
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
            list.Clear();
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);


            for (int k = 0; k < n; k++)
            {
                list.Add(rnd.Next(-3, 7));
            }

            Knih.Vypis(listBox1, list);
            Knih.SmazaniLam(list, 0);
            Knih.Vypis(listBox2, list);

            int DruheMax = Knih.MaxDva(list, out int DruheMaxIndex);
            MessageBox.Show("Druhé maximum " + DruheMax + " leží na indexu " + DruheMaxIndex); 
        }
    }
}
