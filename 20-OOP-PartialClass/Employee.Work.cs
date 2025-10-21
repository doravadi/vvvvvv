using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_PartialClass
{
    public partial class Employee
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public void DisplayWorkDetails()
        {
            Console.WriteLine($"Position: {Position}, Salary: {Salary}");
        }

        partial void OnNameChanged() 
        {
            
            Console.WriteLine("İsim değiştirildi");
        }
    }
}
