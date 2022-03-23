using Finance_Management.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Management.Controllers
{
      
        [Route("api/[controller]")]
        [ApiController]

        public class OrdersController : Controller

        {

        private IOrders obj;
        public OrdersController(IOrders obj)
        {
            this.obj = obj;
        }

        [HttpGet]
            [Route("id")]
            private IActionResult fetchById()
            {
                var result = obj.fetchById();
                return Ok(result);
            }
        }

    internal class HttpUpdateAttribute : System.Attribute
    {
    }
}

