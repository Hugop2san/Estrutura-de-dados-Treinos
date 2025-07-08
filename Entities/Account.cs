using System;

namespace Treino.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; } = string.Empty;
        public double Balance { get; set; }
        public double WithdrawLimit { get; private set ; } 

        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = 1000.00;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive!");
            }
            else
            {
                Balance += amount;
            }

        }
        public void Withdraw(double amount)
        {
            if (amount <=0)
            { throw new ArgumentException("withdraw amount positive and cant be negative and ZERO."); }
            if (amount > WithdrawLimit)
            {  throw new ArgumentException("withdraw amount must be in Withdraw Limit");  }
            if (amount > Balance && amount < WithdrawLimit)
            { throw new ArgumentException("You dont have enough balance to withdraw this amount"); }

            Balance -= amount;
        }




    }
}