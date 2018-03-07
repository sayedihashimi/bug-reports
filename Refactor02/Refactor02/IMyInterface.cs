using System;
namespace Refactor02
{
    public interface IMyInterface{
        void UpdatePerson(Person p, string name, string street1);
        Person GetPersonByName(string name);
    }
    public class MyImpl : IMyInterface
    {
        public Person GetPersonByName(string name)
        {
            var foo1 = new Random().Next();
            var foo2 = new Random().Next();
            var foo3 = new Random().Next();
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person p, string name, string street1)
        {
            throw new NotImplementedException();
        }
    }
}
