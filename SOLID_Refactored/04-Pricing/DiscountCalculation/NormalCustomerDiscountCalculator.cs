namespace _04_Pricing.DiscountCalculation
{
    public class NormalCustomerDiscountCalculator : IDiscountCalculator
    {
        public long Calculate(Order order)
        {
            return order.Price;
        }
    }
}