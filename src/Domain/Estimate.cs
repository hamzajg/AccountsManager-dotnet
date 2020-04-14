using System;
namespace AccountsManager.Domain
{
    public class Estimate
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public DateTime EstimateDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Message { get; set; }
    }
}
