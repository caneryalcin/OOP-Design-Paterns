using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templetedesignpattern
{
    abstract class I3BPrinter
    {

        public void StartPrinter()
        {

            Console.WriteLine("Printer is started");

        }


        public abstract void PrintObject();

        public void ClosePrinter()
        {

            Console.WriteLine("Printer is closed");

        }

        public void WriteSummary()
        {

            StartPrinter();
            PrintObject();
            ClosePrinter();

        }

    }

    class Concrete3BPikachu : I3BPrinter
    {

        public override void PrintObject()
        {
            Console.WriteLine("3B printer is printing Pikachu");
        }

    }

    class Concrete3BBalbazar : I3BPrinter
    {

        public override void PrintObject()
        {
            Console.WriteLine("3B printer is printing Balbazar");
        }

    }
    class Concrete3BSquirtle : I3BPrinter
    {

        public override void PrintObject()
        {
            Console.WriteLine("3B printer is printing Squirtle");
        }

    }

}
