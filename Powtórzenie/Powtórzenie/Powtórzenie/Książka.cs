using System;
using System.Collections.Generic;
using System.Text;

namespace Powtórzenie
{
    public class Książka
    {
        public string Tytuł;
        public string Autor;
        public int RokWydania;
        public static List<Książka> ListaKsiążek = new List<Książka>();

        public Książka(string t, string a, int rw)
        {
            this.Tytuł = t;
            this.Autor = a;
            this.RokWydania = rw;
            ListaKsiążek.Add(this);
        }

        public void DejTytuł()
        {
            Console.WriteLine("Tytuł : " + this.Tytuł);
        }

        public void DejAutora()
        {
            Console.WriteLine("Autor : " + this.Autor);
        }

        public void DejRokWydania()
        {
            Console.WriteLine("Rok wydania : " + this.RokWydania);

        }

        public void DejWszystko()
        {
            Console.WriteLine("Tytuł : " + this.Tytuł);
            Console.WriteLine("Autor : " + this.Autor);
            Console.WriteLine("Rok wydania : " + this.RokWydania);
        }

        public static void KsiążkiWedługAutora(string a)
        {
            foreach (var k in Książka.ListaKsiążek)
            {
                if (k.Autor == a)
                {
                    k.DejWszystko();
                }
            }

        }

        public static void KsiążkiWedługRokuWydania(int r)
        {
            foreach (var k in Książka.ListaKsiążek)
            {
                if (k.RokWydania == r)
                {
                    k.DejWszystko();
                }
            }

        }


        public void UsuńKsiążkę(string t) 
        {
            foreach (var k in Książka.ListaKsiążek)
            {
                if (k.Tytuł == t)
                {
                    Książka.ListaKsiążek.Remove(k);
                }
            }
        }
    }

    

}
