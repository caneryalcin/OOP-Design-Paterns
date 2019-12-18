using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Community
    {
        private string _name;
        private string _surname;
        private int _age;

        public Community(string name,string surname,int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            ToString();
        }

        public override string ToString()
        {
            return "Adı: " + Name + " Soyadı:" + Surname + " Yaşı: " + Age;
        }
        public string Name
        {

            get { return _name; }

        }

        public string Surname
        {

            get { return _surname; }

        }
        public int Age
        {
            get { return _age; }
        }
    }
}
