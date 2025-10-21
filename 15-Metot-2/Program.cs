using System.Security.Cryptography.X509Certificates;

namespace _15_Metot_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Params
            var result = Topla(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine("Toplam: " + result);
            #endregion

            #region Out
            double sonuc, bolumdenKalan;

            sonuc = Bolme(15, 2, out bolumdenKalan);
            Console.WriteLine($"15/2 = {sonuc} Kalan: {bolumdenKalan}");
            #endregion

            #region Ref
            int a = 10, b = 12;

            Console.WriteLine("İşlem öncesi a değişkeni:  {0}", a);
            Console.WriteLine("İşlem öncesi b değişkeni:  {0}", b);
            Console.WriteLine();
            Console.WriteLine();

            ToplamDeger(a);

            Console.WriteLine("İşlem sonrası a değişkeni: {0}", a); //10

            FarkDeger(ref b);

            Console.WriteLine("İşlem sonrası b değişkeni: {0}", b); //7


            int ToplamDeger(int a)
            {
                return a += 10;
            }

            void FarkDeger(ref int b)
            {
                b -= 5;
            }
            #endregion

            #region Ref2
            int sayi = 5;
            Console.WriteLine("Önce: " + sayi);

            DegeriDegistir(ref sayi);
            Console.WriteLine("Sonra: " + sayi);
            #endregion

            #region LocalMetotlar-Fonksiyon

            int Hesapla(int x, int y)
            { 
                return x + y;
            }

            #endregion
        }

        /// <summary>
        /// N Sayıda değişkeni toplayan metot.
        /// </summary>
        /// <param name="sayilar">Birden fazla sayı girişi</param>
        /// <returns>Sayıların toplam değeri</returns>
        public static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }

        /// <summary>
        /// Bölme işlemini gerçekleştirir.
        /// </summary>
        /// <param name="bolunen">Bölünecek sayı</param>
        /// <param name="bolen">Bölen sayı</param>
        /// <param name="kalan">Kalan sayı</param>
        /// <returns>Sonuç</returns>
        public static double Bolme(double bolunen, double bolen, out double kalan)
        {
            kalan = bolunen % bolen;
            return bolunen / bolen;
        }

        public static void DegeriDegistir(ref int x)
        {
            x = x + 10;
        }

        #region BestPracties
        /*Adlandırma Kuralları
         * 1-Anlamlı isimler: CalculateTotalPrice
         * 2-Fiil Kullanımı: GetCustomer, SaveFile, SendEmail gibi
         * 3-CamelCase ve PascalCase: C# dilinde metot isimleri genellikle PascalCase kullanılır. SendNatification()
         *Tek Sorumluluk Prensibi (Signle Responsibility)
         *Metotlar Kısa ve Öz Olmalıdır. (20 satırdan uzun olamamlıdır.)
         *Paramtere Sayısını Minimize Edin.
         *Dökümantasyon ve Yorum Satırları
         *DRY (Don't Repeat Yourself) Kendi edini tekrar etme.
         */

        //public int Calculate(int a, int b)
        //{
        //    if (a < 0 || b < 0)
        //        return -1;
        //    return a + b;
        //}

        public int Calculate(int a, int b)
        {
            int result = -1;
            if (a < 0 || b < 0)
                result = -1;
            result = a + b;
            return result;
        }


        #endregion
    }
}
