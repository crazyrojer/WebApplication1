using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<User> users = new List<User>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            users.Add(new WebApplication1.User(1, "Vlad"));
            users.Add(new WebApplication1.User(2, "Andrey"));
            users.Add(new WebApplication1.User(3, "Vlad"));
            users.Add(new WebApplication1.User(4, "Nastya"));
            users.Add(new WebApplication1.User(5, "Nastya"));
            users.Add(new WebApplication1.User(6, "Sasha"));

        }

        public void OnPost(string name, int id)
        {
            users.Add(new WebApplication1.User(id, name));
        }
    }
}