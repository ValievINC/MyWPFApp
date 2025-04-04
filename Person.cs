using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
