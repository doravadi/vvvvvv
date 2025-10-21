using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_Inheritance
{
    public class Phone
    {
		private string _brand;
		protected string _connectionType = "Kablolu Bağlantı";

        public Phone()
        {
            
        }
        public Phone(string brand)
        {
            Brand = brand;
        }
        public string ConnectionType
		{
			get { return _connectionType; }
		}

		public string Brand
		{
			get { return _brand; }
			private set { _brand = value; }
		}

		//Polymorphism (Çok Biçimlilik): Metodun davranışını değiştirme. 
		public virtual string Call() 
		{
			return "Arama gerçekleşiyor... Did did did did did...";
		}

        public override string ToString()
        {
            return $"Marka: {Brand} Bağlantı: {ConnectionType}";
        }
	}
}
