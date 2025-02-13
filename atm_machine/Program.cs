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
            Console.WriteLine("");
            Console.WriteLine($"What would you like to do today {username}? ");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Check your balance");
            Console.WriteLine("");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter the amount of money you wish to deposit: ");
                Console.WriteLine("");
                int amount = Convert.ToInt32(Console.ReadLine());
                Deposit(amount);
                Options();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter the amount of money you with to withdraw: ");
                Console.WriteLine("");
                int amount = Convert.ToInt32(Console.ReadLine());
                Withdraw(amount);
                Options();
            }
            else if (choice == "3")
            {
                Console.WriteLine("");
                Get_Balance(total);
                Options();
            }
            else
            {
                Console.WriteLine("Invalid command. Please choose from the following options: ");
                Options();
            }
        }
        public void Get_Balance(int total)
        {
            Console.WriteLine("Your balance is: $" + total);
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
            Console.WriteLine("");
            Console.WriteLine("Your new total is: $" + total);
            return total;

        }
        public int Withdraw(int amount)
        {
            total = total - amount;
            Console.WriteLine("");
            Console.WriteLine("Your new total is: $" + total);
            return total;
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

