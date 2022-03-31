using Finance_Api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Finance_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : Controller
    {

        Fin_dbContext db = new Fin_dbContext();

        [HttpGet]
        [Route("Listr")]
        public IActionResult Listur()
        {
            var data = from UserRegistration in db.UserRegistration select UserRegistration;
            return Ok(data);
        }

        [HttpGet]
        [Route("Listr/{username}")]                
        public IActionResult GetResult(string? username)
        {
            if (username == null)
            {
                return BadRequest("Username Cannot be null");
            }
  

             
            var data = db.UserRegistration.Where(d => d.UserName == username).Select(d => new
            {
                FullName = d.FullName,
                Dob = d.Dob,
                PhoneNumbero = d.PhoneNumber,
                Email = d.Email,
                UserName = d.UserName,
                AccPassword = d.AccPassword,
                ConfirmPassword = d.ConfirmPassword,
                HomeAddress = d.HomeAddress,
                CardType = d.CardType,
                BankName = d.BankName,
                AccountNumber = d.AccountNumber,
                Ifsccode = d.IfscCode,
                 
            }).FirstOrDefault();
            if (data == null)
            {
                return NotFound($"Registered user {username} Not Found");
            }
            return Ok(data);
        }


        [HttpPost]
        [Route("Adduser")]

        public IActionResult Adduser([FromBody] UserRegistration userregistration)
        {

            if (ModelState.IsValid)
            {
                var userObj = db.UserRegistration.Where(d => d.UserName == userregistration.UserName).Select(d => new
                {
                    FullName = d.FullName,
                    Dob = d.Dob,
                    PhoneNumbero = d.PhoneNumber,
                    Email = d.Email,
                    UserName = d.UserName,
                    AccPassword = d.AccPassword,
                    ConfirmPassword = d.ConfirmPassword,
                    HomeAddress = d.HomeAddress,
                    CardType = d.CardType,
                    BankName = d.BankName,
                    AccountNumber = d.AccountNumber,
                    Ifsccode = d.IfscCode,

                }).FirstOrDefault();

                if (userObj == null)
                {
                    try
                    {
                        db.UserRegistration.Add(userregistration);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        return StatusCode(400, "Unable to register user");
                    }
                    return StatusCode(200, "User Registration successful");

                } else
                {
                    return StatusCode(409, $"User '{userregistration.UserName}' already exists");

                }
            }
            return StatusCode(400, "Somethong went wrong");
        }

        [HttpPost]
        [Route("Loginuser")]
        public IActionResult Loginuser([FromBody] User user)
        {

            var isexist = db.UserRegistration.Any(b => b.UserName == user.UserName && b.AccPassword == user.AccPassword );
            if (isexist)
            {
                return Ok(isexist);
            }
            return Unauthorized(isexist);
        }

    }
}
