using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOP_InheritanceLab
{
    public class Teacher : Person
    {
        public string Branch { get; set; }
        public int ExperienceYear { get; set; }
        public Teacher(string firstName, string lastName, string email, string branch, int experienceYear) : base(firstName, lastName, email)
        {
            Branch = branch;
            ExperienceYear = experienceYear;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Branch {Branch} Experience {ExperienceYear} year.";
        }
    }
}
