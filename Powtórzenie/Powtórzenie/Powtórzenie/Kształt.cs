using System;
using System.Collections.Generic;
using System.Text;

namespace Powtórzenie
{
    public abstract class Kształt
    {
        public int X;
        public int Y;   
        public virtual double DejPole() 
        {

            return X * Y;
        }

        public virtual double DejObwód()
        {
            return 2* X + 2* Y; 
        }
    }
}
