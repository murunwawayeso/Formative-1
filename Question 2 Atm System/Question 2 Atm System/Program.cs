using System;

class ATM
{
    static void Main()
    {
        double balance = 5000; // starting balance
        DateTime now = DateTime.Now;

        Console.WriteLine("=== ATM SYSTEM ===\n");
        Console.Write("Hi, What is your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("WELCOME " + name);
        
        Console.Write("Enter withdrawal amount: ");
        string formatted = now.ToString("dd MMMM yyyy HH:mm:ss");

        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;

                Console.WriteLine("\nTransaction Successful!");
                Console.WriteLine($"Amount Withdrawn: R{amount}");
                Console.WriteLine($"Remaining Balance: R{balance}");
                Console.WriteLine("Transaction Time: "+ formatted);
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}