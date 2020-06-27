using System;

namespace MarketStore
{
    public class Owner
    {
        public Owner(string name)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}
