using INVENTORY.Business_layer;
using INVENTORY.Presentation_layer.User_controlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY.Presentation_layer
{
    public partial class Homepage : MetroFramework.Forms.MetroForm
    {
        Users use= new Users();
        string Path;
        public Homepage( Users u)
        {
            use = u;
            
            InitializeComponent();

            try
            {
                if (use.Pic != null)
                {
                    Path = use.Pic;
                    Image image = Image.FromFile(use.Pic);
                    this.pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            if (use.Type == "Owner")
            {
                Categorybtn.Visible = true;
            }
            else
            {
                Categorybtn.Visible = false;
            }

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

      
        private void Categorybtn_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            panel3.Controls.Clear();
            panel3.Controls.Add(cat);
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            Employee cat = new Employee();
            panel3.Controls.Clear();
            panel3.Controls.Add(cat);

        }

        private void Customerbtn_Click(object sender, EventArgs e)
        {
           Customer cat = new Customer();
            panel3.Controls.Clear();
            panel3.Controls.Add(cat);
        }

        private void Supplierbtn_Click(object sender, EventArgs e)
        {
            Supliercontrol cat = new Supliercontrol();
            panel3.Controls.Clear();
            panel3.Controls.Add(cat);
        }

        private void Ownerbtn_Click(object sender, EventArgs e)
        {
            Ownercontrol owner = new Ownercontrol();
            panel3.Controls.Clear();
            panel3.Controls.Add(owner);
        }
    }
}
