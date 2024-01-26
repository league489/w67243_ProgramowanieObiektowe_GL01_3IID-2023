using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Person : iEntity<int>, InterfejsDaty
    {
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public List<Book> ListaWypożyczonychKsiążek { get; set; }
        public int Id { get; set; }
        public DateTime DataUtworzenia { get; set; }

    }


}
