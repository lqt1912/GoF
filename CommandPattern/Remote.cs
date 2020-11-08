using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Remote
    {
        List<RemoteFunction> remoteFunctions = new List<RemoteFunction>();

        public void AddFunction(RemoteFunction remoteFunction)
        {
            remoteFunctions.Add(remoteFunction);
        }

        public void Excute()
        {
            foreach (var item in remoteFunctions)
            {
                item.ExcuteCommand();
                Console.WriteLine();
            }
        }
    }
}
