using System;

namespace _06_Notification
{
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
}