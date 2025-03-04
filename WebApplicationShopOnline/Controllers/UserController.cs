using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User user = new User("Давид", "Хугаев", "ddkhugaev", "1234");
            return View(user);
        }
    }
}
