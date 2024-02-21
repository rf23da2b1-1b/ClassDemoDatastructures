using DatastructuresLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.datastructures
{
    public class PersonList : IPersonDatastructure
    {
        private readonly List<Person> _persons;
        public PersonList() 
        {
            _persons = new List<Person>();

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
            Person? fundetPerson = _persons.Find(p => p.Id == id);
            if (fundetPerson == null)
            {
                throw new KeyNotFoundException();
            }

            return fundetPerson;
        }
    }
}
