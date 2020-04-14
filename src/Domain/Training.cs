using System;
namespace AccountsManager.Domain
{
    public class Training
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool Certification { get; set; }
        public string CertificationName { get; set; }
    }
}