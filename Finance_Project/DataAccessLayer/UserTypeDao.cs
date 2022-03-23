using System;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.DataAccessLayer;
using Finance_Project.Reposotory;


namespace Finance_Project.DataAccessLayer
{
    public class UserTypeDao : IuserType
    {

        private financedbContext db;


        public UserTypeDao(financedbContext financeDbContext)
        {
            db = financeDbContext;
        }

        public int Update(UserType id)
        {
            this.db.UserType.Update( id);
            this.db.SaveChanges();

            throw new NotImplementedException();
        }

        public int Update(BussinessAccessLayer.UserType id)
        {
            throw new NotImplementedException();
        }
    }
}
