using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "23.11.5809";
            mhs.nama = "Abiyyu Daib Rizqullah";
            mhs.email = "abiyyudaib@students.amikom.ac.id";

            Console.WriteLine("Pilih Menu Konversi di bawah");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv");
            Console.Write("Nomor Format data 1 .... 3 : ");
            int nomor = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert;

            if (nomor == 1 ) 
            {
                convert = new ConvertToJson();
            }
            else if (nomor == 2 ) 
            {
                convert = new ConvertToXml();
            }
            else
            {
                convert = new ConvertToCsv();
            }

            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
