using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOP_Inheritance2.Exceptions
{
    public class ValidationException : Exception
    {
        public string PropertName { get; private set; }
        public ValidationException(string message, string propertyName) : base(message + " Date: " + DateTime.Now)
        {
            PropertName = propertyName;
        }

        public ValidationException(string message) : base(message + " Date: " + DateTime.Now)
        {
            
        }

        public ValidationException()
        {
            
        }
    }
}
