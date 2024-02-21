using DatastructuresLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.datastructures
{
    public class PersonStack : IPersonDatastructure
    {
        private readonly Stack<Person> _persons;
        public PersonStack()
        {
            _persons = new Stack<Person>();

        }


        public Person Add(Person person)
        {
            _persons.Push(person);
            return person;
        }

        public List<Person> GetAll()
        {
            return new List<Person>(_persons);
        }

        public Person GetById(int id)
        {
            try
            {
                Person? fundetPerson = _persons.First(p => p.Id == id);
                return fundetPerson;
            }
            catch (InvalidOperationException ioe)
            {
                throw new KeyNotFoundException();
            }
        }

    }
}
