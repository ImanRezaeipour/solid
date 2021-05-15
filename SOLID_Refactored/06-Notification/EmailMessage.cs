namespace _06_Notification
{
    public interface IEmailMessage : IMessage
    {
        string Subject { get; set; }
    }
    public class EmailMessage : IEmailMessage
    {
        public string Reciever { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
    }
}