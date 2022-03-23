using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Finance_Project.BussinessAccessLayer
{
    public class Products
    {
        private string v1;
        private string v2;
        private int v3;
        private int v4;

        public Products(string v1, string v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public  int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
    }
}
