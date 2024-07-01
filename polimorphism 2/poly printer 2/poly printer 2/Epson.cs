using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_printer_2
{
    public class Epson : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("Printer Epson Sedang mencetak...");
        }

        public void Show()
        {
            Console.WriteLine("Laser jet dimesi: 10*11");
        }
    }
}
