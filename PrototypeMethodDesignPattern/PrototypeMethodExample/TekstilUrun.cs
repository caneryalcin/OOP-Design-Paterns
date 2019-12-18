using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PrototypeMethodExample
{

    [Serializable]
    public abstract class TekstilUrun<Urun>
    {
        //Shallow kopyalama
        public Urun Clone()//Basit bir kopyalama fonksiyonudur.
                           //Dışardan referans alınması durumunda kopyalanan ve kopyalan içinde aynı referans kullanılır.
        {

            return (Urun)(this.MemberwiseClone());

        }

        //Deep kopylama
        public Urun DeepCopy()//Dışardan referans alınması durumunda referans sadece kopyalana yada sadece kopyalayan için kullanılabilir.
        {
            //Kullanılmak istenen veri serileştirilerek bir yerde saklanır ve deserialization yapılarak ihtiyaç zamanında okunur.
            MemoryStream stream = new MemoryStream();//İçeriği bellekte saklar.
            BinaryFormatter formatter = new BinaryFormatter();//Serialize edilebilen bir nesneyi byte çevirir.
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            Urun copy = (Urun)formatter.Deserialize(stream);
            stream.Close();
            return copy;

        }

    }
    [Serializable]
    public class Fabrika
    {

        public string Marka { get; set; }//Dışarıdan gönderilecek referans

    }

    [Serializable]
    public class Ozellikler : TekstilUrun<Ozellikler>//TekstilUrun sınıfından Ozellikler sınıfı oluşturulur.
    {                                                // Ozellik tanımlamalarının yapıldığı sınıf.

        public int UrunSayi { get; set; }
        public string UrunBeden { get; set; }
        public string UrunRenk { get; set; }

        public Fabrika fabrika { get; set; }


    }
}
