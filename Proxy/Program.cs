using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProxy accountProxy = new AccountProxy("admin", new Account(100));
            accountProxy.Deposit(10);
            accountProxy.CheckBalance();

            Console.WriteLine();
            AccountProxy acc = new AccountProxy("admifsadfscf", new Account(100));
            acc.CheckBalance();
        }
    }
}
