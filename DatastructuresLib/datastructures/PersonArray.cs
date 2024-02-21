using DatastructuresLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.datastructures
{
    public class PersonArray : IPersonDatastructure
    {
        private const int MaxPersoner = 100;
        private readonly Person[] _persons;
        private int nextFree = 0;

        public PersonArray()
        {
            _persons = new Person[MaxPersoner];

        }


        public Person Add(Person person)
        {
            if(nextFree >= MaxPersoner)
            {
                throw new ArgumentException("Too manny persons");
            }
            _persons[nextFree++] = person;
            return person;
        }

        public List<Person> GetAll()
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < nextFree; i++)
            {
                list.Add(_persons[i]);
            }

            return list;
        }

        public Person GetById(int id)
        {
            for (int i = 0; i < nextFree; i++)
            {
                if (_persons[i].Id == id)
                {
                    return _persons[i];
                }
            }

            throw new KeyNotFoundException();
        }
    }
}
