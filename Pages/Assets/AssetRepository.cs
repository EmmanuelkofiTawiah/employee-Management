using System.Collections.Generic;

namespace employee_management.Pages.Assets
{
    public static class AssetRepository
    {
        public static List<Asset> Assets { get; } = new()
        {
            new Asset { Id = 1, AssetNo = "FA-001", Description = "Laptop", Category = "Electronics", SerialNo = "ABC123", Model = "Dell XPS", ResponsibleEmployee = "Alice Johnson", Status = "Active" },
            new Asset { Id = 2, AssetNo = "FA-002", Description = "Projector", Category = "Electronics", SerialNo = "XYZ789", Model = "Epson V11", ResponsibleEmployee = "Bob Smith", Status = "Active" }
        };
    }

    public class Asset
    {
        public int Id { get; set; }
        public string AssetNo { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string SerialNo { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string ResponsibleEmployee { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
