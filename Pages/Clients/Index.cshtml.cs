using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace employee_management.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<Client> ClientList { get; set; } = new();

        public void OnGet()
        {
            ClientList = ClientRepository.Clients;
        }
    }
}
