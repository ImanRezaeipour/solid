using System;

namespace _04_Pricing
{
    public class DiscountCalculationService
    {
        public long Calculate(Customer customer, Order order)
        {
            if (customer is VipCustomer)
            {
                return (long) (order.Price - (order.Price*0.2));
            }
            else if (customer is NormalCustomer)
            {
                return order.Price;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}