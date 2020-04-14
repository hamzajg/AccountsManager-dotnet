using System;
namespace AccountsManager.Domain
{
    public class DelayedCharge
    {
        public int Id { get; set; }
        public int InvoiceIdd { get; set; }
        public int CustomerIdd { get; set; }
        public DateTime DelayedChargeDated { get; set; }
        public string Messaged { get; set; }
    }
}
