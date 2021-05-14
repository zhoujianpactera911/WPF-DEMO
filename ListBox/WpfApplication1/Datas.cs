using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Datas : List<Person>
    {
        public Datas()
        {
            Add(new Person("Peter"));
            Add(new Person("Jack"));
            Add(new Person("Joe"));
            Add(new Person("Henry"));
            Add(new Person("Mike"));
        }
    }
}
