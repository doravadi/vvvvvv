using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_InterfaceLab
{
    //Ortak bir şablon.
    public interface IPayment
    {
        void MakePayment();
        void CancelPayment();
    }
}
