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

namespace Pr08
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
            list = Knih.GeneraceCisel(n);
            Knih.Vypis(listBox1, list);

            Knih.ProhozeniCisel(list);
            Knih.Vypis(listBox2, list);
        }
    }
}
