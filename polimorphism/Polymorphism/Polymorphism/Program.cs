using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Kucing cat = new Kucing();
            animal = cat;
            //cat.Speak();
            animal.Speak();

            Ayam chicken = new Ayam();
            animal = chicken;
            //chicken.Speak();
            animal.Speak();

            Anjing dog = new Anjing();
            animal = dog;
            //dog.Speak();
            animal.Speak();

            Console.ReadKey();
        }
    }
}
