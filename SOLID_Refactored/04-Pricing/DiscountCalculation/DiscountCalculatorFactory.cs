using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pricing.DiscountCalculation
{
    public class DiscountCalculatorFactory
    {
        public static IDiscountCalculator Create(Customer customer)
        {
            if (customer is VipCustomer)
                return new VipCustomerDiscountCalculator();

            else if (customer is NormalCustomer)
                return new NormalCustomerDiscountCalculator();

            else
                throw new NotImplementedException();
        }
    }
}
