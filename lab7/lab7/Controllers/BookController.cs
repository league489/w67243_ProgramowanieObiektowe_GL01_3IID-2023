using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab7;


namespace lab7.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public Book Get(int id)
        {
            return _bookRepository.Get(id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }


        [HttpGet]
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        [HttpPost]
        public void Create(Book input)
        {
            _bookRepository.Create(input);
        }

        [HttpPut]
        public void Update(Book input)
        {
            _bookRepository.Update(input);
        }

        [HttpGet]
        public List<Book> PobierzKsiążkiWedługAutora(string autor)
        {
            return _bookRepository.PobierzKsiążkiWedługAutora(autor);
        }

        [HttpGet]
        public List<Book> PobierzKsiążkiWedługRokuWydania(int rok)
        {
            return _bookRepository.PobierzKsiążkiWedługRokuWydania(rok);
        }

    }
}
