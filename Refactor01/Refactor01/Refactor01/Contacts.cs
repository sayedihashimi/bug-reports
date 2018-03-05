using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor01
{
    public class Contacts
    {
        public IList<Person> Contacts = new List<Person>();

        public Contacts()
        {
            Contacts.Add(new Person());
            Contacts.Add(new Person("name", "street 1"));
        }

        public IList<Person>GetContacts(){
            return Contacts;
        }

        public void AddContact(Person contact){
            Contacts.Add(contact);
        }
    }
}
