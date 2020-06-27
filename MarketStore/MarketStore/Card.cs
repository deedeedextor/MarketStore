using System;
using System.Text;

namespace MarketStore
{
    public abstract class Card : ICard
    {
        public Card(Owner owner, decimal turnover)
        {
            this.Id = Guid.NewGuid().ToString();

            this.Owner = owner;
            this.Turnover = turnover;
        }

        public string Id { get; set; }

        public string OwnerId { get; set; }

        public Owner Owner { get; set; }

        public decimal Turnover { get; protected set; }

        protected decimal DiscountRate { get; set; }

        public decimal CalculateDiscount(decimal purchase)
        {
            return purchase * this.GetDiscountRate();
        }

        public abstract decimal GetDiscountRate();

        public string Output(decimal purchase)
        {
            StringBuilder sb = new StringBuilder();
            decimal discount = this.CalculateDiscount(purchase);

            sb.AppendLine($"Purchase value: ${purchase:F2}");
            sb.AppendLine($"Discount rate: {this.GetDiscountRate() * 100:F1}%");
            sb.AppendLine($"Discount: ${discount:F2}");
            sb.AppendLine($"Total: ${purchase - discount:F2}");

            return sb.ToString();
        }
    }
}
