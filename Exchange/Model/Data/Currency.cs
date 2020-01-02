using System;

namespace Exchange.Model.Data
{
    public class Currency : Base
    {
        public string Name { get; set; }
        public Double BuyRate { get; set; }
        public Double SellRate { get; set; }
        public Double BuyLimit { get; set; }
        public Double SellLimit { get; set; }

        public Currency(string name, double buyRate, double sellRate, double buyLimit, double sellLimit)
        {
            Name = name;
            BuyRate = buyRate;
            SellRate = sellRate;
            BuyLimit = buyLimit;
            SellLimit = sellLimit;
        }

        public override string ToString()
        {
            return $"{Name}:buy={BuyRate},sell={SellRate}";
        }
    }
}