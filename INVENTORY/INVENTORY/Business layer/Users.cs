using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer
{
   public class Users
    {
        public Users() { }
        public int Userid { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string Type { set; get; }
        public string Email { set; get; }
        public string Pic { set; get; }
        public string Address { set; get; }
        public string Description { set; get; }
        public string Modifydate { set; get; }
    }
}
