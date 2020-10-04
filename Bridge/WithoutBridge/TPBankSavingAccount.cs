using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bridge.WithoutBridge
{
    public class TPBankSavingAccount : IBank
    {
        SavingAccount savingAccount;

        public TPBankSavingAccount(SavingAccount savingAccount)
        {
            this.savingAccount = savingAccount;
        }

        public void OpenAccount()
        {
            Console.WriteLine("This is TPBank Account. ");
            savingAccount.OpenAccount();
        }
    }
}
