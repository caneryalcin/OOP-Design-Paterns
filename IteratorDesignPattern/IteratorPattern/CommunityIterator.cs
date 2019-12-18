using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    abstract class ICommunityIterator
    {

        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentPosition();

    }

    class CommunityIterator : ICommunityIterator
    {

        private CommunityCollecion _community;
        private int _position = 0;
        


        public CommunityIterator(CommunityCollecion community)
        {

            this._community = community;

        }

        public override object First()
        {

            return _community[_position];

        }


        public override object Next()
        {
            object _next = null;
            if (_position < _community.Count - 1)
            {
                _next = _community[++_position];
            }

            return _next;

        }

        public override object CurrentPosition()
        {

            return _community[_position];
        }

        public override bool IsDone()
        {

            return _position >= _community.Count;

        }
    }
}
