using DbWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebApplication1.Pages
{
    public class TeamModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public TeamModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPostAdd(string name, int id)
        {
            DBWork.AddUser(new User(id, name, 0));
            return RedirectToPage("team");
        }

        public IActionResult OnPostAddKaka(int id)
        {

            DBWork.AddKaka(new User(id, "", 1));
            return RedirectToPage("team");
        }

        public IActionResult OnPostRemoveKaka(int id)
        {

            DBWork.AddKaka(new User(id, "", -1));
            return RedirectToPage("team");
        }

        public IActionResult OnPostDelete(int id)
        {

            DBWork.DeleteUser(new User(id, "", 0));
            return RedirectToPage("team");
        }
    }
}
