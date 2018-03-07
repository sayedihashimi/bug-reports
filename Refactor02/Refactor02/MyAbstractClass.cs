using System;
namespace Refactor02
{
    public abstract class MyAbstractClass
    {
        public abstract void UpdatePerson(Person p, string name, string street1);
        public abstract Person GetPersonByname(string name);
    }
}
