using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.Reposotory;
using Microsoft.EntityFrameworkCore;
using EmiTable = Finance_Project.BussinessAccessLayer.EmiTable;
using System;

namespace Finance_Project.DataAccessLayer
{
    public class EmiTableDao : IEmiTable
    {
        private financedbContext db;
        public EmiTableDao(financedbContext financeDbContext)
        {
            this.db = financeDbContext;
             
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public EmiTable GetByid(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(int id)
        {
            throw new NotImplementedException();
        }
    }

    public EmiTableDao GetById(int id)
        {
            EmiTableDao EmiTable1 = null;
            try
            {
                using (var db = new financedbContext())
                {
                    DbSet<EmiTable> allProducts = db.emiTable;
                    var matchingEmiId = allProducts.Where(p => p.EmiId == id);
                    if (matchingEmiId != null && matchingEmiId.Count() > 0)
                    {
                        EmiTable emiTable = matchingEmiId.First<EmiTable>();
                         EmiTable1 = new emiTable
                        {
                            EmiId = emiTable.EmiId,
                             EmiAmount = emiTable.EmiAmount,    
                             EmitypeId = emiTable.EmitypeId,
                             Orderid = emiTable.Orderid,
                             RegId = emiTable.RegId,
                             Paymentid = emiTable.Paymentid,
                        };
                    }
                }
                return EmiTable1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        
    }
}
