using System.Linq;
using Finance_Project.Reposotory;
using System.Collections.Generic;
using System;

namespace Finance_Project.Controllers.DataAccessLayer
{
    public class RegistrationDao
    {
        private financedbContext db;

        public RegistrationDao(financedbContext financeDbContext)
        {
            db = financeDbContext;
        }

        public RegistrationDao()
        {
        }

        public decimal id { get; private set; }

        public List<Registration> GetAllDetails()
        {
            return db.Registration.ToList<Registration>();
        }

        public Registration GetById(int id, int id1)
        {
            return db.Registration.Where(p => p.RegId == id).First<Registration>();
        }

        internal static object GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

