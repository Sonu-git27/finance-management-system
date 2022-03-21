using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.Reposotory;
using Microsoft.EntityFrameworkCore;


namespace Finance_Project.DataAccessLayer
{
    public class EmiTypeDao : IEmiType
    {
        private FinanaceDbContext db;
        public EmiTypeDao(FinanceDbContext financeDbContext)
        {
            this.db = financeDbContext;
            
        }
         

        public string Update(string duration)
        {

            object Emiduration = null;
            this.db.EmiType.Update(Emiduration);
            this.db.SaveChanges();
            throw new System.NotImplementedException();
        }
    }
}
