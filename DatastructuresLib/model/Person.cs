using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresLib.model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person():this(-1,"")
        {
        }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
