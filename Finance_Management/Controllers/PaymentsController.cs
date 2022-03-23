
using Finance_Management.BusinessAccessLayer;
using Finance_Management.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Management.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : Controller
    {
        private object PaymentDao;



        private IPayments data;
        public PaymentsController(IPayments data)
        {
            this.data = data;
        }

        [HttpUpdate]

            [Route("id")]

            private IActionResult updateDownPayment()

            {

                var result = data.UpdateDownPayment();
                return Ok(result);
            }
            private IActionResult GetById()
            {
                var result = data.GetById();
                return Ok(result);
            }


        
    }
}
