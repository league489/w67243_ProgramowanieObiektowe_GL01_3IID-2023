using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z1
{
    public class Koło : Shape
    {
        public int r;
        public Koło(int promień)
        {
            r = promień;
        }
        public override void CalculateArea()
        {
            double PoleKoła = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Pole tego koła to: {PoleKoła}");
        }
    }
}
