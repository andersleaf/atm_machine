using System;
using System.Data;
using System.Numerics;

namespace atm_machine
{
    class BankAccount
    {
        static int balance = 0;
        public string username;
        public int amount;
        public int total;

        public void Options()
        {
            Console.WriteLine($"What would you like to do today {username}? ");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Check your balance");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Please enter the amount of money you wish to deposit: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                Deposit(amount);
            }
        }
        public int Balance(int total, int amount)
        {
            return total; // Stores the balance of the bank account
        }
        public void Get_Balance(int total)
        {
            Console.WriteLine(total); //Displays the balance of the bank account to the user
        }
        public void Create()
        {
            Console.Write("Welcome, please type the name of your new bank account: ");
            username = Console.ReadLine();
        }
        public string Name(string username)
        {
            Console.Write("Please enter the name of the account you will be checking: ");
            return Console.ReadLine(); // Get the name of the account holder
        }
        public int Deposit(int amount)
        {
            total = amount + total;
            Console.WriteLine("Your new total is " + total);
            return total;

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
            BankAccount account = new BankAccount();
            int balance = 0;
            account.Create();
            account.Options();
        }
    }
}

