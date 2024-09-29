using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_in_C_.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal balance)
        {
            Deposite(balance);
        }

        public void Deposite(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposite ammount must be positive");
            }

            this.balance += amount;     // balance = balance + amount
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }
            if (amount > balance)
            {
                throw new ArgumentException("insufficient funds");
            }
            this.balance -= amount;

        }
    }
}
