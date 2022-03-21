using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Finance_Project.BussinessAccessLayer
{
    public class Orders
    {

        public  int Orderid { get; set; }
        public decimal OrderAmount { get; set; }
        public string Orderdate { get; set; }
        public int RegId { get; set; }
        public int ProductId { get; set; }

    }
}
