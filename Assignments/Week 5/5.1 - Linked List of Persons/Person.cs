using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1___Linked_List_of_Persons
{
    class Person
    {
        public string Name { get; set; }
        public Person Next { get; set; }
        
        public Person(string name)
        {
            Name = name;
            Next = null;
        }
    }
}
