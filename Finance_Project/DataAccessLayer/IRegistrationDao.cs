using System.Collections.Generic;

namespace Finance_Project.Controllers.DataAccessLayer
{
    public interface IRegistrationDao
    {
        RegistrationDao.RegistrationDao GetById(int id, IEnumerable<object> allRegistration);
    }
}