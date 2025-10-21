namespace _07_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //Diziler, aynı veri tipindeki birden çok değeri bir arada tutmamıza olanak sağlayan yapılardır.

            //int[] numbers;
            //numbers = new int[5];
            
            //numbers[0] = 1;
            //numbers[3] = 5;
            //numbers[4] = 6;
            //Console.WriteLine(numbers[3]);

            //numbers = new int[8];

            //string[] meyveler = { "Elma", "Armut", "Portakal", "Karpuz" };

            //string item = "";
            //for (int i = 0; i < meyveler.Length; i++)
            //{
            //    item = meyveler[i];
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n"+new string('*',10) +"\n");

            //foreach (string meyve in meyveler)
            //{
            //    Console.WriteLine(meyve);
            //}

            //Console.ReadLine();


            //int[] sayilar = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = sayilar[i] * 2;
            //}

            //foreach (var item1 in sayilar)
            //{
            //    item1 = item1 * 2;
            //}
            #endregion

            #region MultidimensionalArrays
            //int[,] matris = new int[3, 3]
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    {7, 8, 9 }
            //};

            //Console.WriteLine(matris[1,2]);

            //for (int i = 0; i < 3; i++) 
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matris[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Jagged
            //Düzensiz Diziler
            //int[][] duzensizDizi = new int[3][];

            //duzensizDizi[0] = new int[2];
            //duzensizDizi[1] = new int[4];
            //duzensizDizi[2] = new int[1];

            //Console.WriteLine(duzensizDizi[0][1]);

            //Console.WriteLine();
            #endregion

            #region ArraySınıfı

            string[] ornekDizi = { "Istanbul", "Ankara", "Izmir", "Bursa", "Eskisehir", "Konya", "Trabzon", "Sivas", "Eskisehir" };

            //Sort: Sıralama
            Array.Sort(ornekDizi, 4, 5);
            Console.WriteLine("Sıralı Dizi\n");
            foreach (var item1 in ornekDizi)
            {
                Console.WriteLine(item1);
            }

            //Reverse: Tersine çevirme
            Array.Reverse(ornekDizi, 4, 5);
            Console.WriteLine("\nReverse İşlemi\n");
            foreach (var item in ornekDizi)
            {
                Console.WriteLine(item);
            }

            //IndefOf - LastIndexOf: Belirtilen bir değerin dizideki indeksini döndürür.
            int index = Array.IndexOf(ornekDizi, "Istanbul", 2, 3);
            Console.WriteLine(index);

            int index1 = Array.IndexOf(ornekDizi, "Bursa");
            int lastIndex1 = Array.LastIndexOf(ornekDizi, "Bursa");

            if (index1 != lastIndex1)
                Console.WriteLine("Birden fazla var");
            else
                Console.WriteLine("Bir tane var");

            //Clear: 
            //Console.WriteLine("\nClear İşlemi\n");
            //Array.Clear(ornekDizi);
            //foreach (var item in ornekDizi)
            //{
            //    Console.WriteLine(item);
            //}

            //Copy
            //Console.WriteLine("\nCopy İşlemi\n");
            //string[] yeniSehirler = new string[4];
            //Array.Copy(ornekDizi, 3, yeniSehirler, 2, 2);
            //foreach (var item in yeniSehirler)
            //{
            //    Console.WriteLine(item);
            //}

            Array.Resize(ref ornekDizi, 12);

            foreach (var item in ornekDizi)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string>();

            #endregion
        }
    }
}
