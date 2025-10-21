namespace _19_OOP_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selam = "hello, World!";

            Console.WriteLine(selam.ReverseString());
            Console.WriteLine(selam.CapitalizeFirs());

            try
            {
                int x = int.Parse(selam);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetFriendlyMessage());
            }
        }
    }
}
