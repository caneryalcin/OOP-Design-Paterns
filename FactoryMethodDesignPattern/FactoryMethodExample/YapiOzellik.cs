using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    abstract class YapiOzellik //Tüm diğer sınıflar için ortak olan özellikler tanımlandı.
    {
        public abstract int KatSayisi { get; }
        public abstract int MetreKare {get; set;}
        public abstract string Renk { get; set ;}
        public abstract string Bahce { get; set; }

        
    }

    class TekKatliYapiOzellik : YapiOzellik
    {
        //global değişkenler
        private int _katSayisi;
        private int _metreKare;
        private string _Renk;
        private string _Bahce;

        public TekKatliYapiOzellik(int metreKare, string renk,string bahce)//constractor
        {
            //local değişkenler
            _katSayisi = 1;
            _metreKare = metreKare;
            _Renk = renk;
            _Bahce = bahce;
        }

        public override int KatSayisi
        {

            get { return _katSayisi;  }

        }

        public override int MetreKare
        {

            get { return _metreKare; }
            set { _metreKare = value; }

        }

        public override string Renk
        {
            get { return _Renk; }
            set { _Renk = value; }
        }
        public override string Bahce
        {
            get { return _Bahce; }
            set { _Bahce = value; }

        }

    }

    class İkiKatliYapiOzellik : YapiOzellik
    {

        private int _katSayisi;
        private int _metreKare;
        private string _Renk;
        private string _Bahce;


        public İkiKatliYapiOzellik(int metreKare, string renk, string bahce)//constractor
        {

            _katSayisi = 2;
            _metreKare = metreKare;
            _Renk = renk;
            _Bahce = bahce;
        }

        public override int KatSayisi
        {
            get { return _katSayisi; }
        }
        public override int MetreKare
        {

            get { return _metreKare; }
            set { _metreKare = value; }

        }

        public override string Renk
        {
            get { return _Renk; }
            set { _Renk = value; }
        }
        public override string Bahce
        {
            get { return _Bahce; }
            set { _Bahce = value; }

        }
    }

    class UcKatliYapiOzellik : YapiOzellik
    {

         private int _katSayisi;
        private int _metreKare;
        private string _Renk;
        private string _Bahce;


        public UcKatliYapiOzellik(int metreKare, string renk, string bahce)
        {

            _katSayisi = 3;
            _metreKare = metreKare;
            _Renk = renk;
            _Bahce = bahce;
        }

        public override int KatSayisi
        {
            get { return _katSayisi; }
        }
        public override int MetreKare
        {

            get { return _metreKare; }
            set { _metreKare = value; }

        }

        public override string Renk
        {
            get { return _Renk; }
            set { _Renk = value; }
        }
        public override string Bahce
        {
            get { return _Bahce; }
            set { _Bahce = value; }

        }
    }

    abstract class Yapi
    {

        public abstract YapiOzellik GetYapiOzellik();//Tercihe göre sınıfları dönderen fonksiyon

    }

    class TekKatliYapi : Yapi
    {

        private int _metreKare;
        private string _Renk;
        private string _Bahce;

        public TekKatliYapi(int metreKare, string renk,string bahce)
        {

            _metreKare = metreKare;
            _Renk = renk;
            _Bahce = bahce;

        }

        public override YapiOzellik GetYapiOzellik()
        {
            return new TekKatliYapiOzellik(_metreKare, _Renk,_Bahce);//İstenilen sınıfı çağırır.
        }
    }
    class İkiKatliYapi : Yapi
    {

        private int _metreKare;
        private string _Renk;
        private string _Bahce;


        public İkiKatliYapi(int metreKare, string renk,string bahce)
        {

            _metreKare = metreKare;
            _Renk = renk;
            _Bahce = bahce;

        }

        public override YapiOzellik GetYapiOzellik()
        {
            return new İkiKatliYapiOzellik(_metreKare, _Renk,_Bahce);
        }

    }
    class UcKatliYapi : Yapi
    {

        private int _metreKare;
        private string _Renk;
        private string _Bahce;


        public UcKatliYapi(int metreKare, string renk,string bahce)
        {

            _metreKare = metreKare;
            _Renk = renk;
            _Bahce = bahce;

        }

        public override YapiOzellik GetYapiOzellik()
        {
            return new UcKatliYapiOzellik(_metreKare, _Renk,_Bahce);
        }
    }


}
