using Finance_Project.BussinessAccessLayer;
using Finance_Project.Controllers.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Finance_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : Controller
    {
         
        //private IRegistrationDao iregistrationDao;
        //IRegistrationController(IRegistrationDao iregistrationDao)
        //{
        //  iregistrationDao = iregistrationDao;
        //}
        
        [HttpGet]
        [Route("{Registrationid}")]
        public IActionResult GetById(int id)
        {
            
            var result = RegistrationDao.GetById( id);
            return this.Ok(result);
        }
         [HttpGet]
         [Route("{Details}")]
         public IActionResult GetAllDetails()
        {
            RegistrationDao registrationDao = new RegistrationDao();
            var reult = registrationDao.GetAllDetails();
            return this.Ok(reult);

            //ar result = RegistrationDao.GetAllDetails();
            //return this.Ok(result);
        }
        

    }
}

