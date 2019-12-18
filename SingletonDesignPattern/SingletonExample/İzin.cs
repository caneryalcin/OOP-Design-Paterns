using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class İzin
    {
        static İzin atama_İzin;//Static ifadeler sınıf kurulmadan çalıştırılabildiğinden dolayı static tanımlandı.
        public static İzin Nesne//Kurulan sınıfa dışardan erişilebilmek için kullanılan property'dir.
        {

            get { return İzin.atama_İzin; }

        }
        static İzin()//Programın bir 
        {

            atama_İzin = new İzin();//Oluşturduğumuz static atama_İzin'i atayarak sınıfı burada kurulur.
                                    //Static constractorlar sadece sınıf kurulduğunda çalışır ve ikinci bir kurulumda çalışmaz.
                                    //Dışardan erişilemez olarak ayarlandı.
        }

        int izinSayi;
        
        public int İzinSayi
        {

            get { return izinSayi; }
            set { izinSayi = value; }

        }

        
    }
}
