using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;

namespace Finance_Project.DataAccessLayer
{
    public interface IEmiTable
    {
        int Update(int id);
        int Delete(int id);
        EmiTable FetchByid(int id);
    }
}
