using System;
namespace AccountsManager.Domain
{
    public class Equipment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime LoanStartDateTime { get; set; }
        public DateTime LoanEndDateTime { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
    }
}
