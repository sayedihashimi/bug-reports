using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor01
{
    public class Contacts
    {
        public IList<Person> contacts = new List<Person>();

        public Contacts()
        {
            contacts.Add(new Person());
            contacts.Add(new Person("name", "street 1"));
        }

        public IList<Person>GetContacts(){
            return contacts;
        }

        public void AddContact(Person contact){
            contacts.Add(contact);
        }
    }
}
