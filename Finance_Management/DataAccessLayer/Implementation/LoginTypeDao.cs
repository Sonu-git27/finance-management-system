using Finance_Management.Repository;
using Finance_Management.DataAccessLayer.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
 


namespace Finance_Management.DataAccessLayer
{
    public class LoginTypeDao : ILoginType
    {

        private FinanceDbContext db;
        public LoginTypeDao(FinanceDbContext financeDbContext)
        {
            db = financeDbContext;
        }

        public void Delete(Logintype userid)
        {
            throw new NotImplementedException();
        }

        public int Update(Logintype password)
        {
            throw new NotImplementedException();
        }
    }


}
