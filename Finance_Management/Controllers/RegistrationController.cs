using Finance_Management.Repository;
using Finance_Management.DataAccessLayer.Implementation;
using Finance_Management.Controllers.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Finance_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : Controller
    {
         
        private IRegistration objectdata;
        public RegistrationController (IRegistration objectdata)
        {
            this.objectdata = objectdata;
        }
        //IRegistrationController(IRegistrationDao iregistrationDao)
        //{
        //  iregistrationDao = iregistrationDao;
        //}
        
        [HttpGet]
        [Route("Registrationid")]
        public IActionResult GetById(int Registrationid)
        {
            
            var result = objectdata.GetById(Registrationid);
            return this.Ok(result);
        }
         [HttpGet]
         [Route("RegId")]
         public IActionResult GetAllDetails( int RegId)
        {
             
            var result = objectdata.GetAllDetails();
            return this.Ok(result);

            //ar result = RegistrationDao.GetAllDetails();
            //return this.Ok(result);
        }
        

    }

    public class RegId
    {
    }
}

