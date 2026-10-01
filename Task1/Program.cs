namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Islam’s Carpet Cleaning Service
            int PriceOfSmallCarpet = 25;
            int PriceOfLargeCarpet = 35;
            decimal taxeRate = 0.06m;
            Console.WriteLine("Please enter number of smallcarpet ");
            int SmallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number of largecarpet ");
            int LargeCarpet = Convert.ToInt32(Console.ReadLine());
            decimal Cost = (SmallCarpet * PriceOfSmallCarpet) + (LargeCarpet * PriceOfLargeCarpet);
            decimal Tax = Cost * taxeRate;
            decimal TotalEstimate = Tax + Cost;
            Console.WriteLine($"Total Estimate : {TotalEstimate:C}\nThis estimate is valid for 30 days.");
            //Console.WriteLine("This estimate is valid for 30 days.");
            //int PriceOfSmallCarpet = 25;
            //int PriceOfLargeCarpet = 35;
            //decimal taxeRate = 0.06m;
            //List<int> Carpet  = new List<int>();
            //Console.WriteLine("Please enter number of smallcarpet ");
            //Carpet.Add(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("Please enter number of largecarpet ");
            //Carpet.Add(Convert.ToInt32(Console.ReadLine()));
            //decimal Cost = (Carpet[0] * PriceOfSmallCarpet) + (Carpet[1] * PriceOfLargeCarpet);
            //decimal Tax = Cost * taxeRate;
            //decimal TotalEstimate = Tax + Cost;
            //Console.WriteLine($"Total Estimate : {TotalEstimate:C}");
            //Console.WriteLine($"Total Estimate : {TotalEstimate:C}\nThis estimate is valid for 30 days.");
            //Console.WriteLine("This estimate is valid for 30 days.");


        }
    }
}
