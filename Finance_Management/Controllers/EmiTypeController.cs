using Finance_Management.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Management.Controllers
{
    
    
        [Route("api/[controller]")]
        [ApiController]
        public class EmiTypeController : Controller
        {

        private IEmiType objdata ;
        public EmiTypeController(IEmiType objdata)
        {
            this.objdata = objdata;
        }

        [HttpPost]
            [Route("updateDuration")]
            public IActionResult UpdateDuration()
            {
                var products = objdata.UpdateDuration();
                return Ok(products);
            }


        }
}
