using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Finance_Project.DataAccessLayer;

namespace Finance_Project.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmiTableController : Controller
    {
        [HttpGet]
        [Route("fetchById")]
        public IActionResult FetchById(int id)
        {
            var fetchedData = EmiTableDao.FetchAllProductsId();
            return Ok(fetchedData);
        }
        [HttpPost]
        [Route("updateAmount")]
        public IActionResult UpdateAmount()
        {
            var products = EmiTableDao.UpdateAmount();
            return Ok(products);
        }

    }
}
