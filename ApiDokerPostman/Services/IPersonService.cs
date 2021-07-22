using ApiDokerPostman.Model;
using System.Collections.Generic;

namespace ApiDokerPostman.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        void Delete(long id);

    }
}
