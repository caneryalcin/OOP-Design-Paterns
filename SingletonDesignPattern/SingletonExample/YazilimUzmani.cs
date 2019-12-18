using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SingletonExample
{
    class YazilimUzmani
    {
        public void yazilimUzmani()
        {
            İzin izin2 = İzin.Nesne;

            string dosya_yolu = @"./TextFiles/YazilimUzmani.txt";
            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file = File.ReadAllLines(dosya_yolu);
            foreach (string line in file)
            {
                if (line.Contains("İzin Günü Sayısı: 20"))
                {
                    temp = line.Replace(
            "İzin Günü Sayısı: 20", "İzin Günü Sayısı: " + izin2.İzinSayi);
                    newFile.Append(temp +
            "\r\n");
                    continue;
                }
                newFile.Append(line +
            "\r\n");
            }
            File.WriteAllText(dosya_yolu, newFile.ToString());

        }
    }
}
