using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab5.z3
{
    public interface IBookRepository : IBaseRepository<Book,int>
    {
        List<Book> PobierzKsiążkiWedługAutora(string autor);
        List<Book> PobierzKsiążkiWedługRokuWydania(int rok);
    }
}
