namespace _06_Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TryCatch
            /* Derleme Hataları (Compile-time Errors) = Program kodu derlenmeden önce, yani program çalıştırılamadan önce ortaya çıkar. Genellik sözdizimi (syntax) kaynaklı halardır.
             * 
             * Mantıksal Hatalar (Logical Errors) = Program düzgün bir şekilde derlenir çalışır ama istenmeyen sonuçlar elde edilebilir. Yüzde yüz Yazılımcı kaynaklıdır.
             * 
             * Çalışma Zamanı Hataları (Runtime Errors) = Program derlendikten sonra çalıştırma sırasında meydana gelen hatalarıdr.
             */

            //Start:
            //Console.Write("Bir sayı gir: ");
            //string sayi = Console.ReadLine();
            //try
            //{
            //    //Hata gelmesi muhtemel kodlarımızı yazdığımız alan.
            //    int donusenSayi = int.Parse(sayi);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Lüten numeric bir ifade giriniz! Hata: " + ex.Message);
            //    goto Start;
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Lütfen daha küçük bir sayı giriniz! Hata: " + ex.Message);
            //    goto Start;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message);
            //}
            //finally 
            //{
            //    //Her türlü durumda çalışan mekanizma
            //    Console.WriteLine("Her türlü çalışırım?");
            //}

            //try
            //{
            //    int number = int.Parse("Bir"); //Format hatası
            //}
            //catch (FormatException ex) when (ex.Message.Contains("Input string2"))
            //{
            //    Console.WriteLine("Giriş formatu hatası: " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Console.Write("Yaş Girin: ");
            //    int age = int.Parse(Console.ReadLine());
            //    if (age < 18)
            //        throw new ArgumentException("Yas 18 den küçük olamaz!");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format Hatası: " + ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Boyut Hatası: " + ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    throw new ArgumentException("Yas 18 den küçük olamaz!");
            //}

            //string input = "123a";
            //int number;

            //bool success = int.TryParse(input, out number);

            //if (success)
            //{
            //    Console.WriteLine($"Başarılı bir giriş: " + number);
            //}
            //else
            //{
            //    Console.WriteLine($"Başarısız bir giriş: " + number);
            //}
            #endregion

            #region Question-1
            /*Senaryo: Banka Hesap Yönetim Sistemi
            Bir banka için müşteri hesaplarını yönetecek bir sistem geliştiriyorsunuz. Bu sistem, kullanıcının bir banka hesabını yönetmesine olanak tanır. Kullanıcı, sisteme giriş yaptıktan sonra çeşitli işlemler gerçekleştirebilir: bakiye sorgulama, para yatırma, para çekme ve çıkış yapma.

            Adımlar:
            Kullanıcı Girişi: Kullanıcıdan, doğru kullanıcı adı ve şifreyi girmesi istenir. Yanlış giriş yaparsa sistemden çıkış yapılmaz, tekrar denemesi sağlanır. Bu işlem while döngüsü ve try-catch kullanılarak yapılacaktır.
            Doğru kullanıcı adı: admin, Şifre: 1234.
            
            İşlem Menüsü (Switch-Case ile): Kullanıcı giriş yaptıktan sonra bir menü karşısına çıkar:
            Bakiye Sorgulama
            Para Yatırma
            Para Çekme
            Çıkış Yap
            
            İşlemler: Kullanıcı, istediği işlemi menüden seçebilir:
            Bakiye Sorgulama: Kullanıcının hesabındaki mevcut bakiye görüntülenir.
            Para Yatırma: Kullanıcıdan yatırılacak miktar istenir. Bu miktar geçerli bir sayı olmalıdır (try-parse kullanılarak doğrulanır).
            Para Çekme: Kullanıcıdan çekilmek istenen miktar istenir. Eğer bakiye yetersizse, hata mesajı gösterilir (if kullanılarak kontrol edilir).
            Çıkış Yap: Kullanıcı sistemi kapatır ve teşekkür mesajı alır.
            Hata Yönetimi:

            Kullanıcı hatalı giriş yaparsa, try-catch bloğu ile yakalanır ve kullanıcıya tekrar deneme hakkı verilir.*/
            #endregion
        }
    }
}
