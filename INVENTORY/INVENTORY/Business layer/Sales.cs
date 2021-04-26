using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer
{
    public class Sales
    {
        public Sales() { }
        public int Id { set; get; }
        public string Description { set; get; }
        public int Totalcost { set; get; }
        public int Uid { set; get; }
        public int Empid { set; get; }
        public int Cusid { set; get; }
    }
}
