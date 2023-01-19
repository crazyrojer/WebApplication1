using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using WebApplication1;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostAdd(string name, int id)
        {
            bool checkId = true;

            foreach (var item in Program.userhub.users)
            {
                if (item.Id == id)
                {
                    checkId = false;
                }
            }

            if (checkId)
            {
                Program.userhub.AddUser(name, id);
            }
         
            return RedirectToPage("index");
        }

        public IActionResult OnPostDelete(int id)
        {
            Program.userhub.RemoveUser(id);
            return RedirectToPage("index");
        }

        public IActionResult OnPostChange(int id, string name)
        {
            Program.userhub.ChangeUser(id, name);
            return RedirectToPage("index");
        }
    }
}