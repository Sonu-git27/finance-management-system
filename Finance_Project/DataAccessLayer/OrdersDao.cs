using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.DataAccessLayer;
using Finance_Project.Reposotory;


namespace Finance_Project.DataAccessLayer
{
    public class OrdersDao
    {


        private financedbContext db;
        

        public OrdersDao(financedbContext financeDbContext)
        {
            db = financeDbContext;
        }

        internal static object UpdateOrderdate()
        {
            throw new NotImplementedException();
        }

        internal static object fetchById()
        {
            throw new NotImplementedException();
        }

        public int Update( Orders Orderdate)
        {
            this.db.Orders.Update(Orderdate);
            this.db.SaveChanges();

            throw new NotImplementedException();
        }
    }
}
