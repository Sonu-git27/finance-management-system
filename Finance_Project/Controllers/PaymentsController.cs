using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
