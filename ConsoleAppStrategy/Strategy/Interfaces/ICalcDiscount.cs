using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrategy.Strategy.Interfaces
{
    public interface ICalcDiscount
    {
        string NameOfStrategy { get; }
        double DiscountPerCustomer();
    }
}
