using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace employee_management.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        public Employee? Employee { get; set; }

        public IActionResult OnGet(int id)
        {
            Employee = EmployeeRepository.Employees.FirstOrDefault(e => e.Id == id);
            if (Employee == null)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
