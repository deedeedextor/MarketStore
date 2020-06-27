namespace MarketStore
{
    public class Bronze : Card
    {
        public Bronze(Owner owner, decimal turnover)
            : base(owner, turnover)
        {
        }

        public override decimal GetDiscountRate()
        {
            if (this.Turnover < 100m)
            {
                this.DiscountRate = 0.00m;
            }
            else if (this.Turnover >= 100 || this.Turnover <= 300)
            {
                this.DiscountRate = 0.01m;
            }
            else
            {
                this.DiscountRate = 0.025m;
            }

            return this.DiscountRate;
        }
    }
}
