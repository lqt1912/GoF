using Bridge.WithBridge;
using Bridge.WithoutBridge;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //IBank bank1 = new AngribankSavingAccount(new WithoutBridge.SavingAccount());
            //IBank bank2 = new TPBankCheckingAccount(new WithoutBridge.CheckingAccount());
            //bank1.OpenAccount();
            //bank2.OpenAccount();

            Console.WriteLine();
            Bank bank3 = new Agribank(new WithBridge.SavingAccount());
            Bank bank4 = new TPBank(new WithBridge.CheckingAccount());
            bank3.OpenAccount();
            bank4.OpenAccount();

        }
    }
}
