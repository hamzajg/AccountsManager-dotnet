using System;
namespace AccountsManager.Domain
{
    public class TaxInformation
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string TaxCode { get; set; }
        public bool VAT { get; set; }
        public string VATRef { get; set; }
    }
}
