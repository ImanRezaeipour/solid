using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Payment.PaymentFactory;

namespace _05_Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = PaymentServiceFactory.Create();
            //if (service is PayPalService)
            //    ((PayPalService) service).RefreshToken();

            var referenceCode = service.DoPayment();
            Console.WriteLine("DoPayment finished. reference code : {0}", referenceCode);
            Console.ReadLine();
        }
    }
}
