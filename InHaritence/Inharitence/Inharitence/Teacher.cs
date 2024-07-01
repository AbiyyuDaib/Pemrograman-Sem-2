using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitence
{
    public class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string name, int age) : base(name, age) 
        {
            Name = name;
            Age = age;
        }
    }
}
