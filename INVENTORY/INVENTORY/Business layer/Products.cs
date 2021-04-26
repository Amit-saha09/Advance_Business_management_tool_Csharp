using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer
{
    public class Products
    {
        public Products() { }
        public int Id { set; get; }
        public string Name { set; get; }
        public int Cost { set; get; }
        public int Price { set; get; }
        public int Quantity { set; get; }
        public int Totalcost { set; get; }
        public int Totalprice { set; get; }
        public int Netprofit { set; get; }
        public int Threatcall { set; get; }
        public string Pic { set; get; }
        public int Cid { set; get; }
    }
}
