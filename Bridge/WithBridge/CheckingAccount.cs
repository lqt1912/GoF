using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.WithBridge
{
    public class CheckingAccount: IAccountType
    {
        public void OpenAccount()
        {
            Console.WriteLine("This is checking account");
        }
    }
}
