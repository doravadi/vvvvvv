namespace _04_Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Yapısı
            //int not = 110;
            //if (not > 100 || not < 0)
            //    Console.WriteLine("Geçersiz bir not.");
            //else if (not >= 70)
            //    Console.WriteLine("Sınavı geçtiniz.");
            //else
            //    Console.WriteLine("Sınavı Kaldınız.");
            #endregion

            #region Example-1
            /*Senaryo: Kullanıcıdan kilosunu ve boyunu alarak vücut kitle indeksini (VKİ) hesaplayın. VKİ değerine göre kullanıcının zayıf, normal, kilolu veya obez olduğunu belirleyin. (Formül: VKİ = kilo / (boy * boy))
             * Zayıf: VKİ < 18.5
             * Normal: 18.5 <= VKİ < 24.9
             * Kilolu: 25 <= VKİ < 29.9
             * Obez: VKİ >= 30
            */

            //Console.Write("Kilonuzu Giriniz (kg): ");
            //double kilo = double.Parse(Console.ReadLine());

            //Console.Write("Boyunuzu Giriniz (m): ");
            //double boy = double.Parse(Console.ReadLine());

            //double vki = kilo / (boy * boy);
            //Console.WriteLine($"Vucut Kitle Indeksi: {vki}");

            //if (vki < 18.5)
            //{
            //    Console.WriteLine("Durumunuz: Zayıf");
            //}
            //else if (vki < 24.9)
            //{
            //    Console.WriteLine("Durumunuz: Normal");
            //}
            //else if (vki < 29.9)
            //{
            //    Console.WriteLine("Durumunuz: Kilolu");
            //}
            //else
            //{
            //    Console.WriteLine("Durumunuz: Obez");
            //}

            #endregion

            #region TernaryIf
            //int not1 = 75;
            //string sonuc = not1 >= 70 ? "Geçti" : "Kaldı";

            //Console.WriteLine("Sonuç: " + sonuc);

            //Console.Write("Bir sayı girin: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(sayi1 > 0 ? "Pozitif" : (sayi1 < 0) ? "Negatif" : "Sıfır");

            //if (sayi1 > 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else 
            //{
            //    if (sayi1 < 0)
            //    {
            //        Console.WriteLine("Negatif");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Sıfır");
            //    }
            //}

            #endregion

            #region SwitchCase
            //Console.Write("Bir sayı girin (1-7): ");
            //int gun = int.Parse(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Hafta içi");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Hafta sonu");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı bir giriş yaptınız!");
            //        break;
            //}
            #endregion

            #region Switch-Case2
            //Switch ile Pattern Matching
            //object veri = "10";

            //switch (veri)
            //{
            //    case int sayi when sayi > 0:
            //        Console.WriteLine("Positif bir tam sayı.");
            //        break;
            //    case int sayi when sayi < 0:
            //        Console.WriteLine("Negatig bir tam sayı.");
            //        break;
            //    case string:
            //        Console.WriteLine("Bir string girdiniz");
            //        break;
            //    default:
            //        Console.WriteLine("Tanımlanmayan bir tür.");
            //        break;
            //}

            //Console.WriteLine("İşlem Seçin (+, -, *, /): ");
            //int sayi1 = 5, sayi2 = 6;
            //char islem = Console.ReadLine()[0];

            //double sonuc = islem switch
            //{
            //    '+' => sayi1 + sayi2,
            //    '-' => sayi1 - sayi2,
            //    '*' => sayi1 * sayi2,
            //    '/' => sayi1 / sayi2,
            //    _ => double.NaN
            //};

            #endregion

            #region Example-1
            //Durum: Bir havayolu şirketi, uçak bileti rezervasyon sistemini geliştirmek istiyor. Kullanıcıdan seyahat türü(Tek Yön veya Gidiş - Dönüş), uçuş sınıfı(Ekonomi, Business, First Class) ve bilet adedini alarak toplam fiyatı hesaplayan bir program yazın. Ayrıca, kullanıcıya bir promosyon kodu sorulacak, eğer doğru kod girilirse % 15 indirim uygulanacaktır.

            //Detaylar:

            //Tek Yön uçuş fiyatları:
            //Ekonomi: 500 TL
            //Business: 1000 TL
            //First Class: 1500 TL
            //Gidiş - Dönüş uçuş fiyatları(gidiş-dönüş olduğu için fiyat iki katına çıkar):
            //Ekonomi: 900 TL
            //Business: 1800 TL
            //First Class: 2700 TL
            //Kullanıcıdan alınacak promosyon kodu: PROMO15

            //Soru: Kullanıcıdan gerekli bilgileri alarak uçak bileti fiyatını hesaplayan ve promosyon kodu geçerli ise indirim uygulayan bir program yazın.




            #endregion
        }
    }
}
