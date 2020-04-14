using System;
namespace AccountsManager.Domain
{
    public class CreditNote
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int Customer { get; set; }
        public DateTime CreditNoteDate { get; set; }
        public string Message { get; set; }
    }
}
