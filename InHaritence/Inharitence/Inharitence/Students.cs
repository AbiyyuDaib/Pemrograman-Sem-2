using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitence
{
    public class Students : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set;}
        public Students(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }


    }
}
