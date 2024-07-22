using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository.Interfaces
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        List<Person> FindAll();
        Person FindById(long id);
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
