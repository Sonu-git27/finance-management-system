using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Finance_Project.BussinessAccessLayer
{
    public class EmiTable
    {
        public  int EmiId { get; set; }
        public decimal EmiAmount { get; set; }
        public  int EmitypeId { get; set; }
        public int Orderid { get; set; }
        public int RegId { get; set; }
        public  int Paymentid { get; set; }

    }
}
