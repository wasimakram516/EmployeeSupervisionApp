using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSupervisionApp.Controllers
{
    public class EmployeeController
    {
        private readonly CompanyContext context;

        public EmployeeController()
        {
            context = new CompanyContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public List<Employee> SearchEmployees(string searchText)
        {
            return context.Employees
                .Where(e => e.Name.Contains(searchText) ||
                            e.Email.Contains(searchText) ||
                            e.PhoneNumber.Contains(searchText) ||
                            e.Address.Contains(searchText) ||
                            e.Department.Contains(searchText) ||
                            e.Position.Contains(searchText))
                .ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = context.Employees.Find(employee.EmployeeId);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Position = employee.Position;
                existingEmployee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.DateOfJoining = employee.DateOfJoining;
                existingEmployee.Email = employee.Email;
                existingEmployee.PhoneNumber = employee.PhoneNumber;
                existingEmployee.Address = employee.Address;
                existingEmployee.Department = employee.Department;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Password = employee.Password;
                existingEmployee.UserType = employee.UserType;
                existingEmployee.IsActive = employee.IsActive;

                if (!employee.IsActive && employee.DateOfLeft == null)
                {
                    existingEmployee.DateOfLeft = DateTime.Now;
                }
                else if (employee.IsActive)
                {
                    existingEmployee.DateOfLeft = null;
                }

                context.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
    }
}
