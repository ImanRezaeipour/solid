namespace _04_Pricing
{
    public abstract class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    public class VipCustomer : Customer
    {
        public long VipCode { get; set; }
    }

    public class NormalCustomer : Customer
    {
        
    }
}