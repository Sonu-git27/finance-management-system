using Finance_Project.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
      
        [Route("api/[controller]")]
        [ApiController]

        public class OrdersController : Controller

        {

            [HttpUpdate]

            [Route("id")]

            private IActionResult updateOrderdate()

            {

                var result = OrdersDao.UpdateOrderdate();
                return Ok(result);
            }
            [HttpGet]
            [Route("id")]
            private IActionResult fetchById()
            {
                var result = OrdersDao.fetchById();
                return Ok(result);
            }
        }


    

}

