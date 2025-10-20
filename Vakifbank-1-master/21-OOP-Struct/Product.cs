using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Struct
{
    public class Product
    {
        private static int id = 0;

        public Product(string name, Currency price)
        {
            Name = name;
            Price = price;
            id++;
            Id = id;
        }

        public int Id;
        public string Name { get; private set; }
        public Currency Price { get; private set; }
    }
}
