using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using WebApplication1;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public UserHub UserHub { get; set; }

        public IndexModel(ILogger<IndexModel> logger, UserHub userHub)
        {
            _logger = logger;
            UserHub = userHub;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostAdd(string name, int id)
        {
            bool checkId = true;

            foreach (var item in UserHub.users)
            {
                if (item.Id == id)
                {
                    checkId = false;
                }
            }

            if (checkId)
            {
                UserHub.AddUser(name, id);
            }
         
            return RedirectToPage("index");
        }

        public IActionResult OnPostDelete(int id)
        {
            UserHub.RemoveUser(id);
            return RedirectToPage("index");
        }

        public IActionResult OnPostChange(int id, string name)
        {
            UserHub.ChangeUser(id, name);
            return RedirectToPage("index");
        }
    }
}