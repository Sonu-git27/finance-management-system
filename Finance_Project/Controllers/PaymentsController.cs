using Finance_Project.BussinessAccessLayer;
using Finance_Project.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : Controller
    {
        private object PaymentDao;

        
       
        
            [HttpUpdate]

            [Route("id")]

            private IActionResult updateDownPayment()

            {

                var result = PaymentsDao.UpdateDownPayment();
                return Ok(result);
            }
            private IActionResult getById()
            {
                var result = PaymentsDao.GetById();
                return Ok(result);
            }


        
    }
}
