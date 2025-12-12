using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6v2
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Person()
        {
            Id = 0;
            Name = string.Empty;
            Phone = string.Empty;
        }
    }

}
