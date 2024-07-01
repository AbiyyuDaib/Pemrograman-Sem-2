using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("the Animal says");
        }
    }
}
