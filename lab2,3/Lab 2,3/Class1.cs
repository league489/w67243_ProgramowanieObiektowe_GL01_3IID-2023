using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    public class Osoba
    {

        private string Imie, Nazwisko;
        private int Wiek;
        public Samochód Auto;
        public string _Imie
        {
            get { return Imie; }
        }
        public string _Nazwisko
        {
            get { return Imie; }
            set { Imie = value; }
        }
        public int _Wiek
        {
            get { return Wiek; }
        }
        public string Imie_i_Nazwisko
        {
            get { return Imie + Nazwisko; }
        }
        public Osoba(string imie, string nazwisko, int wiek, Samochód auto)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
            this.Auto = auto;
        }

        public bool CzyPełnoletnia()
        {
            return this.Wiek >= 18;
        }

        public void UstawNazwisko(string NoweNazwisko)
        {
            this.Nazwisko = NoweNazwisko;
        }
        public void UstawSamochod(Samochód nowySamochod)
        {
            this.Auto = nowySamochod;
        }
        public void JakieAuto()
        {
            Console.WriteLine(this.Imie_i_Nazwisko + "  posiada " + this.Auto.Marka + " " + this.Auto.Model + " " + "rocznik " + this.Auto.RokProdukcji + " przebieg " + this.Auto._Przebieg);
        }
    }

}
