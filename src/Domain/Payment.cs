using System;
namespace AccountsManager.Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string Memo { get; set; }
        public double AmountReceived { get; set; }
    }
}
