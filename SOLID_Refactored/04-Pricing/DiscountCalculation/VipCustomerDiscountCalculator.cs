namespace _04_Pricing.DiscountCalculation
{
    public class  VipCustomerDiscountCalculator : IDiscountCalculator
    {
        public long Calculate(Order order)
        {
            return (long)(order.Price - (order.Price * 0.2));
        }
    }
}