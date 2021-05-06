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
            hidePictureBox.Visible = false;
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
            if (userTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Need to fill al data", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UserAccountDAO dataUser = new UserAccountDAO();
                UserAccount user = new UserAccount();

                user = dataUser.loginUserAccount(userTxt.Text, passTxt.Text);
                if (user == null)
                {
                    return;
                }
                if (user.typeID == 3)
                {
                    ManageForm mana = new ManageForm(user.userAccountID, user.userAccount, user.password, user.typeID);
                    mana.FormClosed += (s, args) => this.Close();
                    mana.Show();
                }
                if (user.typeID == 1)
                {

                }

                

            }
            
            
           
        }

        private void showPictureBox_Click(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = true;
            showPictureBox.Visible = false;
            hidePictureBox.Visible = true;
        }

        private void hidePictureBox_Click(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = false;
            showPictureBox.Visible = true;
            hidePictureBox.Visible = false;
        }
        //

    }
}
