using System;

namespace _05_Payment
{
    public class WePayService : PaymentService
    {
        public WePayService(string username, string password) : base(username, password)
        {
        }

        public override Guid DoPayment()
        {
            //Do payment using WePay API
            return Guid.NewGuid();
        }

        public override void Refund(Guid id)
        {
            //refund using WePay API
        }
    }
}