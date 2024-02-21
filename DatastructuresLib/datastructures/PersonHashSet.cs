using DatastructuresLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.datastructures
{
    public class PersonHashSet : IPersonDatastructure
    {
        private readonly HashSet<Person> _persons;
        public PersonHashSet()
        {
            _persons = new HashSet<Person>();

        }


        public Person Add(Person person)
        {
            _persons.Add(person);
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
