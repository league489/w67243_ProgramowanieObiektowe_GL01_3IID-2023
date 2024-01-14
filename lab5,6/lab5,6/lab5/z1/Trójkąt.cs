using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z1
{
    public class Trójkąt : Shape
    {
        public int Podstawa;
        public int Wysokość;
        public Trójkąt(int a, int h)
        {
            Podstawa = a;
            Wysokość = h;
        }

        public override void CalculateArea()
        {
            double poleTrójkąta = Podstawa * Wysokość / 2;
            Console.WriteLine($"Pole tego Trójkąta wynosi: {poleTrójkąta}");
        }

    }
}
