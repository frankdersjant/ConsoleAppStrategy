using ConsoleAppStrategy.Strategy.Interfaces;

namespace ConsoleAppStrategy.Strategy
{
    public class NormalCustomerDiscount : ICalcDiscount
    {
        public string NameOfStrategy => "NormalCustomerDiscount";

        public double DiscountPerCustomer()
        {
            return 0.0;
        }
    }
}
