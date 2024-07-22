using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using RestWithASPNETUdemy.Repository.Interfaces;

namespace RestWithASPNETUdemy.Business
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusiness(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        } 

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }        

        public void Delete(long id)
        {
            _repository.Delete(id);

        }

    }
}
