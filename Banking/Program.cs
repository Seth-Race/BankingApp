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


            var sav1 = Savings.OpenSavingsAccount(200);
            Console.WriteLine($"Savings Balance: {sav1.Balance}");
           // var sav2 = Savings.OpenSavingsAccount(100);
           //Console.WriteLine($"Savings Balance: {sav2.Balance}");
            var sav3 = new Savings(300);
            Console.WriteLine($"Savings Balance: {sav3.Balance}");
            sav3.Withdraw(50);
            Console.WriteLine($"Savings Balance: {sav3.Balance}");
            Account.Transfer(50, sav3, acct1);
            Console.WriteLine($"Balance Sav3: {sav3.Balance}");
            Console.WriteLine($"Balance acct1: {acct1.Balance}");


            Console.WriteLine("Thanks for using the app!");
        }
    }
}
