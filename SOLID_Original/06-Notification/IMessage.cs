using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Notification
{
    public interface IMessage
    {
        string Reciever { get; set; }
        string Subject { get; set; }
        string Content { get; set; }
    }

    public class SmsMessage : IMessage
    {
        public string Reciever { get; set; }

        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Content { get; set; }
    }

    public class EmailMessage : IMessage
    {
        public string Reciever { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
