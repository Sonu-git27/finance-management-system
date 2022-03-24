using Microsoft.AspNetCore.Mvc;

namespace Finance_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : Controller
    {
        [HttpGet]
        //private IRegistrationDao iregistrationDao;
        //IRegistrationController(IRegistrationDao iregistrationDao)
        //{
        //  iregistrationDao = iregistrationDao;
        //}
        [Route("{Usertypeid}")]
        public IActionResult Update(int id, [FromBody] UserTypeModel usertype)
        {
            
            var result = usertype.Update(id, usertype);
            return this.CreatedAtAction("Updateid",
                new
                {
                    StatusCode = 200,
                    Response = result,
                    Data = usertype
                });

        }
    }
}
