using System;
namespace AccountsManager.Domain
{
    public class Subscription
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Product ProductSubscription { get; set; }
    }
}
