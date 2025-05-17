namespace PortfolioApp.Models
{
    public class Stock : Asset
    {
        public int Shares { get; set; }
        public decimal CurrentPrice { get; set; }

        public Stock(string name, int shares, decimal price)
            : base(name, shares * price)
        {
            Shares = shares;
            CurrentPrice = price;
        }

        public override decimal GetCurrentValue()
        {
            return Shares * CurrentPrice;
        }
    }
}
