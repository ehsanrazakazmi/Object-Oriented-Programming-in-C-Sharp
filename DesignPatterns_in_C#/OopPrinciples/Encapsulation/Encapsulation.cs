/*
using DesignPatterns_in_C_.OopPrinciples.Encapsulation;

BadBankAccount badAccount = new BadBankAccount();       // here badAccount is an object of class

badAccount.balance = 100;       // this object can read the properties of his class

Console.WriteLine(badAccount.balance);
*/

using System;

namespace DesignPatterns_in_C_.OopPrinciples.Encapsulation
{
    class Encapsulation
    {
        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount(-100);

            Console.WriteLine(bankAccount.GetBalance());

            bankAccount.Deposite(50);

            Console.WriteLine(bankAccount.GetBalance());

            bankAccount.Withdraw(20);

            Console.WriteLine(bankAccount.GetBalance());

        }
    }
}
