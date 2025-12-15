using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6v2
{
    internal class PersonContextDataSource : IPersonDataSource
    {
        private readonly PersonContext _context;

        public PersonContextDataSource()
        {
            _context = new PersonContext();
            _context.Database.EnsureCreated();
            _context.Persons.Load();

        }

        public void AddPerson(Person person)
        {
            _context.Persons.Add(person);
        }

        public void DeletePerson(Person person)
        {
            _context.Persons.Remove(person);
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.Persons.Local.ToList();
        }

        public IEnumerable<Person> GetPeople(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                return GetPeople();
            }

            return _context.Persons.Local.Where(p => (p.Name ?? string.Empty).Contains(filter, StringComparison.OrdinalIgnoreCase));
        }

        public void SaveChanges()
        {
            _context.ChangeTracker.DetectChanges();
            _context.SaveChanges();
        }
    }
}
