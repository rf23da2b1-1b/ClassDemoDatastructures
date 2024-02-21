using DatastructuresLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.datastructures
{
    public class PersonQueue : IPersonDatastructure
    {
        private readonly Queue<Person> _persons;
        public PersonQueue()
        {
            _persons = new Queue<Person>();

        }


        public Person Add(Person person)
        {
            _persons.Enqueue(person);
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
