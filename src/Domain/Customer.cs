using System;
namespace AccountsManager.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Company { get; set; }
        public string DisplayNameAs { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public bool CreditAgreement { get; set; }
    }
}
