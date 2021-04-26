using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer
{
    public class Customers
    {
        public Customers() { }
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string Entrydate { set; get; }
        public string Pic { set; get; }
        public int Uid { set; get; }
    }
}
