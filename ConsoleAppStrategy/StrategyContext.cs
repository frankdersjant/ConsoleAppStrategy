using ConsoleAppStrategy.Models;
using ConsoleAppStrategy.Strategy;
using ConsoleAppStrategy.Strategy.Interfaces;
using System.Collections.Generic;

namespace ConsoleAppStrategy
{
    public class StrategyContext
    {
        private Dictionary<string, ICalcDiscount> strategyContext;

        public StrategyContext()
        {
            strategyContext = new Dictionary<string, ICalcDiscount>();

            strategyContext.Add("regular", new NormalCustomerDiscount());
            strategyContext.Add("gold", new GoldCustomerDiscount());
            strategyContext.Add("hasToGo", new EverythingHasToGoDiscount());
        }

        public double ApplyStrategy(ICalcDiscount calcDiscount, double priceOnBid)
        {
            double finalprice = priceOnBid * calcDiscount.DiscountPerCustomer();

            return finalprice;
        }

        public ICalcDiscount GetDiscountPerCustomerType(DiscountEnum customerType)
        {
            switch (customerType)
            {
                case DiscountEnum.hasToGo:
                    return strategyContext[customerType.ToString()];
                //break;
                case DiscountEnum.gold:
                    return strategyContext[customerType.ToString()];
                // break;
                default:
                    return strategyContext[customerType.ToString()];

            }
        }
    }
}
