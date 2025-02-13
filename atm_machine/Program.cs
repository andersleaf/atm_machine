using System;
using System.Data;
using System.Numerics;

namespace atm_machine
{
    class BankAccount
    {
        static int balance = 0;
        static string username;
        public int amount;
        public int total;

        public static int Options()
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Check your balance");
            string choice = Console.ReadLine();
            Convert.ToInt32(choice);
            if (choice == "1")
            {
                BankAccount.Deposit();
            }

        }
        public int Balance(int total, int amount)
        {
            return total; // Stores the balance of the bank account
        }
        public static void Get_Balance(int total)
        {
            Console.WriteLine(total); //Displays the balance of the bank account to the user
        }
        public static string Users()
        {

        }
        public string Create(string username)
        {
            Console.Write("Welcome, please type the name of your new bank account:");
            username = Console.ReadLine();
            return username;
        }
        public string Name(string username)
        {
            Console.Write("Please enter the name of the account you will be checking: ");
            return Console.ReadLine(); // Get the name of the account holder
        }
        public int Deposit(int amount)
        {
            Console.Write("Please enter the amount of money you wish to deposit: ");
            string a = Console.ReadLine();
            Convert.ToInt32(a);
            total = amount + total;
        }
        public int Withdraw(int amount)
        {
            Console.Write("Please enter the amount of money you with to withdraw: ");
            string a = Console.ReadLine();
            return Convert.ToInt32(a);
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            int balance = 0;
            string username;
            BankAccount.Create();
        }
    }
}