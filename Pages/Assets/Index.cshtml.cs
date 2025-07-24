using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace employee_management.Pages.Assets
{
    public class IndexModel : PageModel
    {
        public List<Asset> AssetList { get; set; } = new();

        public void OnGet()
        {
            AssetList = AssetRepository.Assets;
        }
    }
}
