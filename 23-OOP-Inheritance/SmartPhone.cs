using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_Inheritance
{
    public class SmartPhone : MobilPhone
    {
        public bool FrontCam { get; set; }
        public SmartPhone()
        {
            _connectionType = "5G";
        }

        public SmartPhone(string brand) : base(brand) 
        {
            _connectionType = "5G";
        }

        public string DoVideoCall()
        {
            if (FrontCam)
                return "Görüntülü arama gerçekleşiyor...";
            else
                return "Görüntülü arama desteklenmiyor...";
        }
        public override string ToString()
        {
            return $"Marka: {Brand} Bağlantı: {ConnectionType} Kamera: {HasCamera} Dokunmatik: {IsTouched} Ön Kamera: {FrontCam}";
        }
        //public sealed override string Call()
        //{
        //    return "Arama yapılıyor... Mp3 müzik çalıyor...";
        //}

        //Metot Hiding
        public new string Call()
        {
            return "";
        }
    }
}
