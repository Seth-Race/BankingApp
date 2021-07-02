using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Banking App!");
            var acct1 = new Account() {
                Id = 1234, Description = "First Account"
            };
            acct1.Deposit(1000);
            acct1.Withdraw(300);
            Console.WriteLine($"Balance: {acct1.Balance}");
            acct1.Deposit(200);
            Console.WriteLine($"Balance: {acct1.Balance}");





            Console.WriteLine("Thanks for using the app!");
        }
    }
}
