using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_OOP_Abstract
{
    //Abstract Class, sadece base class olarak davranmasını istediğiniz ve kendisinden instance çıkartılmamasını istediğimiz durumlarda kullanılır.
    public abstract class MuzikAleti
    {
		private string marka;
		private string aciklama;

        protected MuzikAleti(string marka, string aciklama)
        {
            Aciklama = aciklama;
			Marka = marka;
        }
        public string Aciklama
		{
			get { return aciklama; }
			set { aciklama = value; }
		}
		public string Marka
		{
			get { return marka; }
			set { marka = value; }
		}
		public string BilgiVer()
		{
			return $"Marka: {Marka} - Açıklama: {Aciklama}";
		}

		public abstract string Cal();
		//1-Abstract metot private olamaz.
		//2-Abstract metotlar sadece abstract classlarda tanımlanabilir.
		//3-Abstract metot virtual olarak tanımlanamaz. Doğal virtual'dır.
		//4-Abstract metot statitc olarak tanımlanamaz.
		//5-Abstract metot gövdesi olamaz!
	}
}
