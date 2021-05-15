using System;

namespace _05_Payment
{
    public class PayPalService : PaymentService
    {
        private string token = null;
        public PayPalService(string username, string password) : base(username, password)
        {
        }

        public override Guid DoPayment()
        {
            if (token == null)
            {
                RefreshToken();
                //throw new NullReferenceException("Token is not initialized");
            }
            
            //use token to do payment
            return Guid.NewGuid();
        }

        public void RefreshToken()
        {
            token = "___";
        }

        public override void Refund(Guid id)
        {
            //refund using Paypal API
        }
    }
}