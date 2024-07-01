using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Inharitence
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("The Person Has Name : {0} and Age : {1}", Name, Age);
        }
    }
}
