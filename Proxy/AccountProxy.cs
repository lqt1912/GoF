using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public static class LoginSystem
    {
        public static bool Login(string username)
        {
            if (username == "admin")
                return true;
            else return false;
        }
    }
    public class AccountProxy
    {
        string Username;
        Account CurrentAccount;

        public AccountProxy(string username, Account currentAccount)
        {
            Username = username;
            CurrentAccount = currentAccount;
        }

        public void Deposit(int amount)
        {
            if(Login())
            {
                CurrentAccount.Deposit(amount);
            }
            else Console.WriteLine("Login failed !");
           
        }

        public void Withdraw(int amount)
        {
            if(Login())
            {
                CurrentAccount.Withdraw(amount);
            }
            else Console.WriteLine("Login failed! ");
           
        }

        public void CheckBalance()
        {
           if(Login())
            {
                CurrentAccount.CheckBalance();
            }
            else Console.WriteLine("Login failed !");
        }

        bool Login()
        {
            if (LoginSystem.Login(Username))
                return true;
            else return false;
        }
    }
}
