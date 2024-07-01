using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            // membuat objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            // membuat objek List
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambahkan elemen List
            list.Add(mhs1);
            list.Add(mhs2);

            // coba tambahkan objek dosen ke list, apa yang terjadi?
            //list.Add(dosen);
            Console.WriteLine("No.   Nim    Nama");
            Console.WriteLine("=================");

            int nomor = 1;

            foreach (Mahasiswa mhs in list) 
            {
                Console.WriteLine("{0}     {1}   {2}",nomor,  mhs.Nim, mhs.NamaMahasiswa);
                nomor++;
            }
            // mengakses elemen List
           

            Console.ReadKey();
        }
    }
}
