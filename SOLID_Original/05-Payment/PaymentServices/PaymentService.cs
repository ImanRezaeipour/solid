using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Payment
{
    public abstract class PaymentService
    {
        public string Username { get; protected set; }
        public string Password{ get; protected set; }
        protected PaymentService(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public abstract Guid DoPayment();
        public abstract void Refund(Guid id);
    }
}
