﻿using System;
namespace AccountsManager.Domain
{
    public class Absence
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool Paid { get; set; }
    }
}
