using ConsoleAppStrategy.Strategy.Interfaces;

namespace ConsoleAppStrategy.Strategy
{
    class GoldCustomerDiscount : ICalcDiscount
    {
        public string NameOfStrategy => "GoldCustomerDiscount";

        public double DiscountPerCustomer()
        {
          return 0.10;
        }
    }
}
