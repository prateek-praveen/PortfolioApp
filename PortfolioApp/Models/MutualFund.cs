namespace PortfolioApp.Models
{
    public class MutualFund : Asset
    {
        public decimal Units { get; set; }
        public decimal NAV { get; set; }

        public MutualFund(string name, decimal units, decimal nav)
            : base(name, units * nav)
        {
            Units = units;
            NAV = nav;
        }

        public override decimal GetCurrentValue()
        {
            return Units * NAV;
        }
    }
}
