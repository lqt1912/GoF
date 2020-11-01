using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Account
    {
         int Balance;
        int Username;

        public Account(int balance)
        {
            Balance = balance;
        }

        public void Deposit(int amount)
        {
            this.Balance = this.Balance + amount;
        }

        public void Withdraw(int amount)
        {
            this.Balance = this.Balance - amount;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current {this.Username} account's balance is {this.Balance}");
        }
    }
}
