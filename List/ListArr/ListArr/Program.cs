using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArr
{
    public class Program
    {
        static void Main(string[] args)
        {
            // membuat objek list untuk menampung tipe data integer
            List<int> listNilai = new List<int>();

            // menambahkan elemen list
            listNilai.Add(70);
            listNilai.Add(100);
            listNilai.Add(85);

            // mengakses elemen list
            int nilaiElement1 = listNilai[1];

            Console.WriteLine(nilaiElement1);
            Console.WriteLine();

            // menampilkan semua elemen dalam list
            foreach (int nilai in listNilai)
            {
                Console.WriteLine(nilai);
            }

            Console.ReadKey();
        }
    }
}
