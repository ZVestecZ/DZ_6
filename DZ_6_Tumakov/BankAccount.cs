using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DZ_6_Tumakov.Program;

namespace DZ_6_Tumakov
{
    internal class BankAccount
    {
        private static int nextAccountNumber = 1;
        private int accountNumber;
        private decimal balance;
        private AccountType accountType;

        public BankAccount(decimal initialBalance, AccountType accountType)
        {
            accountNumber = nextAccountNumber++;
            this.balance = initialBalance;
            this.accountType = accountType;
        }

        public int AccountNumber 
        { 
            get { return accountNumber; } 
        }
        public decimal Balance
        {
            get 
            { 
                return balance; 
            }
            private set { balance = value; }
        }
        public AccountType AccountType 
        { 
            get { return accountType; } 
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accountType}");
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
                return false;
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
    }
}
