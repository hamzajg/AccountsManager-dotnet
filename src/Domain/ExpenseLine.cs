using System;
namespace AccountsManager.Domain
{
    public class ExpenseLine
    {
        public int Id { get; set; }
        public int ExpenseId { get; set; }
        public ServiceType Service { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double VAT { get; set; }
    }
}
