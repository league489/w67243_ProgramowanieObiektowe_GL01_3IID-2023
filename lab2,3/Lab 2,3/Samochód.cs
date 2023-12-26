using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    public class Samochód
    {
        public string Marka, Model;
        public int RokProdukcji;
        private float Przebieg;
        private int Prędkość;
        private StanSilnika Stan_Silnika;
        public float _Przebieg
        {
            get
            {
                return Przebieg;
            }

            set
            {
                Przebieg = value;
            }
        }

        public int _Prędkość
        {
            get
            {
                return Prędkość;
            }

            set
            {
                Prędkość = value;
            }
        }

        public int _Obecna_Prędkość
        {
            get
            {
                return Prędkość;
            }
        }

        public StanSilnika _Stan_Silnika
        {
            get
            {
                return Stan_Silnika;
            }

            set
            {
                Stan_Silnika = value;
            }
        }

        public enum StanSilnika
        {
            Włączony,
            Wyłączony,
            Zepsuty,
            CheckEngine
        }

        public Samochód(string marka, string model, int rokprodukcji, float przebieg, int prędkość, StanSilnika stanSilnika)
        {
            this.Marka = marka;
            this.Model = model;
            this.RokProdukcji = rokprodukcji;
            this.Przebieg = przebieg;
            this.Prędkość = prędkość;
            this.Stan_Silnika = stanSilnika;
        }

        public void Tempomat(int v)
        {
            if (this.Stan_Silnika == Samochód.StanSilnika.Wyłączony)
            {
                Console.WriteLine("Uruchom silnik");
            }
            else
            {
                this.Prędkość = v;
            }
        }

        public void Przyspiesz()
        {
            if (this.Stan_Silnika == Samochód.StanSilnika.Wyłączony)
            {
                Console.WriteLine("Uruchom silnik");
            }
            else
            {
                this.Prędkość += 5;
            }
        }

        public void Zwolnij()
        {
            if (this.Stan_Silnika == Samochód.StanSilnika.Wyłączony)
            {
                Console.WriteLine("Uruchom silnik");
            }
            else
            {
                this.Prędkość -= 5;
            }
        }

        public void Przejedź(int dystans)
        {
            int krotność = 10000;
            float nowyPrzebieg = this.Przebieg + dystans;
            if (this.Stan_Silnika == Samochód.StanSilnika.CheckEngine)
            {
                return;
            }
            else if (nowyPrzebieg >= krotność && this.Stan_Silnika != Samochód.StanSilnika.CheckEngine)
            {
                Console.WriteLine("Czas na przegląd silnika.");
                this.Przebieg = nowyPrzebieg;
                this.Stan_Silnika = Samochód.StanSilnika.CheckEngine;
                return;
            }
            else
            {
                if (this.Prędkość != 0)
                {
                    float czas = dystans / (float)this.Prędkość;
                    Console.WriteLine("Czas przejazdu " + czas + " h");
                    this.Przebieg = nowyPrzebieg;
                }
                else
                {
                    Console.WriteLine("Samochód stoi w miejscu. Prędkość wynosi 0.");
                }
            }
        }

        public void Uruchom()
        {
            if (this.Stan_Silnika == Samochód.StanSilnika.Zepsuty || this.Stan_Silnika == Samochód.StanSilnika.CheckEngine)
            {
                Console.WriteLine("Nie można uruchomić silnika, wezwij serwis ");
            }
            else
            {
                this.Stan_Silnika = Samochód.StanSilnika.Włączony;
                if (this.Stan_Silnika == Samochód.StanSilnika.CheckEngine)
                {
                    return;
                }
            }
        }

        public void Zgaś()
        {
            this.Stan_Silnika = Samochód.StanSilnika.Wyłączony;
        }

        public void Napraw()
        {
            if (this.Stan_Silnika == Samochód.StanSilnika.Zepsuty || this.Stan_Silnika == Samochód.StanSilnika.CheckEngine)
            {
                this.Stan_Silnika = Samochód.StanSilnika.Wyłączony;
                Console.WriteLine("Samochód został naprawiony");
            }
        }
    }

}
