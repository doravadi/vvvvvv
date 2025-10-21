using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_AbstractLab
{
    public class CurrentAccount : BankAccount
    {
        private double _overdraftLimit = 5000;
        public CurrentAccount(string accountNumber, string accountName) : base(accountNumber, accountName)
        {
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} into Current Account.\nTotal Balance: {Balance}");
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -_overdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount} from Current Account.\nTotal Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit.");
            }
        }
    }
}
