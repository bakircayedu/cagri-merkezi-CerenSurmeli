using System;
using System.Collections.Generic;
using System.Text;

namespace ÖdevBaslangic
{
    public interface IQueue
    {
        public void Insert(object o);
        public void Remove();
        public object Peek();
        public Boolean IsEmpty();
    }
}
