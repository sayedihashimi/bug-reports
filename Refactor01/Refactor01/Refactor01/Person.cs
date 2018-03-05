using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor01
{
    public class Person
    {
        public string Name {
            get;set;
        }
        public string Street1 {
            get;set;
        }
        public Person()
        {
        }
        public Person(string name, string street1)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            Name = name;
            Street1 = street1;
        }
    }
}
