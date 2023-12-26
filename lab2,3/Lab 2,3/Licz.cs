using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    public class Licz
    {
        private int wartosc;

        public Licz(int V)
        {
            wartosc = V;
        }

        public void Dodaj(int vP)
        {
            wartosc += vP;
        }

        public void Odejmij(int vM)
        {
            wartosc -= vM;
        }

        public void SprawdzWartosc()
        {
            Console.WriteLine(Wartosc);
        }

        public int Wartosc
        {
            get { return wartosc; }
        }
    }

}
