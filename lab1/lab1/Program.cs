using System;

namespace lab1
{
    class Program
    {
        static void Zad_1(int liczba){
              int Numbber = liczba;
            if (Numbber % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
}
        static void Zad_2(int liczba)
        {
            int Numbber = liczba;
            if (Numbber % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zad 1");
            Console.WriteLine("Podaj liczbę");
            int Numb = Convert.ToInt32(Console.ReadLine());
            Zad_1(Numb);

        }
    }
}
