using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_6_Tumakov
{
    internal class Program
    {
        public enum AccountType
        {
            Savings,
            Checking
        }

        static void Main(string[] args)
        {
            //Задания 7.1 - 7.3
            BankAccount account1 = new BankAccount(1000, AccountType.Savings);
            account1.PrintInfo();

            BankAccount account2 = new BankAccount(500, AccountType.Checking);
            account2.PrintInfo();

            BankAccount account3 = new BankAccount(2000, AccountType.Savings);
            account3.PrintInfo();

            BankAccount account4 = new BankAccount(1000, AccountType.Savings);
            account4.PrintInfo();
            account4.Withdraw(200);
            account4.Deposit(500);
            account4.PrintInfo();

            Console.ReadKey();

            //Домашние задание 7.3
            Building building1 = new Building(25, 5, 100, 2);
            building1.PrintInfo();

            Building building2 = new Building(30, 6, 120, 3);
            building2.PrintInfo();

            Building building3 = new Building(15, 3, 60, 2);
            building3.PrintInfo();

            Console.ReadKey();
        }

    }
}
