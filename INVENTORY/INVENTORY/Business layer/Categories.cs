using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer
{
   public class Categories
    {
        public Categories() { }
        public int Id { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
        public string Pic { set; get; }
        public string Entrydate { set; get; }
        public string Company { set; get; }
        public int Supid { set; get; }
    }
}
