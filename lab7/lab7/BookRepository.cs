using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab7
{
    public class BookRepository : IBookRepository
    {
        private List<Book> Księgozbiór = new List<Book>() { new Book() { Tytuł = "Test", Id = 1 } };

        public void Create(Book item)
        {
            item.Id = Księgozbiór.Count + 1;
            Księgozbiór.Add(item);
        }

        public List<Book> GetAll()
        {
            return Księgozbiór;
        }


        public void Delete(int id)
        {
            Księgozbiór.RemoveAll(x => x.Id == id);
        }

        public Book Get(int id)
        {
            return Księgozbiór.Find(x => x.Id == id);
        }


        public void Update(Book item)
        {
            var index = Księgozbiór.FindIndex(x => x.Id == item.Id);

            if (index > -1)
                Księgozbiór[index] = item;
        }

        public List<Book> PobierzKsiążkiWedługAutora (string autor)
        {
            return Księgozbiór.Where(x => x.Autor == autor).ToList();
        }

        public List<Book> PobierzKsiążkiWedługRokuWydania (int rok)
        {
            return Księgozbiór.Where(x => x.RokWydania == rok).ToList();
        }
    }
}
