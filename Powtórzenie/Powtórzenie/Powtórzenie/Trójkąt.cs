using System;
using System.Collections.Generic;
using System.Text;

namespace Powtórzenie
{
    internal class Trójkąt : Kształt
    {
        public int A;
        public int B;
        public int H;

        public Trójkąt(int a,int b, int h)
        {
            A = a;
            B = b;  
            H = h;
        
        }

        public override double DejObwód()
        {
            return 2 * B + A;
        }

        public override double DejPole()
        {
            return (A * H) / 2;
        }
    }
}
