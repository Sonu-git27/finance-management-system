using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
    public class EmiTableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
