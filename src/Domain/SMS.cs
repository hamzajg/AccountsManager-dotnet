using System;
namespace AccountsManager.Domain
{
    public class SMS
    {
        public int Id { get; set; }
        public string SendTo { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
        public DateTime SentDateTime { get; set; }
        public DateTime DeliveredDateTime { get; set; }
    }
}
