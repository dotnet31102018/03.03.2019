using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303Lists
{
    class MyMobileStack
    {
        private List<Mobile> _mobiles = new List<Mobile>();
        public MyMobileStack()
        {

        }

        public Mobile Pop()
        {
            if (_mobiles.Count > 0)
            {
                Mobile result = _mobiles[0];
                _mobiles.RemoveAt(0);
                return result;
            }
            return null;
        }

        public void Push(Mobile mobile)
        {
            _mobiles.Insert(0, mobile);
        }

        public int Size
        {
            get
            {
                return _mobiles.Count;
            }
        }

        public void Clear()
        {
            _mobiles.Clear();
        }

        public void Init(List<Mobile> newList)
        {
            this._mobiles = newList;
        }

        public void Sort()
        {
            this._mobiles.Sort();
        }

        public Mobile Peep()
        {
            return _mobiles[0];
        }
    }
}
