using System;
namespace AccountsManager.Domain
{
    public class WebhookPost
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Sender { get; set; }
        public string Body { get; set; }
        public DateTime PostDateTime { get; set; }
    }
}
