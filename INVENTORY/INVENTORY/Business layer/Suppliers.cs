using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer
{
    public class Suppliers
    {
        public Suppliers() { }
        public int Id { set; get; }
        public string Name { set; get; }
        public string Country { set; get; }
        public string Address { set; get; }
        public string Pic { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
    }
}
