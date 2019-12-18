using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Cafe
    {

        public abstract void AddTable(Observer observer);
        public abstract void RemoveTable(Observer observer);
        public abstract void Notify();

    }
    class ConcreteCafe : Cafe
    {
        public int _tableCount;
        public int tableCount
        {

            get { return _tableCount; }
            set
            {
                _tableCount = value;
                Console.WriteLine("Masa Sayısı: " + _tableCount);
            }

        }
        bool isspaceChanged;
        public bool IsTableChanged
        {

            get
            {

                return isspaceChanged;

            }

            set
            {

                if (value == true)
                {

                    Notify();
                    isspaceChanged = value;
                }
                else
                {

                    isspaceChanged = value;

                }

            }

        }

        public ConcreteCafe()
        {

            this.observ = new List<Observer>();


        }

        public override void AddTable(Observer observer)
        {
            observ.Add(observer);


        }
        public override void RemoveTable(Observer observer)
        {

            observ.Remove(observer);

        }

        public override void Notify()
        {
            observ.ForEach(x => { x.Update(); });
        }
        List<Observer> observ;

    }
}
