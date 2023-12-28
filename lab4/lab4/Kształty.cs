using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Do podawania kształtów");
        }

    }
    public class Rectangle : Shape
    {


        public override void Draw()
        {
            Console.WriteLine($"Prostokąt {X},{Y}");
        }
    }

    public class Triangle : Shape
    {


        public override void Draw()
        {
            Console.WriteLine($"Trójkąt {X},{Y},{Height}");
        }
    }
    public class Circle : Shape
    {
        public int R { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Koło {R}");
        }
    }
}




