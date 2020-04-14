using System;
namespace AccountsManager.Domain
{
    public class Note
    {
        public int Id { get; set; }
        public string NoteText { get; set; }
        public int CustomerId { get; set; }
    }
}
