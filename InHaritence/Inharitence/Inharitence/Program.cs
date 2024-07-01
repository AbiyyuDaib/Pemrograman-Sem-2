using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitence
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            //person.Name = "Aingmau";
            //person.Age = 10;
            person.GetNameAndAge();

            Teacher teacher = new Teacher("agung", 70);
            //teacher.Name = "agung";
            //teacher.Age = 70;
            //teacher.TeacherId = "123456";
            //teacher.Subject = "MTk Brooo";
            teacher.GetNameAndAge();

            Students students = new Students("Ahsiappp", 200);
            //students.Name = "Asiappppp";
            //students.Age = 101;
            students.GetNameAndAge();

            Console.ReadKey();  
        }
    }
}
