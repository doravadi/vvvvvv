using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_InterfaceLab
{
    public class CashPayment : BasePayment
    {
        public CashPayment(decimal amount) : base(amount)
        {
        }

        public override void CancelPayment()
        {
            Console.WriteLine($"Nakit ödeme iptal edildi.");
        }

        public override void MakePayment()
        {
            Console.WriteLine($"Nakit: {Amount} TL ödeme gerçekleşti.");
        }
    }
}
