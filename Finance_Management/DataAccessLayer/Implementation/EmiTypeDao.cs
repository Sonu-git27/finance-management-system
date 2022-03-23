 
using System.Collections.Generic;
 
using Microsoft.EntityFrameworkCore;
using Finance_Management.DataAccessLayer;
using System;
using Finance_Management.BusinessAccessLayer;
using Finance_Management.DataAccessLayer.Implementation;

//using Finance_Project.BussinessAccessLayer;


namespace Finance_Management.DataAccessLayer
{
    public class EmiTypeDao : IEmiType
    {
        private FinanceDbContext db;

        

        public EmiTypeDao(FinanceDbContext financeDbContext)
        {
            db = financeDbContext;
        }
       

        
        
    }
}
