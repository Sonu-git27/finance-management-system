using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
