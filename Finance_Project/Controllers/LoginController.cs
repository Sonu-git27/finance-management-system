using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
