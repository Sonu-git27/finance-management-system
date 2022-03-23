using Finance_Management.BusinessAccessLayer;
using Finance_Management.DataAccessLayer.Implementation;
using Finance_Management.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
 


namespace Finance_Management.DataAccessLayer
{
    public class OrdersDao
    {


        private FinancedbContext db;
        

        public OrdersDao(FinancedbContext financeDbContext)
        {
            db = financeDbContext;
        }

         

        internal static object fetchById()
        {
            throw new NotImplementedException();
        }

         
    }
}
