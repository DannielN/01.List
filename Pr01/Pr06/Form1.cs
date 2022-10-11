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

namespace Pr06
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
            
            int n = Convert.ToInt32(textBox1.Text);
            int a1 = Convert.ToInt32(textBox2.Text);
            int a2 = Convert.ToInt32(textBox3.Text);

            list = Knih.GeoPosloupnost(n, a1, a2);
            Knih.Vypis(listBox1, list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox4.Text);

            int soucet = Knih.SoucetPrvku(list, p);
            MessageBox.Show("Součet prvních " + p + " prvků v listu je " + soucet);
        }
    }
}
