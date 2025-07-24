using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace employee_management.Pages.Clients
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public Client Client { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Client.Id = ClientRepository.Clients.Max(c => c.Id) + 1;
            ClientRepository.Clients.Add(Client);
            return RedirectToPage("Index");
        }
    }
}
