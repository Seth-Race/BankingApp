using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; private set; } = 0;


        public void Deposit(decimal Amount) {
            if (Amount <= 0) {
                throw new Exception("Amount must be greater than zero.");
            } else
            Balance += Amount;
        }
        public virtual void Withdraw(decimal Amount) {
            if (Amount <= 0) {
                throw new Exception("Amount must be greater than zero.");
            } if (Amount > Balance) {
                Console.WriteLine("Insufficient funds.");
                return;
            }
            else
                Balance -= Amount;
        }

        public static void Transfer(decimal Amount, Account FromAccount, Account ToAccount) {
            FromAccount.Withdraw(Amount);
            ToAccount.Deposit(Amount);
        }

    }
}
