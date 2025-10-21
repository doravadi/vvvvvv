using System.Runtime.CompilerServices;

namespace _14_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SelamVer("Fatih");
            //SelamVer("Beyazıt");
            //SelamVer("Canan");
            //int result = Topla(5, 2);
            //int karesi = Topla(5, 2) * 2;

            //LogMessage("This is a default log");
            //LogMessage("This is a important log", "ERROR");
            LogMessage(status: "2", message: "asdas");
            DisplayUserInfo("Fatih");
            DisplayUserInfo("Beyazıt",7);
            Topla(2, 5, 3, 4);
            
        }

        //[ErişimBelirleyici] [Niteleyici?] [GeriDönüşTipi] [MetotAdi] ([parameterler?])
        //{
        // Metot Gövdesi
        //}

        private static void SelamVer(string ad) 
        {
            Console.WriteLine("Merhaba: " + ad);
        }

        //static int Topla(int sayi1, int sayi2) 
        //{
        //    try
        //    {
        //        return sayi1 + sayi2;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw;
        //    }
        //}

        public static void LogMessage(string message, string logLevel = "INFO", string status = "1") 
        {
            Console.WriteLine($"[{logLevel}] {message}");
        }

        public static void DisplayUserInfo(string name, int? age=null) 
        { 
            if(age.HasValue)
                Console.WriteLine($"{name} is {age} years old");
            else
                Console.WriteLine($"{name} did not provide an age.");
        }

        #region MetotOverloading
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static int Topla(int sayi1, decimal sayi2)
        {
            return sayi1 + (int)sayi2;
        }

        public static int Topla(string sayi1, decimal sayi2)
        {
            return int.Parse(sayi1) + (int)sayi2;
        }

        public static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public static int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }

        public static void Yazdir(string mesaj, int tekrar) 
        { 
            for(int i = 0; i < tekrar; i++)
                Console.WriteLine(mesaj);
        }

        public static void Yazdir(int tekrar, string mesaj)
        {
            for (int i = 0; i < tekrar; i++)
                Console.WriteLine(mesaj);
        }

        public static int Fark(int sayi1, int sayi2)
        { 
            return sayi1 - sayi2;
        }

        public static double Fark(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }

        #endregion
    }
}
