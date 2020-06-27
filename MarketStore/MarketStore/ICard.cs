namespace MarketStore
{
    public interface ICard
    {
        decimal CalculateDiscount(decimal purchase);

        string Output(decimal purchase);
    }
}
