using System;
namespace AccountsManager.Domain
{
    public class EmptyClass
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string VoucherCode { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public double CreditAmount { get; set; }
        public Product ProductVoucher { get; set; }
    }
}
