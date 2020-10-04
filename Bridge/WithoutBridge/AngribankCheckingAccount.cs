using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bridge.WithoutBridge
{
    public class AngribankCheckingAccount : IBank
    {
        CheckingAccount checkingAccount;

        public AngribankCheckingAccount(CheckingAccount checkingAccount)
        {
            this.checkingAccount = checkingAccount;
        }

        public void OpenAccount()
        {
            Console.WriteLine("This is Agribank Account. ");
            checkingAccount.OpenAccount();
        }
    }
}
