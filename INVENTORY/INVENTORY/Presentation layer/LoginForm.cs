using INVENTORY.Business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using INVENTORY.Business_layer.EntityDataAccess;

namespace INVENTORY.Presentation_layer
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        Users user;
        SpeechSynthesizer sys;
        Userdataaccess a;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            sys = new SpeechSynthesizer();
            user = new Users();
            sys = new SpeechSynthesizer();
            string nam = usernamebox.Text;
            string pass = passwordbox.Text;

            // try
            //   { 
            a = new Userdataaccess();
            user = a.GetthatUser(nam);
            //Userid = a.GetUserid(user);

            if (pass == user.Password)
            {
                int U = user.Userid;
                // Userid = a.GetUserid(user);
                sys.Speak(user.Name+"Login is successfull");

                MessageBox.Show("login is successfull");

                Homepage home = new Homepage(user);
                this.Dispose();
                home.ShowDialog();

                
            }
            else
            {
                sys.Speak("unsuccessfull");
                MessageBox.Show("REtry");


                //sys.Speak("unsuccessfull");
            }


        }
    }
}
