using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z3
{
    public class Book : iEntity<int>, InterfejsDaty
    {
        public int Id { get; set; }
        public string Tytuł { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public DateTime DataUtworzenia { get; set; }

    }
}
