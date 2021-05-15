namespace _04_Pricing.DiscountCalculation
{
    public interface IDiscountCalculator
    {
        long Calculate(Order order);
    }
}