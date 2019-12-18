using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {

            Button button = new Button();
            button.Do();
            button.Do();
            button.Do();
            Console.ReadKey();
        }
    }
}
