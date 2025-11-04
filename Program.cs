namespace Assignment11._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = [7, 6, 4, 3, 1];
            Console.WriteLine(MaxProfit(prices));
            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            int maxP = 0;
            int minBuy = prices[0];

            foreach (int sell in prices)
            {
                maxP = Math.Max(maxP, sell - minBuy);
                minBuy = Math.Min(minBuy, sell);
            }
            return maxP;
        }
    }
}
