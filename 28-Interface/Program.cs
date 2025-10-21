using _28_Interface.GoodExamples;

namespace _28_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFutbolcu> Takim = new List<IFutbolcu>();
            Takim.Add(new Defans { Name = "Apdülkerim" });
            Takim.Add(new Defans { Name = "Sanchez" });
            Takim.Add(new Forvet { Name = "Osimhen" });
            Takim.Add(new Kaleci { Name = "Uğurcan" });

            IDatabase database = new MySqlDatabase();
            database.Create("Kalem", 200, 100);
            database.Create("Kitap", 200, 100);
            database.Create("Defter", 200, 100);
            database.Create("asdas", 200, 100);
            database.Delete(5);
            database.Delete(6);
            database.Delete(7);
        }
    }
}
