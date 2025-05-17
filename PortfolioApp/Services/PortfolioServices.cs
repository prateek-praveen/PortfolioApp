using PortfolioApp.Models;

namespace PortfolioApp.Services
{
    public class PortfolioService
    {
        private List<Asset> assets = new();

        public void AddStock(string name, int shares, decimal price)
        {
            assets.Add(new Stock(name, shares, price));
            Console.WriteLine($"Added stock: {name}");
        }

        public void AddMutualFund(string name, decimal units, decimal nav)
        {
            assets.Add(new MutualFund(name, units, nav));
            Console.WriteLine($"Added mutual fund: {name}");
        }

        public void ShowPortfolio()
        {
            Console.WriteLine("\n=== Current Portfolio ===");

            if (!assets.Any())
            {
                Console.WriteLine("No assets added yet.");
                return;
            }

            foreach (var asset in assets)
            {
                Console.WriteLine($"- {asset.Name}: Invested = ₹{asset.AmountInvested}, Current Value = ₹{asset.GetCurrentValue()}");
            }

            Console.WriteLine($"\nNet Worth: ₹{CalculateNetWorth()}");
        }

        public decimal CalculateNetWorth()
        {
            return assets.Sum(a => a.GetCurrentValue());
        }
    }
}
