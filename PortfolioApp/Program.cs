using PortfolioApp.Services;

class Program
{
    static void Main()
    {
        var portfolioService = new PortfolioService();

        while (true)
        {
            Console.WriteLine("\n=== Portfolio Asset Management ===");
            Console.WriteLine("1. Add Stock");
            Console.WriteLine("2. Add Mutual Fund");
            Console.WriteLine("3. View Portfolio");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            Console.Clear();
            switch (choice)
            {
                case "1":
                    Console.Write("Stock Name: ");
                    var stockName = Console.ReadLine();

                    Console.Write("Number of Shares: ");
                    int shares = int.Parse(Console.ReadLine());

                    Console.Write("Current Price per Share: ₹");
                    decimal price = decimal.Parse(Console.ReadLine());

                    portfolioService.AddStock(stockName, shares, price);
                    break;

                case "2":
                    Console.Write("Mutual Fund Name: ");
                    var mfName = Console.ReadLine();

                    Console.Write("Number of Units: ");
                    decimal units = decimal.Parse(Console.ReadLine());

                    Console.Write("NAV: ₹");
                    decimal nav = decimal.Parse(Console.ReadLine());

                    portfolioService.AddMutualFund(mfName, units, nav);
                    break;

                case "3":
                    portfolioService.ShowPortfolio();
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
