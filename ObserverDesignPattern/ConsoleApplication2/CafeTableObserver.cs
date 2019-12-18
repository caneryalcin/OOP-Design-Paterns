using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract public class Observer
    {
        public abstract void Update();
    }
    public class CafeTableObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Masa durumu değişti...");
        }
    }
}
