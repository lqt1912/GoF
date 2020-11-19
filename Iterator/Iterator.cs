using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
   public  interface Iterator
    {

        public bool HasNext();
        public Object Next();
    }
}
