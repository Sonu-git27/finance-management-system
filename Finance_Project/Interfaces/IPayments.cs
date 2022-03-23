using Finance_Project.BussinessAccessLayer;
using System.Collections.Generic;



namespace Finance_Project.DataAccessLayer
{
    public interface IPayments
    {

        int Update(decimal DownPayment);
        PaymentsDao GetByid(int id);
    }
}
