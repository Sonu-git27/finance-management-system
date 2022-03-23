using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.Reposotory;
using Microsoft.EntityFrameworkCore;
using System;
using EmiTable = Finance_Project.BussinessAccessLayer.EmiTable;

namespace Finance_Project.DataAccessLayer
{
    public class EmiTableDao : IEmiTable
    {





        private financedbContext db;
        public EmiTableDao(financedbContext financeDbContext)
        {
            db = financeDbContext;
        }

        internal static object FetchAllProductsId()
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        internal static object UpdateAmount()
        {
            throw new NotImplementedException();
        }

        public EmiTable FetchByid(int id)
        {
            throw new NotImplementedException();
        }

        public BussinessAccessLayer.EmiTable GetByid(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(int id)
        {
            throw new NotImplementedException();
        }

        public static implicit operator EmiTableDao(EmiTable v)
        {
            throw new NotImplementedException();
        }

        public EmiTableDao GetId(int id)
        {
            EmiTableDao EmiTable1 = null;
            try
            {
                using (var db = new financedbContext())
                {
                    DbSet<EmiTable> allProducts = GetAllProducts();
                    var matchingEmiId = allProducts.Where(p => p.EmiId == id);
                    if (matchingEmiId != null && matchingEmiId.Count() > 0)
                    {
                        EmiTable emiTable = matchingEmiId.First<EmiTable>();
                        EmiTable1 = new EmiTable
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

        private DbSet<EmiTable> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        private static DbSet<Reposotory.EmiTable> GetAllProducts(financedbContext db)
        {
            return db.EmiTable;
        }
    }
}
