using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer
{
    public class Employees
    {
        public Employees() { }
        public int Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Hiredate { set; get; }
        public int Salary { set; get; }
        public string Pic { set; get; }
        public int Uid { set; get; }
    }
}
