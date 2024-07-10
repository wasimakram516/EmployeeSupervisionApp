using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSupervisionApp.Controllers
{
    public class CheckInCheckOutController
    {
        private readonly CompanyContext context;

        public CheckInCheckOutController()
        {
            context = new CompanyContext();
        }

        public void CheckIn(int employeeId)
        {
            var checkIn = new CheckInCheckOut
            {
                EmployeeId = employeeId,
                CheckInTime = DateTime.Now
            };

            context.CheckInCheckOuts.Add(checkIn);
            context.SaveChanges();
        }

        public void CheckOut(int employeeId)
        {
            var checkInCheckOut = context.CheckInCheckOuts
                .Where(c => c.EmployeeId == employeeId && c.CheckOutTime == null)
                .OrderByDescending(c => c.CheckInTime)
                .FirstOrDefault();

            if (checkInCheckOut != null)
            {
                checkInCheckOut.CheckOutTime = DateTime.Now;
                context.SaveChanges();
            }
        }

        public List<CheckInCheckOut> GetCheckInsCheckOuts(int employeeId, DateTime startDate, DateTime endDate)
        {
            return context.CheckInCheckOuts
                .Where(c => c.EmployeeId == employeeId && c.CheckInTime >= startDate && c.CheckInTime <= endDate)
                .ToList();
        }
    }
}
