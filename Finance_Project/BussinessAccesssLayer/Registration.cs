﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace Finance_Project.BussinessAccessLayer
{
    public class Registration
    {
        internal object IFSC_code;
        internal object Reg_id;

        public string FullName { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public decimal RegId { get; set; }
        public string Cardtype { get; set; }
        public string Bank { get; set; }
        public string Accno { get; set; }
        public string IfscCode { get; set; }
        public int Userid { get; set; }

        internal static IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        internal static void Delete(object item)
        {
            throw new NotImplementedException();
        }
    }
}
