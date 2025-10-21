using _24_OOP_Inheritance2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOP_Inheritance2.Validations
{
    public static class CheckValidation
    {
        public static string CheckValue(string value)
        {
            if (!string.IsNullOrEmpty(value))
                return value;
            else
                throw new ValidationException("Giriş alanı boş geçilemez!");
        }
    }
}
