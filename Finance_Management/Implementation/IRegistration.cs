
using Finance_Management.DataAccessLayer;
using Finance_Management.Repository;
using System.Collections.Generic;

namespace Finance_Management
{
    public interface IRegistration
    {
       
        Registration GetById(int id);
        List<Registration>GetAllDetails();
        void Add(Registration registration);
    }
}
