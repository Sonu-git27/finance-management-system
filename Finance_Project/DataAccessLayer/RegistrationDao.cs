using Finance_Project.BussinessAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Finance_Project.DataAccessLayer;
using Finance_Project.Reposotory;
using Registration = Finance_Project.BussinessAccessLayer.Registration;


namespace Finance_Project.Controllers.DataAccessLayer
{
    public class RegistrationDao
    {
        public class RegistrationDao : IRegistration, IRegistrationDao
        {
            private financedbContext db;
            private RegistrationDao registration;

            public RegistrationDao()
            {
            }

            public RegistrationDao(financedbContext financedbContext)
            {
                db = financedbContext;
            }
            public int AddOne(Registration registration)
            {
                using (this.db)
                {
                    db.Registration.Add(registration);
                    return db.SaveChanges();
                }


                public RegistrationDao GetById(int id, IEnumerable<object> allRegistration)
                {
                    Registration Registrations = null;
                    try
                    {
                        using (var financedb = new financedbContext())
                        {
                            DbSet<Reposotory.Registration> allRegistrations = financedb.Registration;
                            var matchingRegistration = allRegistration.Where(r => r.Reg_id == id);
                            if (matchingRegistration != null && matchingRegistration.Count() > 0)
                            {
                                Registration registration = matchingRegistration.First<Registration>();
                                Registrations = new Registration
                                {
                                    FullName = registration.FullName,
                                    Email = registration.Email,
                                    Number = registration.Number,
                                    Address = registration.Address,
                                    Reg_id = registration.Reg_id,
                                    Cardtype = registration.Cardtype,
                                    Bank = registration.Bank,
                                    Accno = registration.Accno,
                                    IFSC_code = registration.IFSC_code,
                                    Userid = registration.Userid,
                                };
                            }
                        }
                        return registration;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
