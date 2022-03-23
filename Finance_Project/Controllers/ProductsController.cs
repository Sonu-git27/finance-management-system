using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Finance_Project.BussinessAccessLayer;
using Microsoft.EntityFrameworkCore;
using Finance_Project.DataAccessLayer;

namespace Finance_Project.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet]
        [Route("fetchById")]

        public IActionResult FetchbyId(int id)
        {
            var fetchedData = ProductsDao.FetchAllProductsId();
            return Ok(fetchedData);

            
        }

        [HttpPost]
        [Route("insertproducts")]

        public IActionResult InsertProducts()
        {
            var products = ProductsDao.InsertProducts();
            return this.Ok(products);
        }


            
    }
}
