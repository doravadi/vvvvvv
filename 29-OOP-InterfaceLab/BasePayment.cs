using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_InterfaceLab
{
    public abstract class BasePayment : IPayment
    {
        private decimal amount;

        protected BasePayment(decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount
        {
            get { return amount; }
            set 
            {
                if (value > 1)
                    amount = value;
                else
                    throw new ArgumentException("Ödeme miktarı 1 den küçük olamaz!");
            }
        }

        public abstract void CancelPayment();
        public abstract void MakePayment();
    }
}
