using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSupervisionApp.Models
{
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [Required]
        public int TotalDaysOff { get; set; }

        [Required]
        public int DaysOffTaken { get; set; }

        [NotMapped]
        public int DaysOffRemaining => TotalDaysOff - DaysOffTaken;
    }
}
