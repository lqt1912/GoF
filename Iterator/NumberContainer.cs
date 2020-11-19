using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class NumberContainer : IContainer
    {
        public Iterator GetIterator()
        {
            return new NumberIterator();
        }
    }
}
