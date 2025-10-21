using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Extension
{
    public static class StringExtension
    {
        public static string ReverseString(this string str)
        { 
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Metnin ilk harfini büyüten bir extension metot
        public static string CapitalizeFirs(this string str) 
        { 
            if(string.IsNullOrEmpty(str)) 
                return str;

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }
}
