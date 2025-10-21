using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_Inheritance
{
    public class MobilPhone : Phone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }
        public MobilPhone()
        {
            _connectionType = "3G";
        }

        public MobilPhone(string brand) : base(brand)
        {
            _connectionType = "3G";
        }

        public string TakePhoto() 
        {
            if (HasCamera)
                return "Fotoğraf çekebilir.";
            else
                return "Fotoğraf çekemez.";
        }
        public override string ToString()
        {
            return $"Marka: {Brand} Bağlantı: {ConnectionType} Kamera: {HasCamera} Dokunmatik: {IsTouched}";
        }
        public override string Call()
        {
            return "Arama yapılıyor... Cendere cendere cendere cendere...";
        }
    }
}
