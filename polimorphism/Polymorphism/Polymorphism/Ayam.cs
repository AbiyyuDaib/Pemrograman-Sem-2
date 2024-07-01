using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Ayam : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Ayam berbunyi : KUKURUYUKKKK");
        }
    }
}
