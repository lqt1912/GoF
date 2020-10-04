using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bridge.WithoutBridge
{
    public class TPBankCheckingAccount : IBank
    {
        CheckingAccount checkingAccount;

        public TPBankCheckingAccount(CheckingAccount checkingAccount)
        {
            this.checkingAccount = checkingAccount;
        }

        public void OpenAccount()
        {
            Console.WriteLine("This is TPBank Account. ");
            checkingAccount.OpenAccount();
        }
    }
}
