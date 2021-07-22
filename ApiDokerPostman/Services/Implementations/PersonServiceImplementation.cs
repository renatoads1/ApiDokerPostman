using ApiDokerPostman.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDokerPostman.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 10; i++) {
                persons.Add(new Person {
                    Id = i,
                    FirstName = "Renato_"+i.ToString(),
                    LastName = "Azevedo_"+i.ToString(),
                    Address = "Belo Horizonte - Minas Gerais Brasil_"+i.ToString(),
                    Gender = "Male_"+i.ToString()
                });

            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Renato",
                LastName = "Azevedo",
                Address = "Belo Horizonte - Minas Gerais Brasil",
                Gender = "Male"
            };
        }
    }
}
