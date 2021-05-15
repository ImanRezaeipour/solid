using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Payment.PaymentFactory
{
    public static class PaymentServiceFactory
    {
        public static PaymentService Create()
        {
            var current = ConfigurationManager.AppSettings["CurrentPaymentService"];
            if (current == null) throw new ConfigurationErrorsException("CurrentPayment is not available in configurations.");

            if (string.Equals("paypal", current, StringComparison.OrdinalIgnoreCase))
            {
                return new PayPalService("","");
            }
            else if (string.Equals("wepay", current, StringComparison.OrdinalIgnoreCase))
            {
                return new WePayService("","");
            }
            else
                throw new ConfigurationErrorsException("Invalid payment service in configurations.");
        }
    }
}
