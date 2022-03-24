using Finance_Project.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
    
    
        [Route("api/[controller]")]
        [ApiController]
        public class ProductController : Controller
        {

            [HttpPost]
            [Route("updateDuration")]
            public IActionResult UpdateDuration()
            {
                var products = EmiTypeDao.UpdateDuration();
                return Ok(products);
            }


        }
}
