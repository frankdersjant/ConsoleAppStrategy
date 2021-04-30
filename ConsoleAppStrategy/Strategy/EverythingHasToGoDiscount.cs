using ConsoleAppStrategy.Strategy.Interfaces;

namespace ConsoleAppStrategy.Strategy
{
    class EverythingHasToGoDiscount : ICalcDiscount
    {
        public string NameOfStrategy => "EverythingHasToGoDiscount";

        public double DiscountPerCustomer()
        {
            return 0.75;
        }
    }
}
