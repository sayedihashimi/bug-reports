using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor02
{
    public class Person
    {
        public string Name
        {
            get; set;
        }
        public string Street1
        {
            get; set;
        }
        private string Lastname;
        public Person()
        {
            Lastname = "";
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

        public string GetLowerCaseStreet1()
        {
            if (Street1 == null)
            {
                return null;
            }
            return Street1.ToLowerInvariant();
        }
        public string GetLastName()
        {
            return Lastname;
        }
        public (string, string) GetNameAndStreet1()
        {
            return (Name, Street1);
        }
        internal void Update(string name, string street1)
        {
            Name = name;
            Street1 = street1;
        }
    }
}
