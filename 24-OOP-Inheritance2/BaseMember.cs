using _24_OOP_Inheritance2.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOP_Inheritance2
{
    public class BaseMember
    {
		private string _firstName;
		private string _lastName;
		private DateTime _joinedAt;
		protected decimal _price = 5000;

        protected BaseMember(string firstName, string lastName, DateTime joinedAt)
        {
            _firstName = firstName;
            _lastName = lastName;
            JoinedAt = joinedAt;
        }

        public DateTime JoinedAt
		{
			get { return _joinedAt; }
			set 
			{ 
				_joinedAt = DateValidation.CheckDate(value);
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set 
			{
				_lastName = CheckValidation.CheckValue(value);
			}
		}

		public string FistName
		{
			get { return _firstName; }
			set 
			{
                _firstName = CheckValidation.CheckValue(value);
            }
		}

		public string FullName => _firstName + " " + _lastName.ToUpper();

        public virtual decimal MembershipFee(int month)
		{ 
			return _price * month;
		}

        public override string ToString()
        {
			return $"\nÜye Adı: {FullName} Kayıt Tarihini: {JoinedAt}";
        }

    }
}
