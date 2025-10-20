namespace _12_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack (yığın) yapısı son giren ilk çıkar LIFO (Last in First Out)
            Stack<int> yigin = new Stack<int>();
            yigin.Push(10);
            yigin.Push(15);
            yigin.Push(20);

            yigin.Pop();
            yigin.Peek();

            Stack<string> gecmis = new Stack<string>();
            string giris = "";

            while (true) 
            {
                Console.WriteLine("\nTarayıcı Geçmişi");
                Console.WriteLine("1. Sayfa Ziyareti Ekle");
                Console.WriteLine("2. Geçmişi Listele");
                Console.WriteLine("3. Geri Al");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminizi Yapın: ");
                giris = Console.ReadLine();

                switch (giris)
                {
                    case "1":
                        Console.Write("URL: ");
                        string url = Console.ReadLine();
                        gecmis.Push(url);
                        Console.WriteLine("Sayfa eklendi");
                        break;
                    case "2":
                        Console.WriteLine("URL Listele");
                        foreach (var item in gecmis)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        if (gecmis.Count() > 0)
                        {
                            string geriAlinanURL = gecmis.Pop();
                            Console.WriteLine("Geri Alındı " + geriAlinanURL);
                        }
                        else 
                        {
                            Console.WriteLine("Geçmiş temizlendi");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Çıkış Yapılıyor");
                        return;
                    default:
                        Console.WriteLine("Hatalı giriş");
                        break;
                }
            }
        }
    }
}
