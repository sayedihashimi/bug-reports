using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor02
{
    public class ContactsManager
    {
        IList<Contacts> contactsList = new List<Contacts>();

        public ContactsManager()
        {
            contactsList[0].AddContact(new Person());
            contactsList[1].AddContact(new Person("name here", "street 1 here"));
        }

        public IList<Contacts> GetContactLists()
        {
            return contactsList;
        }


    }
}
