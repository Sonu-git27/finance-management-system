using Microsoft.AspNetCore.Mvc;
using Finance_Project.DataAccessLayer;
using Microsoft.AspNetCore.Routing;

namespace Finance_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     
    public class LoginController : Controller
    {

        [HttpUpdate]
        [Route("id")]
        private IActionResult updatePassword()
        {
            var result = LoginTypeDao.UpdatePassword();
            return Ok(result);
        }

        
    }
}
