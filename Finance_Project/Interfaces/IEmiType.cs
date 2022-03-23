
using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;


namespace Finance_Project.DataAccessLayer
{
    public interface IEmiType
    {
        string Update(string duration);
        string Update(EmiType duration);
        string Update(Reposotory.EmiType duration);
    }
}
