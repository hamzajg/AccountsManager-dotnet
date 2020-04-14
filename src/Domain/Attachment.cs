using System;
namespace AccountsManager.Domain
{
    public class Attachment
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public int SupplierId { get; set; }
    }
}
