using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Nauczyciel : Uczeń
    {
        public string TytułNaukowy;
        public List<Uczeń> PodwładniUczniowie = new List<Uczeń>();
        public override string GetFullName()
        {
            return $"{TytułNaukowy} {base.GetFullName()}";
        }
        public void WhichStudentCanGoHomeAlone()
        {
            foreach (var Uczeń in PodwładniUczniowie)
            {
                if (Uczeń.CanGoAloneToHome() == true)
                {
                    Console.WriteLine(Uczeń.GetFullName());
                }
            }
        }

        public void DzisiejszaKlasa(DateTime date)
        {
            Console.WriteLine($"{GetEducationInfo()} Dnia: {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel: {GetFullName()}");
            Console.WriteLine("Lista studentów:");
            var i = 0;
            foreach (var Uczeń in PodwładniUczniowie)
            {
                i++;
                Console.WriteLine($"{i}. {Uczeń.GetFullName()} - {Uczeń.GetGender()} - {Uczeń.CanGoAloneToHome()} - {Uczeń.Info()}");
            }
        }

    }
}
