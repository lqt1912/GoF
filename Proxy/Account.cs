using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public interface IAccount
    {
        void Deposit(int amount);
        void Withdraw(int amount);
        void CheckBalance();
    }
    public class Account :IAccount
    {
         int Balance;

        public Account(int balance)
        {
            Balance = balance;
        }

        public void Deposit(int amount)
        {
            this.Balance = this.Balance + amount;
            Console.WriteLine($"Deposit {amount}! ");
        }

        public void Withdraw(int amount)
        {
            this.Balance = this.Balance - amount;
            Console.WriteLine($"Withdraw {amount}! ");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current account's balance is {this.Balance}");
        }
    }
}
