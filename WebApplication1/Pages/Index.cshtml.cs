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
            DBWork.AddUser(new User(id, name, 0));
            return RedirectToPage("index");
        }

        public IActionResult OnPostDelete(int id)
        {

            DBWork.DeleteUser(new User(id, "", 0));
            return RedirectToPage("index");
        }

        public IActionResult OnPostChange(int id, string name)
        {
            DBWork.ChangeUser(new User(id, name, 0));
            return RedirectToPage("index");
        }

        public IActionResult OnPostAddKaka(int id)
        {

            DBWork.AddKaka(new User(id, "", 1));
            return RedirectToPage("index");
        }

        public IActionResult OnPostRemoveKaka(int id)
        {

            DBWork.AddKaka(new User(id, "", -1));
            return RedirectToPage("index");
        }
    }
}