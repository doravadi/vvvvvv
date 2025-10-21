using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_AbstractLab
{
    public class SavingsAccount : BankAccount
    {
        private double _interestRate = 0.03; //Faiz oranı
        public SavingsAccount(string accountNumber, string accountName) : base(accountNumber, accountName)
        {
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount} into savings account.\nTotal Balance: {Balance}");
            AddInterest();
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount} from savings account\nTotal Balance:{Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        private void AddInterest()
        {
            Balance += Balance * _interestRate;
            Console.WriteLine($"Interest added. Balance: {Balance}");
        }
    }
}
