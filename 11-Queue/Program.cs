namespace _11_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue (Kuyruk) yapısı ilk giren ilk çıkar (FIFO - First in Firt Out) prensibiyle çalışır.

            Queue<string> kuyruk = new Queue<string>();
            kuyruk.Enqueue("A"); //Kuyruğa eleman ekler.
            kuyruk.Enqueue("B");
            kuyruk.Enqueue("C");

            string ilkEleman = kuyruk.Dequeue(); //Kuyruktaki ilk elemanı çıkartır ve döndürür.

            string bas = kuyruk.Peek(); //Kuyruktaki ilk elmanı çıkarmadan döndürür.

            #region Example-1

            Queue<string> cagriKuyrugu = new Queue<string>();
            string giris = "";

            while (true) 
            {
                Console.WriteLine("\nÇağrı Merkezi Yönetim Sistemi");
                Console.WriteLine("1. Çağrı Ekle");
                Console.WriteLine("2. Çağrı Listele");
                Console.WriteLine("3. Çağrı İşle");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminizi Yapın: ");

                giris = Console.ReadLine();
                switch (giris)
                {
                    case "1":
                        Console.Write("\nÇağrı Bilgisi: ");
                        string cagriBilgisi = Console.ReadLine();
                        cagriKuyrugu.Enqueue(cagriBilgisi);
                        Console.WriteLine("Çağrı kuyruğa eklendi.");
                        break;
                    case "2":
                        Console.WriteLine("\nMevcut çağrılar");
                        foreach (var item in cagriKuyrugu)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        if (cagriKuyrugu.Count > 0)
                        {
                            string islenecekCagri = cagriKuyrugu.Dequeue();
                            string siradakiCagri = cagriKuyrugu.Peek();
                            Console.WriteLine($"İşlenecek çağrı: {islenecekCagri} sıradaki çağrı: {siradakiCagri}");
                        }
                        else
                        {
                            Console.WriteLine("Kuyrukta işlenecek çağrı yok.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Çıkış yapılıyor");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }

            #endregion
        }
    }
}
