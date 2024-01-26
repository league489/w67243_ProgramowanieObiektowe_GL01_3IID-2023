
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab7;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lab7.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        [HttpPost]
        public void WypożyczKsiążkę(int id, int bookId)
        {
            _personRepository.WypożyczKsiążkę(id, bookId);
        }

        [HttpGet]
        public List<Book> PobierzWypożyczoneKsiążki(int id)
        {
            return _personRepository.PobierzWypożyczoneKsiążki(id);
        }

        [HttpGet]
        public Person Get(int id)
        {
            return _personRepository.Get(id);
        }

        [HttpPost]
        public void Create(Person person)
        {
            _personRepository.Create(person);
        }

        [HttpPut]
        public void Update(Person person)
        {
            _personRepository.Update(person);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }
    }
}
