using lab5.lab5.z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.lab6
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> Osoby = new List<Person>();

        public void Create(Person item)
        {
            item.Id = Osoby.Count + 1;
            Osoby.Add(item);
        }

        public List<Person> GetAll()
        {
            return Osoby;
        }


        public void Delete(int id)
        {
            Osoby.RemoveAll(x => x.Id == id);
        }

        public Person Get(int id)
        {
            return Osoby.Find(x => x.Id == id);
        }


        public void Update(Person item)
        {
            var index = Osoby.FindIndex(x => x.Id == item.Id);

            if (index > -1)
                Osoby[index] = item;
        }

        public void WypożyczKsiążkę (int id, int KsiążkaId)
        {
            var person = Get(id);
            if (person == null)
                return;


        }

        public List<Book> PobierzWypożyczoneKsiążki (int id)
        {
            return new List<Book>();
        }
    }
}
