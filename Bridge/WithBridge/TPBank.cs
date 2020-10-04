using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.WithBridge
{
    public class TPBank : Bank
    {
        public TPBank(IAccountType accountType) : base(accountType)
        {
        }

        public override void OpenAccount()
        {
            Console.WriteLine("This is TPbank account");
            accountType.OpenAccount();
        }
    }
}
