using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace abs
{
    public class ConvertToJson : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("Hasil Konversi Ke Json : \n");
            Console.WriteLine(json);
        }
    }
}
