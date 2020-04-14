using System;
namespace AccountsManager.Domain
{
    public class PaymentBilling
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public PaymentMethod PreferredMethod { get; set; }
        public string Terms { get; set; }
        public double OpeningBalance { get; set; }
    }
}
