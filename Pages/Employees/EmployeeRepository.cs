using System.Collections.Generic;

namespace employee_management.Pages.Employees
{
    public static class EmployeeRepository
    {
        public static List<Employee> Employees { get; } = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice Johnson", Department = "HR", Status = "Active", Role = "Manager" },
            new Employee { Id = 2, Name = "Bob Smith", Department = "IT", Status = "Active", Role = "Developer" },
            new Employee { Id = 3, Name = "Charlie Brown", Department = "Finance", Status = "Inactive", Role = "Accountant" },
            new Employee { Id = 4, Name = "Dana White", Department = "Operations", Status = "Active", Role = "Coordinator" }
        };
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Email { get; set; } = "example@example.com";
        public string Phone { get; set; } = "(555) 123-4567";
    }
}
