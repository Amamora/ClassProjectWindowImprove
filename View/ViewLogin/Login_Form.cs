using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.Model;
using WindowClassProject.View.ViewManageStudent;
using WindowClassProject.DAO;

namespace WindowClassProject.View.ViewLogin
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void userTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                passTxt.Focus();



            }
        }

        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                loginBtn_Click(sender, e);
            }

        }

        //check valid


       public  void loginBtn_Click(object sender, EventArgs e)
        {
          
            
            
           
        }
    }
}
