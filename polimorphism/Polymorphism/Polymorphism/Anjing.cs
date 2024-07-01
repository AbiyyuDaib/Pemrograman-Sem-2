using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Anjing : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("ANjing berbunyi : GUK - Guk");
        }
    }
}
