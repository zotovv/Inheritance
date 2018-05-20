using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterDerived instance = new PrinterDerived(ConsoleColor.Yellow);
            instance.Print("Hello!");

            Printer instanceUp = instance;
            instanceUp.Print("Hello!");

            PrinterDerived instance2 =  new PrinterDerived(ConsoleColor.Red);
            instance2.Print("Hello!");

            Console.ReadKey();
        }

    }
}
