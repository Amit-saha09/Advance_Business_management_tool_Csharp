using INVENTORY.Business_layer;
using INVENTORY.Business_layer.EntityDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace INVENTORY.Presentation_layer
{
    public partial class Adduser : MetroFramework.Forms.MetroForm
    {
        Userdataaccess ab;
        SpeechSynthesizer b;


        public Adduser()
        {
            InitializeComponent();
        }

        string Path;
        static int count;

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Random r = new Random();
                Random ab = new Random();
                Random ac = new Random();

                count = r.Next(100) * ab.Next(30) * ac.Next(110);
                userpicbox.Image = new Bitmap(fd.FileName);
                userpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
                Path = @"C:\Users\ASUS\Desktop\assignmentpic\" + count + ".jpg";
                File.Copy(fd.FileName, Path);





            }

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            b = new SpeechSynthesizer();
            if (namebox.Text == "" || passbox.Text == "" || confirmpassbox.Text == "" || emailbox.Text == "" || addressbox.Text == "" || typebox.Text == "")
            {
                MessageBox.Show("Please fill all boxs");

            }
            else if (passbox.Text != confirmpassbox.Text)
            {
                MessageBox.Show("Confarm passward and passward must be same");
            }
            else
            {
                ab = new Userdataaccess();
                Users use = new Users();
                use.Name = namebox.Text;
                use.Password = passbox.Text;
                use.Type = typebox.Text;
                use.Email = emailbox.Text;
                use.Pic = Path;
                use.Address = addressbox.Text;
                int result = ab.AddUser(use);
                if (result == 1)
                {
                    b.Speak("User Added");

                    MessageBox.Show("User Added. Now you can login with your passward");

                    



                }
                else
                {
                    b.Speak("Error");
                    MessageBox.Show("Error");
                }

            }
            this.Dispose();

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
