using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Refactor02
{
    public class Contacts
    {
        public IList<Person> contacts = new List<Person>();

        public Contacts()
        {
            contacts.Add(new Person());
            contacts.Add(new Person("name", "street 1"));
        }

        public IList<Person> GetContacts()
        {
            return contacts;
        }

        public void AddContact(Person contact)
        {
            contacts.Add(contact);
        }

        public IEnumerable<string>GetAllNames(){
            return from p in contacts
                   select p.Name;
        }
        public void Update(Person contact, string name, string street1)
        {
            contact.Update(name, street1);
        }
    }
    public class MyClass01
    {
        public int MyProperty { get; set; }
        public int MyProp2 { get; set; }
    }
}
