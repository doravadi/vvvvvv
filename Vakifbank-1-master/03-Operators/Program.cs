namespace _03_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatörler, C# programlama dilinde veriler üzerinde çeşitli işlemler gerçekleştirmeyi sağlayan sembolik ifadeler.

            #region Aritmetik Operatörler
            ////Toplama (+)
            //int a = 5, b = 3;
            //int toplam = a + b;
            //Console.WriteLine("Sonuç: " + toplam);

            ////Birleştirme (+)
            //string ilk = "Merhaba";
            //string ikinci = " Dünya";
            //string cumle = ilk + ikinci;
            //Console.WriteLine("Cümle: " + cumle);

            ////Fark (-)
            //int c = 10;
            //int d = 4;
            //int fark = c - d;
            //Console.WriteLine($"Fark: {fark}");

            ////Çarpma (*)
            //int e = 6;
            //int f = 7;
            //int carpim = e * f;
            //Console.WriteLine("Çarpım: {0}",carpim);

            ////Bölme (/)
            //int g = 20;
            //double h = 3;
            //double bolum = g / h;
            //Console.WriteLine("Bölüm: {0}",bolum);

            ////Mod (%)
            //int m = 10;
            //int n = 3;
            //Console.WriteLine("Kalan: {0}", m%n);
            //Console.WriteLine($"Kalan: {m%n}");
            //Console.WriteLine("Kalan: " + (m % n));

            #endregion

            #region AtamaOperatörleri

            //int sayi = 10;
            //sayi = sayi + 5;  //15

            //int toplam1 = 10;
            //toplam1 += 5;  //15

            //int fark1 = 10;
            //fark1 -= 4;  //6

            //int carpim1 = 7;
            //carpim *= 3; //21

            //int bolum1 = 20;
            //bolum /= 5;  //4

            ////Arttırma Azaltma Operatörleri
            //int sayi2 = 5;
            //sayi2 = sayi2 + 1;

            //sayi2 += 1;

            //sayi2++;

            ////++Sayi

            //int sayi3 = 10;
            //++sayi3;
            //Console.WriteLine(sayi3);

            ////Sayi++
            //int sayi4 = 10;
            //sayi4++;
            //Console.WriteLine(sayi4);

            //int i = 5;
            //int j = ++i + i++ + ++i + i;
            ////1) ++i => i önce 6 sonra 6 değeri döndürür.
            ////2) i++ => i şuan 6 ve 6 değerini döndürü sonra i 7 olur.
            ////3) ++i => i şuan 8 ve 8 değeri döndürür.
            ////4) i => güncel değeri 8

            ////6 + 6 + 8 + 8 = 28

            //Console.WriteLine($"Sonuç J = {j}");
            //Console.WriteLine($"Son durumda i = {i}");

            //i = 5;
            //int k = --i + i-- + --i + i;
            //Console.WriteLine($"Sonuç K = {k}");
            ////12
            #endregion

            #region KarşılaştırmaOperatörleri
            //Eşitlik (==)
            int a = 5, b = 6;
            bool esitMi = a == b;

            string c = "123", d = "123";
            bool esitMi2 = c == d;

            //Eşitsizlik (!=)
            bool esitMi3 = a != b;

            bool esitMi4 = a < b;
            bool esitMi5 = a > b;
            bool esitMi6 = a >= b;
            bool esitMi7 = a <= b;

            Console.ReadLine();
            #endregion

            #region MantıksalOperatörler
            bool a5 = true;
            bool b5 = false;
            bool sonuc5 = a5 && b5;
            bool sonuc6 = a5 || b5;
            #endregion

            //Escape Esquence
            Console.WriteLine("Merhaba\nHoş geldiniz.\tBu bir örnek metindir. \"Örnek alıntı \" Web Adresi: http:\\\\www.alkanfatih.com ");
        }
    }
}
