using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static int MaxDva(List<int> Pomocna, out int SecMaxIndex)
        {
            int SecMaxCisl = 0;
            int[] pole = new int[Pomocna.Count];
            Pomocna.Sort();
            int max = pole.Max();
            SecMaxIndex = Pomocna.LastIndexOf(max + 1);
            SecMaxCisl = Pomocna[SecMaxIndex];

            if (SecMaxIndex < 0)
            {
                return (SecMaxIndex * -1);
            }
            else
            {
                return SecMaxCisl;
            }
        }

        public static void Reverze(List<int> list)
        {
            list.Reverse();
        }

        public static void PoradiMin(List<int> list, ListBox ListB)
        {
            int minimum = list.Min();
            int[] indexs = new int[list.Count];

            for (int k = 0; k < list.Count; k++)
            {
                if (list[k] == minimum)
                {
                    ListB.Items.Add(k);
                }
            }
        }

        public static List<int> ArPosloupnoust(int n, int a1, int d)
        {
            List<int> list = new List<int>();
            // n = 4; a1 = 3; d = 3; // 6 // 9 // 12 // 15

            int help = a1 + d;
            list.Add(a1+d); // 6
            for (int k = 1; k < n; k++)
            {
                help += d;
                list.Add(help);
            }
            return list;
        }

        public static List<int> GeoPosloupnost (int n, int a1, int a2)
        {
            List<int> list = new List<int>();
            int vetsi = a1;
            int mensi = a2;

            if (a1 > a2)
            {
                vetsi = a1;
                mensi = a2;
            }
            else
            {
                vetsi = a2;
                mensi = a1;
            }

            int deleni = vetsi / mensi;
            int pomocna = (vetsi * deleni); ;
            for (int k = 0; k < n; k++)
            {
                list.Add(pomocna);
                pomocna = pomocna * deleni;
            }
            return list;
        }

        public static int SoucetPrvku (List<int> list, int p)
        {
            int soucet = 0;

            if (p <= list.Count())
            {
                for (int k = 0; k < p; k++)
                {
                    soucet += list[k];
                }
            }
            else
            {
                MessageBox.Show("Číslo p je větší než počet prvků v listu");
            }
            return soucet;
        }
    }
}