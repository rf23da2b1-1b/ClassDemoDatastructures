using DatastructuresLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.datastructures
{
    public interface IPersonDatastructure
    {
        List<Person> GetAll();
        Person GetById(int id);
        Person Add(Person person);
    }
}
