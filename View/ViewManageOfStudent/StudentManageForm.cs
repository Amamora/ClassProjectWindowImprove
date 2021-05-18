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
            loadDatalist(selectGroupID);
            loadDatalist(selectSearchBox);

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
                    sc.groupID = selectGroupID.Text;
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

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (checkAll())
            {
                using (MyLinQDataContext db = new MyLinQDataContext())
                {
                    SCORE sc = new SCORE();


                    sc.score1 = float.Parse(scoreTxt.Text);
                    sc.evalute = descriptionTxt.Text;
                    sc.studentID = studentIDtxt.Text;
                    sc.groupID = selectGroupID.Text;
                    db.SCOREs.InsertOnSubmit(sc);
                    MessageBox.Show("Insert sucess!");
                    db.SubmitChanges();


                }
               
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void showStudentDataBtn_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                //show student follow select group ID =>

                var scource = from GROUPSUBJECT groupSub in db.GROUPSUBJECTs

                              join STUDENT stu in db.STUDENTs on groupSub.studentID equals stu.studentID
                              where groupSub.groupID == selectGroupID.Text
                              select new
                              {
                                  GroupID = groupSub.groupID,
                                  GroupName = groupSub.groupName,
                                  StudentID = stu.studentID,
                                  StudentName = stu.studentFName + " " + stu.studentLName,

                              };
                if (scource.Count() == 0)
                {
                    MessageBox.Show("Nodata");
                    return;
                }
                dataSubScoreView.DataSource = scource;


            }
        }

        private void showScoreDataBtn_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                var check = from GROUPSUBJECT gr in data.GROUPSUBJECTs
                            where gr.groupID == selectSearchBox.Text
                            select gr;
                if (check.Count() == 0)
                {
                    MessageBox.Show("ID Group not exist!");
                    selectSearchBox.Focus();
                    return;
                }

                var g = from GROUPSUBJECT sco in data.GROUPSUBJECTs

                        join STUDENT stu in data.STUDENTs
                        on sco.studentID equals stu.studentID
                        join SCORE score in data.SCOREs
                        on sco.groupID equals score.groupID

                        where sco.groupID == selectSearchBox.Text
                        select new
                        {
                            GroupName = sco.groupName,
                            GroupID = sco.groupID,
                            StudentName = stu.studentFName + " " + stu.studentLName,
                            TeacherID = sco.teacherID,
                            Score = score.score1

                        };
                dataSubScoreView.DataSource = g;

            }
        }
    }
}
