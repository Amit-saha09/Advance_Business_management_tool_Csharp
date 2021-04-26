using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INVENTORY.Business_layer.EntityDataAccess;

namespace INVENTORY.Presentation_layer.User_controlls
{
    public partial class Ownercontrol : UserControl
    {
        Userdataaccess ab;
        public Ownercontrol()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            ab = new Userdataaccess();
            usergrid.DataSource = ab.GetAllUsers();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adduser add = new Adduser();
            add.ShowDialog();
            load();
            
        }
    }
}
