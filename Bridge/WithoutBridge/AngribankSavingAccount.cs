using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bridge.WithoutBridge
{
    public class AngribankSavingAccount : IBank
    {
        SavingAccount savingAccount;
        public AngribankSavingAccount(SavingAccount savingAccount)
        {
            this.savingAccount = savingAccount;
        }

        public void OpenAccount()
        {
            Console.WriteLine("This is Agribank Account. ");
            savingAccount.OpenAccount();
        }
    }
}
