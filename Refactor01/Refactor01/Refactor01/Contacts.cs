using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor01
{
    public class MyOtherClass01
    {
        public IList<Person> Contacts = new List<Person>();

        public MyOtherClass01()
        {
            Contacts.Add(new Person());
            Contacts.Add(new Person("name", "street 1"));
        }
    }
}
