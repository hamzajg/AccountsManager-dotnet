using System;
namespace AccountsManager.Domain
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AccountNo { get; set; }
        public string SortCode { get; set; }
    }
}
