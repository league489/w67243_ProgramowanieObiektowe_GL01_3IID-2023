using System;

namespace lab1
{
    class Program
    {
        static void Zad_1(){
            Console.WriteLine("Zad 1");
            Console.WriteLine("Podaj liczbę");
            int Number1 = Convert.ToInt32(Console.ReadLine());
          
            if (Number1 % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
}

        static void Zad_2()
        {
            Console.WriteLine("Zad 2");
            Console.WriteLine("Podaj liczbę");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            for (int  i = 1; i <= Number2; i++) {
                if(i == 1) {
                    Console.Write(i + "  ");
                }
                

                else if (i % 2 != 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + "  ");
                }
            }
        }
        static int silnia(int Numb)
        {

            if (Numb == 0)
            {
                return 1;
            }

            else
            {
                return Numb * silnia(Numb - 1);
            }
        }
        static void Zad_4()
        {
            Console.WriteLine("Zad 4");
            Console.WriteLine("Podaj liczbę");
            int Number4 = Convert.ToInt32(Console.ReadLine());
            int Silnia = silnia(Number4);
            Console.WriteLine("Silnia liczby {0} wynosi {1}", Number4, Silnia);
        }
        static void Zad_5()
        {
            Console.WriteLine("Zad 5");
            Random generator = new Random();
            int wylosowana = generator.Next(11);
            bool odgadnięte = false;
            int LiczbaProb = 0;
            Console.WriteLine("Liczba to: " + wylosowana);
            while(odgadnięte == false)
            {
                Console.WriteLine("Spróbuj zgadnąć liczbę liczbę");
                int probaZgadnięcia = Convert.ToInt32(Console.ReadLine());
                if (!(probaZgadnięcia == wylosowana))
                {
                    LiczbaProb++;
                    Console.WriteLine("Nie zgadłes , spróbuj jeszcze raz");
                }
                else {
                    LiczbaProb++;
                    Console.WriteLine("Zgadles za " + LiczbaProb + " razem");
                    odgadnięte = true;
                }
            }

        }
        static void FnaC()
        {
            Console.Write("Podaj liczbę stopni (F):  ");
            double LiczbaF = Convert.ToDouble(Console.ReadLine());
            double LiczbaC = LiczbaF * (-17.2222222);
            Console.WriteLine(LiczbaF + " Fahrenheitów to " + LiczbaC + " Celcjuszy");
        }
        static void CnaF()
        {
            Console.Write("Podaj liczbę stopni (C):  ");
            double LiczbaCL = Convert.ToDouble(Console.ReadLine());
            double LiczbaFH = LiczbaCL * (33.8);
            Console.WriteLine(LiczbaCL + " Celcjuszy to " + LiczbaFH + " Fahrenheitów");
        }

        static void MnaCM()
        {
            Console.Write("Podaj liczbę metrów:  ");
            double LiczbaM = Convert.ToDouble(Console.ReadLine());
            double LiczbaCM = LiczbaM * 100 ;
            Console.WriteLine(LiczbaM + " metrów to " + LiczbaCM + " centymetrów");
        }

        static void CMnaM()
        {
            Console.Write("Podaj liczbę centymetrów:  ");
            double Liczba_CM = Convert.ToDouble(Console.ReadLine());
            double Liczba_M = Liczba_CM / 100;
            Console.WriteLine(Liczba_CM + " centymetrów to " + Liczba_M + " metrów");
        }
        static void Zad_6()
        {
            Console.WriteLine("Zad 6");
            Console.WriteLine("Co chcesz zamienić?");
            Console.WriteLine("a) Fahrenheit -> Celcjusz");
            Console.WriteLine("b) Celcjusz -> Fahrenheit");
            Console.WriteLine("c) metry -> centymetry");
            Console.WriteLine("d) centymetry -> metry");
            
            string zamiana = Console.ReadLine();
            switch (zamiana)
            {
                case "a": FnaC();
                    break;

                case "b": CnaF();
                    break;
                case "c": MnaCM();
                    break;
                case "d": CMnaM();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz numer zadania: 1 , 2 , 4 , 5, 6");
            int NrZadania = Convert.ToInt32(Console.ReadLine());

            switch(NrZadania)
            {
                case 1: Zad_1();
                    break;
                case 2:
                    Zad_2();
                    break;
                case 4:
                    Zad_4();
                    break;
                case 5:
                    Zad_5();
                    break;
                case 6:
                    Zad_6();
                    break;
            }




        }
    }
}
