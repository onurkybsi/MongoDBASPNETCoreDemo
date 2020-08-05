using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract.IPersonRepo;
using Entity.Concrete;
namespace Business.Concrete
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAll() => _personRepository.GetList();
    }
}