using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.WithBridge
{
    public abstract class Bank
    {
        protected IAccountType accountType;

        public Bank(IAccountType accountType)
        {
            this.accountType = accountType;
        }

        public abstract void OpenAccount();
    }
}
