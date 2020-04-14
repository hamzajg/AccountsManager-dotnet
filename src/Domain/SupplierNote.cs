using System;
namespace AccountsManager.Domain
{
    public class SupplierNote
    {
        public int Id { get; set; }
        public string NoteText { get; set; }
        public int SupplierId { get; set; }
    }
}
