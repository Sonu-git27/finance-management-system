using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;
using Finance_Project.Reposotory;
using Microsoft.EntityFrameworkCore;
using Finance_Project.DataAccessLayer;
using System;
using EmiType = Finance_Project.Reposotory.EmiType;
//using Finance_Project.BussinessAccessLayer;


namespace Finance_Project.DataAccessLayer
{
    public class EmiTypeDao : IEmiType
    {
        private financedbContext db;

        internal static object UpdateDuration()
        {
            throw new NotImplementedException();
        }

        public EmiTypeDao(financedbContext financeDbContext)
        {
            db = financeDbContext;
        }
         //string IEmiType.Update(EmiType duration)
         //{

           // this.db.Emitype.Update(duration);
           // this.db.SaveChanges();
            
        // }

        public string Update(string duration)
        {
            throw new NotImplementedException();
        }

        public string Update(BussinessAccessLayer.EmiType duration)
        {
            throw new NotImplementedException();
        }

        public string Update(EmiType duration)
        {
            throw new NotImplementedException();
        }
    }
}
