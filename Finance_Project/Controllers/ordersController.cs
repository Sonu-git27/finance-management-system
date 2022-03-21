using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
    public class ordersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
