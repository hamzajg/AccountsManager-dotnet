using System;
namespace AccountsManager.Domain
{
    public class PaymentDetails
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountNo { get; set; }
        public string SortCode { get; set; }
    }
}
