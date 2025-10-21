namespace _25_OOP_InheritanceLab
{
    internal class Program
    {
        static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
            //Öğrenci Otomasyon Sistemi
            /* Öğrenci => OgrenciNo, Notlar(list<int>), Ortalama Hesaplama()
             * Öğretmen => Branşı, DeneyimYılı
             * Yönetici => Role, YönettiğiKişiler 
             * 
             * Id (Otomatik Öğrenciler=100, Öğretmenler=300, Yöneticiler=600), Ad, Soyad, Email, ToString()
             * 
             * Console UI (Listeleme ve Ekleme)
             */

            while (true) 
            {
                Console.WriteLine("\n1-Öğrenci Ekle\n2-Öğretmen Ekle\n3-Yönetici Ekle\n4-Yöneticiye Kişi Ekle\n5-Öğrencileri Listele\n6-Öğretmenleri Listele\n7-Yöneticileri Listele\n8-Herkesi Listele\n9-Çıkış");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;

                }
            }
        }
    }
}
