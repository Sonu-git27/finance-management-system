﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Finance_Project.BussinessAccessLayer
{
    public class Payments
    {
        public int Paymentid { get; set; }
        public decimal Downpayment { get; set; }
        public decimal Remainingbalance { get; set; }
        public int Orderid { get; set; }

    }
}
