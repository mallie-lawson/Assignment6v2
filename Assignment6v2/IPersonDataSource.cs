using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6v2
{
    public interface IPersonDataSource
    {
        IEnumerable<Person> GetPeople();
        IEnumerable<Person> GetPeople(string filter);
        void AddPerson(Person person);
        void DeletePerson(Person person);
        void SaveChanges();
    }
}
