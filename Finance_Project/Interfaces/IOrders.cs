using Finance_Project.BussinessAccessLayer;
using System;

namespace Finance_Project
{
    public interface IOrders
    {

        int Update(DateTime Orderdate);
        
        Orders FetchByid(int id);
    }
}
    

