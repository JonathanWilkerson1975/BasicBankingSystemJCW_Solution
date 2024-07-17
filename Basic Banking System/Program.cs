using System;

namespace BasicBankingSystem
{
    class Program
    {
        static double balance = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nBasic Banking System");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Deposit();
                        break;
                    case 2:
                        Withdraw();
                        break;
                    case 3:
                        CheckBalance();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"${amount} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }

        static void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"${amount} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient balance.");
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Current balance: ${balance}");
        }
    }
}
