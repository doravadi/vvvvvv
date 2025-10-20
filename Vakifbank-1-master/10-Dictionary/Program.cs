namespace _10_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dicitonary, key-value çiftlerini saklayan koleksiyon yapısı.

            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(101, "Ali");
            ogrenciler.Add(102, "Ayşe");

            ogrenciler.Remove(101);

            ogrenciler.ContainsKey(102); //True

            Console.WriteLine(ogrenciler[102]);

            string isim;
            if (ogrenciler.TryGetValue(102, out isim)) 
            {
                Console.WriteLine(isim);
            }

            Dictionary<string, int> ogrenciNotları = new Dictionary<string, int>();
            string giris = "";

            while (true)
            {
                Console.WriteLine("\nÖğrenci Notları Yönetim Sistemi");
                Console.WriteLine("1. Not Ekle");
                Console.WriteLine("2. Notları Listele");
                Console.WriteLine("3. Not Güncelle");
                Console.WriteLine("4. Not Sil");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminizi Yapın: ");
                giris = Console.ReadLine();

                switch (giris)
                {
                    case "1":
                        ogrenciStart:
                        Console.Write("Öğrenci Adı: ");
                        string ogrenciAdi = Console.ReadLine();

                        Console.Write("Öğrenci Notu: ");
                        int ogrenciNotu = int.Parse(Console.ReadLine());

                        if (ogrenciNotları.ContainsKey(ogrenciAdi))
                        {
                            Console.WriteLine("Bu öğrencinin not bilgisi mevcut");
                            goto ogrenciStart;
                        }

                        ogrenciNotları.Add(ogrenciAdi, ogrenciNotu);
                        Console.WriteLine("Not başarılı bir şekilde eklendi!");
                        break;
                    case "2":
                        Console.WriteLine("\nÖğrenci Notları");
                        foreach (var ogrenci in ogrenciNotları)
                        {
                            Console.WriteLine($"Öğrenci: {ogrenci.Key} Notu: {ogrenci.Value}");
                        }
                        break;
                    case "3":
                        Console.Write("\nGüncellemek istediğiniz öğrencinin adı: ");
                        string guncellemeAdi = Console.ReadLine();

                        if (ogrenciNotları.ContainsKey(guncellemeAdi))
                        {
                            Console.Write("Yeni Notu: ");
                            int yeniNot = int.Parse(Console.ReadLine());
                            ogrenciNotları[guncellemeAdi] = yeniNot;
                            Console.WriteLine("Not başarıyla güncellendi");
                        }
                        else 
                        {
                            Console.WriteLine("Bu öğrenci bulunamadı!");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Silmek istediğiniz öğrencinin adını girin: ");
                        string silinecekAd = Console.ReadLine();

                        if (ogrenciNotları.Remove(silinecekAd))
                        {
                            Console.WriteLine("Öğrenci bilgisi silindi");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci bulunamadı");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Çıkış yapılıyor");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrara deneyiniz.");
                        break;
                }
            }
        }
    }
}
