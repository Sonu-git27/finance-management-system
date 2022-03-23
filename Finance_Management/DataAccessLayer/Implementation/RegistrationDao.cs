using System.Linq;
using System.Collections.Generic;
using Finance_Management.Repository;

namespace Finance_Management.Controllers.DataAccessLayer
{
    public class RegistrationDao: IRegistration
    {
        private FinanceDbContext db;

        public RegistrationDao(FinanceDbContext  _db)
        {
            db =  _db;
        }

        public List<Registration> GetAllDetails()
        {
            return db.Registration.ToList<Registration>();
        }

        public Registration GetById(int id)
        {
            return db.Registration.Where(p => p.RegId == id).First<Registration>();
        }







        //public RegistrationDao()
        //{
        //}

        //public decimal id { get; private set; }

        //public List<Registration> AllDetails => db.Registration.ToList<Registration>();






    }
}

