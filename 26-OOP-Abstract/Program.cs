namespace _26_OOP_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MuzikAleti bateri1 = new Bateri("Marshall", "Tam profosyonel");

            Gitar gitar1 = new Gitar("Yamaha", "Profosyonel");

            Muzisyen muzisyen1 = new Muzisyen("Fatih", "Alkan");
            muzisyen1.CaldigiEnstruman = gitar1;

            Muzisyen muzisyen2 = new Muzisyen("Mert", "Kahraman");
            muzisyen2.CaldigiEnstruman = gitar1;

            Muzisyen muzisyen3 = new Muzisyen("Mustafa", "Bayrak");
            muzisyen3.CaldigiEnstruman = new Fulut("Redmi", "Amatör");

            Muzisyen muzisyen4 = new Muzisyen("Barış", "Dağ");
            muzisyen4.CaldigiEnstruman = bateri1;

            MuzikGrubu muzikGrubu = new MuzikGrubu("Bilge Çalgıcıları");
            muzikGrubu.Calgicilar.Add(muzisyen2);
            muzikGrubu.Calgicilar.Add(muzisyen3);
            muzikGrubu.Calgicilar.Add(muzisyen4);

            foreach (var item in muzikGrubu.Calgicilar)
            {
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Müzisyen: " + item.Adi);
                Console.Write("\t" + item.CaldigiEnstruman.BilgiVer());
                Console.WriteLine(" " +item.CaldigiEnstruman.Cal());
                Console.Beep();
            }
        }
    }
}
