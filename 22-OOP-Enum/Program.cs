namespace _22_OOP_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Order order1 = new Order();
            order1.OrderId = 123;
            order1.Name = "Test";
            order1.Status = OrderStatus.Delivered;

            order1.Detail();

            Console.WriteLine((int)OrderStatus.Cancelled);
            Console.WriteLine((OrderStatus)102);

            Schedule schedule = new Schedule();
            schedule.WorkDays = WorkDays.WK;

            Console.WriteLine("sdasdsa");
            var role = UserRole.Admin | UserRole.Editor;
            // aynı anda hem Admin hem Editor

            Console.WriteLine(role);
            // Output: Admin, Editor

            // Belirli bir rol içeriyor mu

        }
    }
}
