﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Project.Reposotory
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public decimal ProductId { get; set; }
        public string Name { get; set; }
        public string name { get; internal set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
