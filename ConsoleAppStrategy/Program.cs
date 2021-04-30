using ConsoleAppStrategy.Models;
using ConsoleAppStrategy.Strategy.Interfaces;
using System;

namespace ConsoleAppStrategy
{
    class Program
    {
        static void Main(string[] args)
        {

            StrategyContext strategyContext = new StrategyContext();

            var customertype = DiscountEnum.hasToGo;

            ICalcDiscount discountType = strategyContext.GetDiscountPerCustomerType(customertype);

            double OnBid = 100.00;

            double discount  = strategyContext.ApplyStrategy(discountType, OnBid);

            Console.WriteLine((OnBid - discount).ToString());
        }
    }
}
