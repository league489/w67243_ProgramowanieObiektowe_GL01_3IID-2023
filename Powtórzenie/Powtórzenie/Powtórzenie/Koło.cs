using System;
using System.Collections.Generic;
using System.Text;

namespace Powtórzenie
{
    public class Koło : Kształt
    {
        public int R;

        public Koło (int r)
        {
            R = r;
        }

        public override double DejObwód()
        {
            return 2 * Math.PI * R;
        }

        public override double DejPole()
        {
            return Math.PI *  Math.Pow(R,2) ;
        }
    }
}
