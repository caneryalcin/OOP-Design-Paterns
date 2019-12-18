using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Bir inşaat firması müşteri isteğine göre 1,2 ve 3 katlı yapılar inşaa edecektir.
 Kat sayısına göre yapı özellikleri verilere göre değişecektir.
 */
namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Yapi yapi = null;
            Console.Write("Kaç katlı yapı inşa etmek istiyorsunuz?");
            int katNum = int.Parse(Console.ReadLine());

            switch (katNum)
            {
                case 1:
                    yapi = new TekKatliYapi(70, "Beyaz","Bahçeli");
                    break;
                case 2:
                    yapi = new İkiKatliYapi(80, "Gri","Bahçesiz");
                    break;
                case 3:
                    yapi = new UcKatliYapi(90, "Turuncu","Bahçeli");
                    break;
                default:
                    break;
            }

            YapiOzellik yapiOzellik = yapi.GetYapiOzellik();
            Console.WriteLine("\nYapı özellikleriniz: \n");
            Console.WriteLine("Kat Sayısı: {0}\nMetre Karesi: {1}\nRengi: {2}\nBahçe: {3}",
                yapiOzellik.KatSayisi, yapiOzellik.MetreKare, yapiOzellik.Renk,yapiOzellik.Bahce);
            Console.ReadKey();
        }
    }
}
