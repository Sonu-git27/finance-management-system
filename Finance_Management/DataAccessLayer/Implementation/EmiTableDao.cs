using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Finance_Management.BusinessAccessLayer;
using System.Collections.Generic;
using Finance_Management.Repository;
using EmiTable = Finance_Management.BusinessAccessLayer.EmiTable;

namespace Finance_Management.DataAccessLayer.Implementation
{
    public class EmiTableDao : IEmiTable
    {

        private FinanceDbContext db;
        public EmiTableDao(FinanceDbContext financeDbContext)
        {
            db = financeDbContext;
        }

        public EmiTable FetchbyId(int id)
        {
            return db.EmiTable.Where(p => p.emi_id == id).First<EmiTable>();
        }

        public BusinessAccessLayer.EmiTable FetchByid(int id)
        {
            throw new NotImplementedException();
        }

        public object FetchById()
        {
            throw new NotImplementedException();
        }
    }
}
