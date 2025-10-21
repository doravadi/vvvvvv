using System.ComponentModel.DataAnnotations;

namespace _24_OOP_Inheritance2
{
    internal class Program
    {
        static List<BaseMember> members = new List<BaseMember>()
        {
            new VipMember("Fatih", "Alkan", new DateTime(2025, 10, 22), "Kadir Hoca"),
            new VipMember("Mehmet", "Yıldız", new DateTime(2025, 10, 22), "Kadir Hoca"),
            new StandartMember("Hüseyin", "Çetin", new DateTime(2025, 10, 22)) { Kit=true },
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Spor salonu üyelik sistemi");
            while (true) 
            {
                Console.WriteLine("1) Üye Ekle 2) Üye Listele 3) Çıkış");
                Console.Write("Seçim: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Üye Adı: ");
                        string name = Console.ReadLine();
                        Console.Write("Üye Soyadı: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Başlangıç: ");
                        int day = int.Parse(Console.ReadLine());
                        Console.Write("Üye Tipi A-Vip B-Standart");
                        string input1 = Console.ReadLine();
                        if(input1 == "A")
                            members.Add(new VipMember(name, lastName, new DateTime(2025,10,21).AddDays(day), "Kadir Hoca"));
                        else
                            members.Add(new StandartMember(lastName, name, new DateTime(2025, 10, 21).AddDays(day)));
                        break;
                    case "2":
                        Console.Write("Üye Tipi A-Vip B-Standart C-Hepsi");
                        string input2 = Console.ReadLine();
                        if (input2 == "A")
                        {
                            foreach (var item in members)
                            {
                                if (item is VipMember)
                                    Console.WriteLine(item);
                            }
                        }
                        else if (input2 == "B")
                        {
                            foreach (var item in members)
                            {
                                if (item is StandartMember)
                                    Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            foreach (var item in members)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Hatalı veya yanlış giriş!");
                        break;
                }
            }
        }
    }
}
