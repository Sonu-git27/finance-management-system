
using Finance_Management.BusinessAccessLayer;
using System;

namespace Finance_Management
{
    public interface IOrders
    {

        int Update(DateTime Orderdate);
        
        Orders FetchByid(int id);
        object fetchById();
    }
}
    

