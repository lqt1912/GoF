using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.WithBridge
{
    public class SavingAccount: IAccountType
    {
        public void OpenAccount()
        {
            Console.WriteLine("This is Saving account");
        }
    }
}
