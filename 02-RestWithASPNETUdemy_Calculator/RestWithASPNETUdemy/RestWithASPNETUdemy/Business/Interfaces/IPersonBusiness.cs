using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Interfaces
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        List<Person> FindAll();
        Person FindById(long id);
        Person Update(Person person);
        void Delete(long id);        
    }
}
