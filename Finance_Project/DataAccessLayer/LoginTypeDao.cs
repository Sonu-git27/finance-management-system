using System;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.DataAccessLayer;
using Finance_Project.Reposotory;


namespace Finance_Project.DataAccessLayer
{
    public class LoginTypeDao : ILoginType
    {

        private financedbContext db;
        public LoginTypeDao(financedbContext financeDbContext)
        {
            db = financeDbContext;
        }

         public int Update(Logintype password)
        {
            this.db.Logintype.Update(password);
            this.db.SaveChanges();

            throw new NotImplementedException();
        }

        public void Delete(Logintype userid)
        {
            this.db.Remove(userid);
            this.db.SaveChanges();
        }



    }


}
