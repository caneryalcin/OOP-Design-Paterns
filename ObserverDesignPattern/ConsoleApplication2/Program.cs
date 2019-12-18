using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Program
    {
        public static ConcreteCafe c;
        public static int emptyTable= 13;
        static void Main(string[] args)
        {
            Console.WriteLine("Mevcut Masa: " + emptyTable);

            c = new ConcreteCafe();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Masa boşaldıysa 'Evet',\nMasaya yeni birisi oturduysa 'Doldu' yazın...");
            Console.WriteLine("--------------------------------");

            string yesOrNo = "";
            Console.Write("Cevap:");
            yesOrNo = Console.ReadLine();

            if (yesOrNo == "Evet")
            {
                c.AddTable(new CafeTableObserver());
                c.IsTableChanged = true;
                emptyTable++;
                c.tableCount = emptyTable;
            }
            else if (yesOrNo == "Doldu")
            {

                c.RemoveTable(new CafeTableObserver());
                c.IsTableChanged = true;
                emptyTable--;
                c.tableCount = emptyTable;

            }
            Console.Read();
        }
    }    
}
