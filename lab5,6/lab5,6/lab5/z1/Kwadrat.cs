using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z1
{
    public class Kwadrat : Shape
    {
        public int BokKwadratu;

        public Kwadrat(int bokK)
        {
            BokKwadratu = bokK;
        }
        public override void CalculateArea()
        {
            double PoleKwadratu = Math.Pow(BokKwadratu, 2);
            Console.WriteLine($"Pole tego kwadratu wynosi : {PoleKwadratu}");
        }


    }
}
