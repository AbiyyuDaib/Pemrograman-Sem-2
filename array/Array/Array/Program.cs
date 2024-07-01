using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arrNama = { "erric", "wely", "Sony", "Joni" };

            Console.WriteLine(arrNama[2].ToString() + "\n");

            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine(arrNama[i]);
            }
            Console.WriteLine();

            foreach(string nama in arrNama)
            {
                Console.WriteLine(nama);
            }
            Console.WriteLine();

            int[] arrBil = new int[3];

            arrBil[0] = 12;
            arrBil[1] = 14;
            arrBil[2] = 24;

            foreach(int bil in arrBil)
            {
                Console.WriteLine(bil.ToString());
            }

            Console.ReadKey ();
        }
    }
}
