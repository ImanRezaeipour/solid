using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pricing
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipCustomer = new VipCustomer();
            var order = new Order()
            {
                Price = 1000
            };

            var discountService = new DiscountCalculationService();
            var finalPrice = discountService.Calculate(vipCustomer, order);

            Console.WriteLine("You have to pay {0} dollars", finalPrice);
            Console.ReadLine();
        }
    }
}
