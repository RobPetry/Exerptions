using System;
using System.Collections.Generic;
using System.Text;
using Exceptions.Entities.Exceptions;
namespace Exceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new AccountExceptions("The deposit amount must be greater than 0 ");
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount <= 0)
                throw new AccountExceptions("The withdrawal amount must be greater than 0 ");
            if (amount > WithDrawLimit)
                throw new AccountExceptions("The withdrawal limit is "+WithDrawLimit);
            if(amount>Balance)
                throw new AccountExceptions("Insufficients funds");
            Balance -= amount;
        }
    }
}
