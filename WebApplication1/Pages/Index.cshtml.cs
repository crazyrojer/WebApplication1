using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using WebApplication1;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public UserHub<User> UserHub { get; set; }

        public IndexModel(ILogger<IndexModel> logger, UserHub<User> userHub)
        {
            _logger = logger;
            UserHub = userHub;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostAdd(string name, int id)
        {
            UserHub.Entities.Any(u => u.Id == id);
                UserHub.Add(new User(id, name));

            return RedirectToPage("index");
        }

        public IActionResult OnPostDelete(int id)
        {

            UserHub.Remove(id);
            return RedirectToPage("index");
        }

        public IActionResult OnPostChange(int id, string name)
        {
            UserHub.Change(new User(id, name));
            return RedirectToPage("index");
        }
    }
}