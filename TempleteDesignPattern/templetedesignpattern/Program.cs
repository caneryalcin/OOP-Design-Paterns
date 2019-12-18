using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templetedesignpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            I3BPrinter printer = null;

            printer = new Concrete3BPikachu();
            printer.WriteSummary();
            Console.WriteLine();

            printer = new Concrete3BBalbazar();
            printer.WriteSummary();
            Console.WriteLine();

            printer = new Concrete3BSquirtle();
            printer.WriteSummary();
            Console.ReadKey();
        }
    }
}
