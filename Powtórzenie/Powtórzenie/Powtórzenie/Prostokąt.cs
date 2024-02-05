using System;
using System.Collections.Generic;
using System.Text;

namespace Powtórzenie
{
   public class Prostokąt : Kształt
    {
        public Prostokąt(int x, int y)
        {
            X = x;
            Y = y;  
        }

        public override double DejObwód()
        {
            return 2 * X + 2 * Y;   
        }

        public override double DejPole()
        {
            return X * Y;
        }
    }
}
