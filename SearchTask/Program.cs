namespace SearchTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"Total Estimate : {x + y:C}");

            Console.WriteLine("==========================");

            Console.WriteLine($"Total Estimate : {x + y:F5}");

            Console.WriteLine("==========================");

            Console.WriteLine($"Total Estimate : {x + y:D6}");

        }
    }
}
