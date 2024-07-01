﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs
{
    public class ConvertToCsv : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            string csv = string.Format("{0}, {1}, {2}", mhs.npm, mhs.nama, mhs.email);

            Console.WriteLine("hasil Konversi ke CSV : \n");
            Console.WriteLine(csv);
        }
    }
}
