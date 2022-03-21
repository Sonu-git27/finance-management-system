using Finance_Project.BussinessAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.DataAccessLayer;
using Finance_Project.Reposotory;
using Products = Finance_Project.Reposotory.Products;

namespace Finance_Project.DataAccessLayer
{
    public class ProductsDao : IProducts
    {
        private financedbContext db;
        public ProductsDao(financedbContext financedbContext)
        {
            db = financedbContext;
        }
        public bool InsertProduct(Products ProductObj)
        {
            int result = 0;
            try
            {
                using (var db = new financedbContext())
                {
                    DbSet<Products> allProducts = db.Products;
                    Products entityModelObject = new Products
                    {
                        ProductId = ProductObj.ProductId,
                        Name =ProductObj.Name,
                        Price = ProductObj.Price,
                        Image = ProductObj. Image,
                        Status = ProductObj.Status,
                    };
                    allProducts.Add(entityModelObject);
                    result = db.SaveChanges();
                }
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public ProductsDao GetProductById(int id)
        {
            ProductsDao Product = null;
            try
            {
                using (var db = new financedbContext())
                {
                    DbSet<Products> allProducts = db.Products;
                    var matchingProducts = allProducts.Where(p => p.ProductId == id);
                    if (matchingProducts != null && matchingProducts.Count() > 0)
                    {
                        Products product = matchingProducts.First<Products>();
                        Product = new Products
                        {
                            ProductId = product.ProductId,
                            Name = product.name,
                            Price = product.Price.Value,
                            Image = product.Image,
                            Status = product.Status,
                        };
                    }
                }
                return Product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<BussinessAccessLayer.Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public BussinessAccessLayer.Products GetProductId(int id)
        {
            throw new NotImplementedException();
        }



        public static implicit operator ProductsDao(Products v)
        {
            throw new NotImplementedException();
        }
        public int Add(BussinessAccessLayer.Products product)
        {
            throw new NotImplementedException();
        }

        public int Update(BussinessAccessLayer.Products product)
        {
            throw new NotImplementedException();
        }

        public int Update(Products products)
        {
            throw new NotImplementedException();
        }


























    }
}
