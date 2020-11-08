using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
   public class Chart : IObserver
    {
        public void UpdateData(string message)
        {
            Console.WriteLine(message);
        }
    }
}
