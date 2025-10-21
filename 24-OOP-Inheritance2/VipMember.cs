using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOP_Inheritance2
{
    public class VipMember : BaseMember
    {
        public string Coach { get; private set; }
        public VipMember(string firstName, string lastName, DateTime joinedAt, string coach) : base(firstName, lastName, joinedAt)
        {
            Coach = coach;
            _price = 7500;
        }

        public override decimal MembershipFee(int month)
        {
            return base.MembershipFee(month) + 10000;
        }

        public override string ToString()
        {
            return base.ToString() + " Koç: " + Coach + " Ücret: " + MembershipFee(12);
        }
    }
}
