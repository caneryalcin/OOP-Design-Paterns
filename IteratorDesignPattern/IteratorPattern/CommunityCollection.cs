using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    abstract class ICommunityCollection
    {

       public abstract  ICommunityIterator CreateIterator();

    }

    class CommunityCollecion : ICommunityCollection
    {

        private ArrayList _items = new ArrayList();

        public override ICommunityIterator CreateIterator()
        {

            return new CommunityIterator(this);

        }

        public int Count
        {

            get { return _items.Count; }

        }

        public object this[int index]
        {

            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

}
