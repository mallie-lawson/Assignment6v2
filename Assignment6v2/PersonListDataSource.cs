using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6v2
{
    internal class PersonListDataSource : IPersonDataSource
    {
        private readonly List<Person> _people;

        public PersonListDataSource()
        {
            _people = new List<Person>();

            _people.Add(new Person { Id = 1, Name = "Alice Johnson", Phone = "555-1234" });
        }

        public IEnumerable<Person> GetPeople()
        {
            return _people.ToList();
        }

        public IEnumerable<Person> GetPeople(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                return GetPeople();
            }
            return _people.Where(p => p.Name.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        public void DeletePerson(Person person)
        {
            _people.Remove(person);
        }


        public void SaveChanges()
        {

        }
    }
}
