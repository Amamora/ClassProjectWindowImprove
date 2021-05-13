using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.DAO;
using WindowClassProject.Model;
using WindowClassProject.View.ViewCourse;
using WindowClassProject.View.ViewScore;
using WindowClassProject.View.ViewStudent;
using WindowClassProject.View.ViewTeacher;

namespace WindowClassProject.View.ViewManageStudent
{
    public partial class ManageForm : Form
    {
        private Random random;
        private Button currentButton;
        UserAccount nowUser = new UserAccount();
        public ManageForm()
        {
            random = new Random();
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
            UserAccountDAO us = new UserAccountDAO();

            if (us.loadImageForUserAccount(nowUser))
            {
                
                pictureBoxAccount.Image = us.ByteArrayToImage(nowUser.imageAccount);
            }
            random = new Random();
            hideSubMenu();
        }

        #region some method change color of button
        private int tempIndex;
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void activeBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                   disableBtn();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        }
        private  void disableBtn()
        {
            foreach (Control previousBtn in menuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = menuPanel.BackColor;
                    previousBtn.ForeColor = menuPanel.ForeColor;
                    previousBtn.Font = menuPanel.Font;
                }
            }
        }

        #endregion

        #region open child  in this child  form
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
           
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
            Application.Exit();
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
            activeBtn(sender);
            showSubMenu(openManagePanel);
            
        }

        private void openDashBtn_Click(object sender, EventArgs e)
        {
            activeBtn(sender);
        }

        private void openChartPanel_Click(object sender, EventArgs e)
        {
            activeBtn(sender);
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
           
        }

        private void openCoursePanelChild_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new CoursePanelForm());


        }

        private void openStudentPanelChild_Click(object sender, EventArgs e)
        {
      
            openChildFormInPanel(new StudentPanelForm());
        }

       

       
        private void expandPictureBox_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void openTeacherPanelChild_Click(object sender, EventArgs e)
        {
           
            openChildFormInPanel(new TeacherForm());
        }

        private void openScorePanelChild_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new Score_Form());
            
        }

        bool checkSub = false; 
        private void actionMenuPictureBox_Click(object sender, EventArgs e)
        {
            if (checkSub == false)
            {
                checkSub = true; 
                menuPanel.Width = menuPanel.Width / 2;

                openDashBtn.Text = "";
                openMailBoxPanel.Text = "";
                openManageBtn.Text = "";
                exitBtn.Text = "";
               
                openTimeTablePanel.Text = "";

                openStudentPanelChild.Text = "";
                openCoursePanelChild.Text = "";
                openTeacherPanelChild.Text = "";
                openScorePanelChild.Text = "";
                openClassPanelBtn.Text = "";
                openGroupSubjectPanel.Text = "";
            }
            else
            {
                checkSub = false;
                menuPanel.Width = menuPanel.Width * 2;
                openDashBtn.Text = "Dash Board";
                openMailBoxPanel.Text = "Mail Box";
                openManageBtn.Text = "Manage";
                exitBtn.Text = "Exit";
               
                openTimeTablePanel.Text = "Time Table";

                openStudentPanelChild.Text = "Student";
                openCoursePanelChild.Text = "Course";
                openTeacherPanelChild.Text = "Teacher";
                openScorePanelChild.Text = "Score";
                openClassPanelBtn.Text = "Class";
                openGroupSubjectPanel.Text = "Group Subject";
            }
           

        }

        private void openClassPanelBtn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ClassPanelForm());
        }

        private void openGroupSubjectPanel_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddGroupSubjectForm());
        }

        private void advanceToolPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notificationPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
