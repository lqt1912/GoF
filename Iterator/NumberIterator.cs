using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class NumberIterator : Iterator
    {
        int index;
        List<Object> Items;

        public NumberIterator()
        {
            Items = new List<object>();
            for( int i =0; i <10; i++)
            {
                Items.Add(new Random().Next(10, 100)); 
            }
        }
        public bool HasNext()
        {
           if(index <Items.Count)
            {
                return true;
            }
            return false;
        }

        public object Next()
        {
            if (this.HasNext())
            {
                return Items[index++];
            }
            else return null;
        }
    }
}
