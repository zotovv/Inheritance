using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPrinter
{
    class PrinterDerived : Printer
    {
        public PrinterDerived(ConsoleColor color)
        : base(color)
        {
        
        }
    }
}
