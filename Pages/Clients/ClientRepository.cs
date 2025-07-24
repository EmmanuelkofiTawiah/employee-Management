using System.Collections.Generic;

namespace employee_management.Pages.Clients
{
    public static class ClientRepository
    {
        public static List<Client> Clients { get; } = new()
        {
            new Client { Id = 1, Code = "C001", Name = "Acme Corp", Address = "123 Main St", Phone = "123-456-7890", Email = "contact@acme.com", Status = "Active" },
            new Client { Id = 2, Code = "C002", Name = "Globex Inc", Address = "456 Market St", Phone = "555-123-4567", Email = "sales@globex.com", Status = "Active" }
        };
    }

    public class Client
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
