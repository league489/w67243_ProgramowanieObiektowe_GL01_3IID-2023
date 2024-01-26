using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public interface IPersonRepository: IBaseRepository<Person, int>
    {
        List<Book> PobierzWypożyczoneKsiążki(int id);
        void WypożyczKsiążkę(int id, int KsiążkaId);
    }
}
