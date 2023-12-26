
using Lab_2_3;
using System;

internal class Program
{
   

    private static void Main(string[] args)
    {
        Licz skladanka = new Licz(2);
        skladanka.Dodaj(20);
        skladanka.Odejmij(10);
        skladanka.SprawdzWartosc();
        Sumator s1 = new Sumator(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Console.WriteLine("Suma: " + s1.Suma());
        Console.WriteLine("Suma podzielna przez 3: " + s1.SumaPodziel3());
        s1.Wypisz();
        Console.Write("Tablica zawiera " + s1.IleElementow() + " elementow");
        s1.WypiszZakres(1, 5);
        Samochód autko1 = new Samochód("Ford", "Focus", 1999, 9000, 0, Samochód.StanSilnika.Włączony);
        Samochód autko2 = new Samochód("Skoda", "Fabia", 2002, 8000, 0, Samochód.StanSilnika.Włączony);
        autko1.Tempomat(80);
        autko1.Przyspiesz();
        autko1.Zwolnij();
        //Console.WriteLine(autko1._Przebieg + "  ");
        autko1.Przejedź(700);
        Console.WriteLine(autko1._Przebieg + "  ");
        autko1.Przejedź(700);
        Console.WriteLine(autko1._Przebieg + "  ");
        Console.WriteLine(autko1._Stan_Silnika + "  ");
        autko1.Napraw();
        Console.WriteLine(autko1._Stan_Silnika + "  ");
        autko1.Przejedź(700);
        //autko1.Uruchom();
        //Console.WriteLine(autko1._Przebieg + "  ");
        Console.WriteLine(autko1._Stan_Silnika + "  ");
        Osoba obywatel = new Osoba("Rafał", "Kiełbowicz", 21, autko1);
        Console.WriteLine(obywatel.CzyPełnoletnia());
        obywatel.UstawNazwisko("Masny");
        Console.WriteLine(obywatel.Imie_i_Nazwisko);
        obywatel.UstawSamochod(autko2);
        obywatel.JakieAuto();
    }
}