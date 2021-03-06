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
            loadDatalist(groupIDChart);
         

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
                          where  sc.studentID==studentIDtxt.Text && sc.groupID==gr.groupID
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
            AllStudentManage mana = new AllStudentManage(listGroupIDCheck.Text);
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
                              join SCORE score in db.SCOREs on groupSub.groupID equals score.groupID
                              join STUDENT stu in db.STUDENTs on score.studentID equals stu.studentID
                              where groupSub.groupID == selectSearchBox.Text
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

            }
            ScoreDAO sco = new ScoreDAO();
            dataSubScoreView.DataSource = sco.connectData(selectSearchBox.Text);
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            chartShow.Series.Clear();
            LoadDataChart(groupIDChart.Text);
        }
        Color pass;
        Color fail;

        private void LoadDataChart(string groupID)
        {

            chartShow.Series.Add("s1");
            chartShow.Titles.Add("The rate");
            chartShow.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
         Color   pass = System.Drawing.Color.CornflowerBlue;
          Color fail = System.Drawing.Color.Pink;

            double totalPass= 0;
            double totalFail = 0;
            double totalStudent = 0;
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                var countPass = from SCORE ss in db.SCOREs
                                where ss.score1>5 && ss.groupID==groupID
                                select ss;

                var totalCount = from SCORE ss in db.SCOREs
                                 where ss.groupID==groupID
                                 select ss;
                totalPass = countPass.Count();
                totalStudent = totalCount.Count();
               totalFail = totalCount.Count() - totalPass;

                GROUPSUBJECT groupName = db.GROUPSUBJECTs.Single(p => p.groupID == groupID);

                groupNameLbl.Text = "GROUP NAME : " + groupName.groupName;
            }
            double maleStudentsPercentage = (totalPass * (100 / totalStudent));
            double femaleStudentsPercentage = (totalFail* (100 / totalStudent));

            totalPassLbl.Text = ("  Pass : " + (maleStudentsPercentage.ToString("0.00") + "%"));
           totalFailLbl.Text = ("Fail : " + (femaleStudentsPercentage.ToString("0.00") + "%"));
            totalStudentLbl.Text = "Total Student : " + totalStudent.ToString();

            if (femaleStudentsPercentage == 0)
            {
                chartShow.Series["s1"].Points.AddXY("Pass", "" + maleStudentsPercentage);

            }
            else if (maleStudentsPercentage == 0)
            {
                chartShow.Series["s1"].Points.AddXY(" ", "" + maleStudentsPercentage);
                chartShow.Series["s1"].Points.AddXY("Fail", "" + femaleStudentsPercentage);
            }
            else
            {
                chartShow.Series["s1"].Points.AddXY("Pass", "" + maleStudentsPercentage);
                chartShow.Series["s1"].Points.AddXY("Fail", "" + femaleStudentsPercentage);

            }

        }
    }
}
