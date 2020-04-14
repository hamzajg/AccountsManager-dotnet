using System;
using System.Collections.Generic;

namespace AccountsManager.Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Message { get; set; }
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
