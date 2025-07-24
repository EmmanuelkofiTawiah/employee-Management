using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace employee_management.Pages.Assets
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public Asset Asset { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Asset.Id = AssetRepository.Assets.Max(a => a.Id) + 1;
            AssetRepository.Assets.Add(Asset);
            return RedirectToPage("Index");
        }
    }
}
