namespace _13_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList, key-value çiftlerine göre sıralı bir şekilde data saklar.
            SortedList<int, string> sinif = new SortedList<int, string>();
            sinif.Add(3, "Ali");
            sinif.Add(1, "Veli");
            sinif.Add(4, "Elif");
            sinif.Add(5, "Ayşe");
            sinif.Add(2, "Zeynep");

            foreach (var item in sinif)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //HashSet, özellikle benzersiz elemanlar tutmak istediğiniz zaman kullanılır.
            HashSet<string> emailSet = new HashSet<string>();
            emailSet.Add("example1@example.com");
            emailSet.Add("example2@example.com");
            emailSet.Add("example2@example.com");
            emailSet.Add("example4@example.com");

            foreach (var item in emailSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
