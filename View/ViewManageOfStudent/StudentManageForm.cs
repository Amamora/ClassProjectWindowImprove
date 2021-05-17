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

namespace WindowClassProject.View.ViewManageOfStudent
{
    public partial class StudentManageForm : Form
    {
        public StudentManageForm()
        {
            InitializeComponent();
        }
        public StudentManageForm(int userAccountID, string userAccount, string password, int typeID)
        {
            
            InitializeComponent();
            nowUser.userAccount = userAccount;
            nowUser.userAccountID = userAccountID;
            nowUser.password = password;
            nowUser.typeID = typeID;

          
            TeacherDAO dao = new TeacherDAO();
            dao.getTeacherByAccountID(nowUser.userAccountID, teacher);

           

        }
        UserAccount nowUser = new UserAccount();
        TeacherModel teacher = new TeacherModel();
        private void StudentManageForm_Load(object sender, EventArgs e)
        {

            UserAccountDAO us = new UserAccountDAO();

            if (us.loadImageForUserAccount(nowUser))
            {

                pictureAccountBox.Image = us.ByteArrayToImage(teacher.picture);
            }
            loadDatalist(listGroupIDCheck);
            loadDatalist(selectGroupIDEdit);

        }

        public void loadDatalist(ComboBox selectGroupID)
        {
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                //load groupID

                var souceGroupID = from GROUPSUBJECT g in db.GROUPSUBJECTs
                                  where g.teacherID==teacher.teacherID
                                   select g;


                selectGroupID.DataSource = souceGroupID;
                selectGroupID.DisplayMember = "groupID";
            }
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (checkAll())
            {
                using (MyLinQDataContext db = new MyLinQDataContext())
                {
                    SCORE sc = new SCORE();


                    sc.score1 = float.Parse(scoreTxt.Text);
                    sc.evalute = descriptionTxt.Text;
                    sc.studentID = studentIDtxt.Text;
                    sc.groupID = selectGroupIDEdit.Text;
                    db.SCOREs.InsertOnSubmit(sc);
                    MessageBox.Show("Insert sucess!");
                    db.SubmitChanges();


                }
               
            }
        }
        public bool checkAll()
        {
            if (scoreTxt.Text.Trim() == "" || studentIDtxt.Text.Trim() == "")
            {
                return false;
            }

            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                var stud = from STUDENT s in db.STUDENTs
                           where s.studentID == studentIDtxt.Text
                           select s;
                if (stud.Count() == 0)
                {
                    MessageBox.Show("STUDENT ID NOT EXISTS!");

                }
                //tu student id=> groupsubject =>core

                var src = from SCORE sc in db.SCOREs
                          join GROUPSUBJECT gr in db.GROUPSUBJECTs on sc.groupID equals gr.groupID
                          where gr.studentID == studentIDtxt.Text && sc != null
                          select sc;
                if (src.Count() > 0)
                {
                    MessageBox.Show("HAVE DATA about score student in that course");
                    return false;
                }
            }
            return true;
        }

        private void checkAllStudentBtn_Click(object sender, EventArgs e)
        {
            AllStudentManage mana = new AllStudentManage();
            mana.Show();

        }
    }
}
