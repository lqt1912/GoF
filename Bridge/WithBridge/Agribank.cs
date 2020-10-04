using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.WithBridge
{
    public class Agribank : Bank
    {
        public Agribank(IAccountType accountType) : base(accountType)
        {
        }

        public override void OpenAccount()
        {
            Console.WriteLine("This is Agribank account");
            accountType.OpenAccount();
        }
    }
}
