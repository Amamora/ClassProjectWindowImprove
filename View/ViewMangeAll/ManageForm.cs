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
using WindowClassProject.View.ViewCourse;

namespace WindowClassProject.View.ViewManageStudent
{
    public partial class ManageForm : Form
    {
        UserAccount nowUser = new UserAccount();
        public ManageForm()
        {
            InitializeComponent();
        }
        public ManageForm(int userAccountID,string userAccount,string password,int typeID)
        {
            InitializeComponent();
            nowUser.userAccount = userAccount;
            nowUser.userAccountID = userAccountID;
            nowUser.password = password;
            nowUser.typeID = typeID;


            if (nowUser.typeID == 3)
            {
                openCoursePanelChild.Visible = false;
               
                openTeacherPanelChild.Visible = false;
                openManagePanel.Height=150;
            }
            


        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    

        #region open child  in this child  form
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


         public void changeSelectButton(Button bu)
            {
            bu.BackColor = Color.Blue;
            bu.ForeColor = Color.White;
            }
        public void restartColorButton(Button bu)
        {
            bu.BackColor = menuPanel.BackColor;
            bu.ForeColor = Color.Silver;

        }


        private void hideSubMenu()
        {
            openManagePanel.Visible = false;
            

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region action button click
        private void openManageBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(openManagePanel);
        }

        private void openDashBtn_Click(object sender, EventArgs e)
        {
            changeSelectButton(openDashBtn);
        }

        private void openChartPanel_Click(object sender, EventArgs e)
        {

        }

        private void openTimeTablePanel_Click(object sender, EventArgs e)
        {

        }

        private void openMailBoxPanel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void openDashBtn_MouseCaptureChanged(object sender, EventArgs e)
        {
            restartColorButton(openDashBtn);
        }

        private void openCoursePanelChild_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CoursePanelForm());


        }
    }
}
