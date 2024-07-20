using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Interfaces
{
    public interface IPersonService
    {
        Person Create(Person person);
        List<Person> FindAll();
        Person FindById(long id);
        Person Update(Person person);
        void Delete(long id);        
    }
}
