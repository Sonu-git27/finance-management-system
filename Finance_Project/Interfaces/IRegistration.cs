using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;

namespace Finance_Project
{
    public interface IRegistration
    {
        Registration GetById(int id);
        Registration GetAllDetails();
    }
}
