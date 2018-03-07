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
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person p, string name, string street1)
        {
            throw new NotImplementedException();
        }
    }
}
