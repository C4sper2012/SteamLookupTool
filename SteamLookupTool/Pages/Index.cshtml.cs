using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SteamLookupToolModels.Models;

namespace SteamLookupTool.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Key { get; set; }
        [BindProperty]
        public User User { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void OnGet()
        {
            User = new User();
        }

        [HttpPost]
        public IActionResult OnPost()
        {
            Response.Cookies.Append("key", Key);
            Response.Cookies.Append("user", User.Personaname);
            return RedirectToPage("User");
        }
    }
}