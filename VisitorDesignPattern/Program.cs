using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {

            AndroidVersion_1 androidVersion_1 = new AndroidVersion_1("Version 1.0");
            AndroidVersion_2 androidVersion_2 = new AndroidVersion_2("Version 2.0");

            androidVersion_1.Controller(new VersionVisitor());
            androidVersion_2.Controller(new VersionVisitor());


            Console.ReadKey();
        }
    }
}
