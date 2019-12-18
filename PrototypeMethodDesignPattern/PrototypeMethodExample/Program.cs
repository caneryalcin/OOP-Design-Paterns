using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototypeMethodExample
{
    //Bir tekstil firması var.
    //Bu firma kalıp olarak müşteriler istedikçe t-shirt imal edecektir.
    //T-shirtler kalıp,renk bakımından değişiklik gösterebilecek.
    class Program
    {

        public static void ShallowCopyExample()
        {
            Console.WriteLine("Shallow Kopyalama Örneği");
            Console.WriteLine();

            Ozellikler oz = new Ozellikler() { UrunSayi = 100, UrunBeden = "L-M-S", UrunRenk = "Kırmızı-Mavi" };
            oz.fabrika = new Fabrika() { Marka = "Defacto" };

            Console.WriteLine("oz nesnesi yaratıldıktan sonra:");
            Console.WriteLine();

            Console.WriteLine("Oz:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz.fabrika.Marka, oz.UrunSayi, oz.UrunBeden, oz.UrunRenk);

            Ozellikler oz2 = oz.Clone();//Shallow olarak kopyalandı.
                                        //Shallow kopyalamanın dezavantajı eğer veri referans tipinde ise kopyalandıktan sonra her iki nesnede aynı referans adresini gösterecektir.  
                                        //Bu yüzden referans tipinde kopyalanan veri değiştirilse bile her iki nesne içinde  veri aynı olacaktır.

            Console.WriteLine("oz'u oz2 ye shallow copy yaptıktan sonra:");
            Console.WriteLine();

            oz2.UrunSayi = 300; oz2.UrunBeden = "XL-L-M-S"; oz2.UrunRenk = "Beyaz-Siyah";
            oz2.fabrika.Marka = "Koton";


            Console.WriteLine("E2:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz2.fabrika.Marka, oz2.UrunSayi, oz2.UrunBeden, oz2.UrunRenk);

            Console.WriteLine();

            Console.WriteLine("Değişikliklerden sonra:");

            Console.WriteLine();

            Console.WriteLine("E1:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz.fabrika.Marka, oz.UrunSayi, oz.UrunBeden, oz.UrunRenk);

            Console.WriteLine();

            Console.WriteLine("E2:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz2.fabrika.Marka, oz2.UrunSayi, oz2.UrunBeden, oz2.UrunRenk);
            


        }

        public static void DeepCopyExample()
        {

            Console.WriteLine("Deep Kopyalama Örneği");
            Console.WriteLine();

            Ozellikler oz = new Ozellikler() { UrunSayi = 100, UrunBeden = "L-M-S", UrunRenk = "Kırmızı-Mavi" };
            oz.fabrika = new Fabrika() { Marka = "Defacto" };

            Console.WriteLine("oz nesnesi yaratıldıktan sonra:");
            Console.WriteLine();

            Console.WriteLine("Oz:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz.fabrika.Marka, oz.UrunSayi, oz.UrunBeden, oz.UrunRenk);

            Ozellikler oz2 = oz.DeepCopy();//Deep olarak kopyalandı.
                                           //Deep kopyalamanın avantajı ise kopyalandıktan sonra dışardan gelen referans sadece kopyalanan için kullanılabilir olur.
                                           //Böylece referans karmaşıklığı ortadan kalkar.

            Console.WriteLine("oz'u oz2 ye shallow copy yaptıktan sonra:");
            Console.WriteLine();

            oz2.UrunSayi = 300; oz2.UrunBeden = "XL-L-M-S"; oz2.UrunRenk = "Beyaz-Siyah";
            oz2.fabrika.Marka = "Koton";


            Console.WriteLine("E2:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz2.fabrika.Marka, oz2.UrunSayi, oz2.UrunBeden, oz2.UrunRenk);

            Console.WriteLine();

            Console.WriteLine("Değişikliklerden sonra:");

            Console.WriteLine();

            Console.WriteLine("E1:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz.fabrika.Marka, oz.UrunSayi, oz.UrunBeden, oz.UrunRenk);

            Console.WriteLine();

            Console.WriteLine("E2:\nUrun Marka: {0}\nUrun Sayi: {1}\nUrun Beden: {2}\nUrun Renk: {3}",
               oz2.fabrika.Marka, oz2.UrunSayi, oz2.UrunBeden, oz2.UrunRenk);
            


        }
        static void Main(string[] args)
        {

            ShallowCopyExample();
            Console.WriteLine("\n-----------------------------------------\n");
            DeepCopyExample();
            Console.ReadKey();
        }
    }
}
