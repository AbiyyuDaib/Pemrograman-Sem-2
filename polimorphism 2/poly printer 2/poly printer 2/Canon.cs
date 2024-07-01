using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_printer_2
{
    public class Canon : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("Printer Cannon Sedang mencetak...");
        }

        public void Show()
        {
            Console.WriteLine("Cannon dimesi: 9.5*12");
          
        }
    }
}
