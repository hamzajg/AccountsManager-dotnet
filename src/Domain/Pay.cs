using System;
namespace AccountsManager.Domain
{
    public class Pay
    {
        public int Id { get; set; }
        public double HourlyRate { get; set; }
        public int EmployeeId { get; set; }
        public bool DefaultRate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
