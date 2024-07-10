using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSupervisionApp.Controllers
{
    public class LeaveController
    {
        private readonly CompanyContext context;

        public LeaveController()
        {
            context = new CompanyContext();
        }

        public List<Leave> GetAllLeaves()
        {
            return context.Leaves.ToList();
        }

        public Leave GetLeaveByEmployeeId(int employeeId)
        {
            return context.Leaves.FirstOrDefault(l => l.EmployeeId == employeeId);
        }

        public void AddLeave(Leave leave)
        {
            context.Leaves.Add(leave);
            context.SaveChanges();
        }

        public void UpdateLeave(Leave leave)
        {
            var existingLeave = context.Leaves.Find(leave.LeaveId);
            if (existingLeave != null)
            {
                existingLeave.TotalDaysOff = leave.TotalDaysOff;
                existingLeave.DaysOffTaken = leave.DaysOffTaken;
                context.SaveChanges();
            }
        }

        public void DeleteLeave(int id)
        {
            var leave = context.Leaves.Find(id);
            if (leave != null)
            {
                context.Leaves.Remove(leave);
                context.SaveChanges();
            }
        }
    }
}
