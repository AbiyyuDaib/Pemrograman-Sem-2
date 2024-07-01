using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatArr
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat array untuk menampung objek Mahasiswa
            Mahasiswa[] arrMahasiswa = new Mahasiswa[3];

            // Mengisi data mahasiswa
            arrMahasiswa[0] = new Mahasiswa { No = 1, Nim = "1234", Nama = "Erik", Nilai = 75 };
            arrMahasiswa[1] = new Mahasiswa { No = 2, Nim = "1235", Nama = "Wely", Nilai = 80 };
            arrMahasiswa[2] = new Mahasiswa { No = 3, Nim = "1236", Nama = "Sony", Nilai = 95 };

            // Menampilkan header tabel
            Console.WriteLine("No.   Nim    Nama   Nilai");
            Console.WriteLine("===========================");

            // Menampilkan data mahasiswa dalam format tabel
            foreach (var mhs in arrMahasiswa)
            {
                Console.WriteLine("{0}     {1}    {2}     {3}", mhs.No, mhs.Nim, mhs.Nama, mhs.Nilai);
            }

            Console.ReadKey();
        }
    }
}
     
