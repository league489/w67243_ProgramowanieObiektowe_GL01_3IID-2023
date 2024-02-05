using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Powtórzenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Książka k1 = new Książka("Rok 1984", "George Orwell", 1946);
            Książka k2 = new Książka("To", "Stephen King", 1986);
            Książka k3 = new Książka("Instytut", "Stephen King", 2021);
            Książka k4 = new Książka("Filozofia XD", "Sławomir Mentzen", 2022);

            //  k1.DejTytuł();
            //  k2.DejAutora();
            // k3.DejRokWydania();
            //  k4.DejWszystko();
            //Książka.KsiążkiWedługRokuWydania(1986);
            //Książka.KsiążkiWedługAutora("Sławomir Mentzen");
            Trójkąt tr1 = new Trójkąt(3, 4, 4);
            Prostokąt pr1 = new Prostokąt(2, 4);
            Koło kl1 = new Koło(2);
            Koło kl2 = new Koło(1);
            List<Kształt> Lista_Kształtów = new List<Kształt>();
            Lista_Kształtów.Add(kl1);
            Lista_Kształtów.Add(kl2);
            Lista_Kształtów.Add(pr1);
            Lista_Kształtów.Add(tr1);

            Console.WriteLine("Kształty z  większym niż 10");
            foreach(var x in Lista_Kształtów)
            {
                if (x.DejObwód() > 10)
                {
                    Console.WriteLine($" {x.DejPole()} ");
                }
                
            }
        }
    }
}