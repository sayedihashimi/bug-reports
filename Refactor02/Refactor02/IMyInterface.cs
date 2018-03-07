using System;
namespace Refactor02
{
    public interface IMyInterface{
        void UpdatePerson(Person p, string name, string street1);
        Person GetPersonByName(string name);
    }
}
