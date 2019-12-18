using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
Bir Şirkette yönetici ve bir takım çalışanlar bulunmaktadır.
Yönetici her sene başında çalışanlara aynı gün sayısında izin atayacaktır.
Bu işlemi bir defalık girdi ile herkes için yapmak istiyor.
*/

namespace SingletonExample
{
    class Program
    {
        private static void fonkCagir()
        {

            YazilimUzmani yUzmani = new YazilimUzmani();
            yUzmani.yazilimUzmani();

            Ar_GeUzmani argeUzmani = new Ar_GeUzmani();
            argeUzmani.ar_geUzmani();

        }
        static void Main(string[] args)
        {

            Console.WriteLine("İsim:");
            string isim = Console.ReadLine();

            Console.WriteLine("parola:");
            string parola =  Console.ReadLine();

            if (isim == "Admin" && parola == "singleton")
            {
                Console.WriteLine("Hoşgeldiniz");

            }
            else
            {
                Environment.Exit(0);

            }
            

            İzin izin1 = İzin.Nesne;//Property sayesinde sınıf kurulur.

            Console.WriteLine("Kaç gün izin vermek istiyorsunuz.");

            izin1.İzinSayi = Int32.Parse(Console.ReadLine());

            fonkCagir();

        }
    }
}
