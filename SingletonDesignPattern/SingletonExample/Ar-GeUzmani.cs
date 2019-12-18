using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SingletonExample
{
    class Ar_GeUzmani
    {
        public void ar_geUzmani()
        {
            İzin izin1 = İzin.Nesne;

            string dosya_yolu = @"./TextFiles/Ar_GeUzmani.txt";
            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file = File.ReadAllLines(dosya_yolu);
            foreach (string line in file)
            {
                if (line.Contains("İzin Günü Sayısı: 20"))
                {
                    temp = line.Replace(
            "İzin Günü Sayısı: 20", "İzin Günü Sayısı: " + izin1.İzinSayi);
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
