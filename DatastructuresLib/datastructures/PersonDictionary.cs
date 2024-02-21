using DatastructuresLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.datastructures
{
    public class PersonDictionary:IPersonDatastructure
    {

        private readonly Dictionary<int, Person> _persons;
        public PersonDictionary()
        {
            _persons = new Dictionary<int, Person>();

        }


        public Person Add(Person person)
        {
            _persons.Add(person.Id, person);
            return person;
        }

        public List<Person> GetAll()
        {
            return new List<Person>(_persons.Values);
        }

        public Person GetById(int id)
        {
            if ( !_persons.ContainsKey(id))
            {
                throw new KeyNotFoundException();
            }

            return _persons[id];
        }
    }
}
