namespace PortfolioApp.Models
{
    public abstract class Asset
    {
        public string Name { get; set; }
        public decimal AmountInvested { get; set; }

        public Asset(string name, decimal amountInvested)
        {
            Name = name;
            AmountInvested = amountInvested;
        }

        public abstract decimal GetCurrentValue();
    }
}
