using APICrud.iServices;
using APICrud.Models;

namespace APICrud.Service
{
    public class PersonService : iGenericService<Person>
    {
        List<Person> _persons = new List<Person>();

        public PersonService() 
        {
            for (int i = 1; i <= 5; i++)
            {
                _persons.Add(new Person()
                {
                    Id = i,
                    FirstName = "Rashmi" + i,
                    LastName = "Amarasinghe" + i,
                    Email = "rhamarasinghe@gmail.com" + i
                }); ;
            }
        }

        public List<Person> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            return _persons.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Person> GetAll()
        {
            return _persons;
        }

        public List<Person> Insert(Person item)
        {
            throw new NotImplementedException();
            // _persons.Add(item); 
            // return _persons;
        }
    }
}
