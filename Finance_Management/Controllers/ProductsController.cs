using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
 
using Finance_Management.Repository;
using Finance_Management.DataAccessLayer;
using System;

namespace Finance_Management.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        //private IProducts db;
        //public ProductsController(IProducts db)
        //{
        //    this.db = db;
        //}




        //[HttpGet]
        //[Route("fetchById")]

        //public IActionResult FetchbyId(int id)
        //{
        //    var fetchedData = db.FetchbyId();
        //    return Ok(fetchedData);

            
        //}

        //[HttpPost]
        //[Route("insertproducts")]

        //public IActionResult InsertProducts(Products AddProducts)
        //{
        //    var products = db.InsertProducts(AddProducts);
        //    return this.CreatedAtAction("InsertProducts");
        //}

        //private IActionResult CreatedAtAction(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
