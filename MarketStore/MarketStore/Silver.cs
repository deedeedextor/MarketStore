namespace MarketStore
{
    public class Silver : Card
    {
        private const decimal InitialDiscoundRate = 0.02m;

        public Silver(Owner owner, decimal turnover)
            :base(owner, turnover)
        {
        }

        public override decimal GetDiscountRate()
        {
            if (this.Turnover > 300m)
            {
                this.DiscountRate = 0.035m;
            }
            else
            {
                this.DiscountRate = InitialDiscoundRate;
            }

            return this.DiscountRate;
        }
    }
}
