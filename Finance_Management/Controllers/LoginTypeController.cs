using Microsoft.AspNetCore.Mvc;
using Finance_Management.DataAccessLayer;
using Microsoft.AspNetCore.Routing;

namespace Finance_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     
    public class LoginTypeController : Controller
    {
        //public ILoginType obj2;

        //public LoginTypeController(ILoginType obj2)
        //{
        //    this.obj2 = obj2;
        //}

        //[HttpPost]
        //[Route("updatepassword")]

        //public IActionResult UpdatePassword(LoginType password)
        //{
        //    var LoginType = obj2.UpdatePassword(password);
        //    return this.CreatedAtAction("Updatepassword");
        //}


    }
}
