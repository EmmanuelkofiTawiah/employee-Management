using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace employee_management.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public List<Employee> EmployeeList { get; set; } = new();

        public void OnGet()
        {
            EmployeeList = EmployeeRepository.Employees;
        }
    }
}
