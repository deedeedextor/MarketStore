using System;

namespace MarketStore
{
    public class Gold : Card
    {
        private const decimal InitialDiscoundRate = 0.02m;

        public Gold(Owner owner, decimal turnover)
            : base(owner, turnover)
        {
        }

        public override decimal GetDiscountRate()
        {
            decimal countRate = (Math.Truncate(this.Turnover) / 100m) / 100m + InitialDiscoundRate;

            if (countRate >= 0.10m)
            {
                this.DiscountRate = 0.10m;
            }
            else
            {
                this.DiscountRate = countRate;
            }

            return this.DiscountRate;
        }
    }
}
