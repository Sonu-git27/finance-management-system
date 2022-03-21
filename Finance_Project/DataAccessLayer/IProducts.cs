using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;

namespace Finance_Project.DataAccessLayer
{
    public interface IProducts
    {
         
        Products GetProductId(int id);
        int Add(Products product);
        int Update(Products product);
        int Update(Reposotory.Products products);
    }
}
