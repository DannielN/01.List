using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihovna
{
    public class Knih
    {
        public static void Vypis(ListBox Lis, List<int> list)
        {
            int n = list.Count();
            for (int k = 0; k < n; k++)
            {
                Lis.Items.Add(list[k]);
            }
        }

        public static List<int> Smazani(int k, List<int> list)
        {
            while (list.Contains(k))
            {
                list.Remove(k);
            }
            return list;
        }

        public static List<int> SmazaniLam(List<int> list, int k)
        {
            list.RemoveAll(a => a == k);
            return list;
        }

        public static int DruheMax(List<int> list, out int poradi)
        {
            int SecondMax = -6;
            poradi = -1;
            int max = -6;
            int k = list.Count();

            for (int i = 0; i < k; i++)
            {
                if (list[i] > max)
                {
                    SecondMax = max;
                    max = list[i];
                }
                else if (list[i] < max && list[i] > SecondMax)
                {
                    SecondMax = list[i];
                    poradi = i;
                }
            }

            return SecondMax;
        }
    }
}
