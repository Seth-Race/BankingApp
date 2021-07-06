using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
    class Savings : Account {

        public decimal InterestRate { get; set; } = 0.12m;
        private static decimal MinBal { get; set; } = 200.00m;

        public override void Withdraw(decimal Amount) {
            if (Balance - Amount < MinBal) {
                throw new Exception($"Balance too low to withdraw. Must be < {Balance - MinBal}");
            }
            base.Withdraw(Amount);
        }

        public decimal CalculateInterest(int Months) {
            var interestAmount = Balance * (InterestRate / 12) * Months;
            Deposit(interestAmount);
            return interestAmount;
        }

        public static Savings OpenSavingsAccount(decimal OpenAmountDeposit) {
            if (OpenAmountDeposit < MinBal) {
                throw new Exception($"Opening Savings requires {MinBal} deposit");
            }
            var savings = new Savings();
            savings.Deposit(OpenAmountDeposit);
            return savings;
        }

        private Savings() { }

        public Savings(decimal OpenAmountDeposit) {
            if (OpenAmountDeposit < MinBal) {
                throw new Exception($"Opening Savings requires {MinBal} deposit");
            }
            Deposit(OpenAmountDeposit);
        }
    }
}
