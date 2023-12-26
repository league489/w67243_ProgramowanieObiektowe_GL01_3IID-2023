using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    public class Sumator
    {
        public int[] Liczby;

        public int Suma()
        {
            int sumka = 0;
            foreach (int i in Liczby)
            {
                sumka += i;
            }
            return sumka;
        }

        public int SumaPodziel3()
        {
            int sumkaP3 = 0;
            foreach (int i in Liczby)
            {
                if (i % 3 == 0)
                {
                    sumkaP3 += i;
                }
            }
            return sumkaP3;
        }

        public Sumator(int[] liczby)
        {
            this.Liczby = liczby;
        }
        public void Wypisz()
        {

            foreach (int i in Liczby)
            {
                Console.Write(i + " ");
            }
        }
        public int IleElementow()
        {
            int n = 0;
            foreach (int i in Liczby)
            {
                n++;
            }
            return n;
        }
        public void WypiszZakres(int lowIndex, int highIndex)
        {
            for (int i = Math.Max(lowIndex, 0); i < Math.Min(highIndex + 1, Liczby.Length); i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }


    }

}
