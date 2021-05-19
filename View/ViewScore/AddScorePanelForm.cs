using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.DAO;

namespace WindowClassProject.View.ViewScore
{
    public partial class AddScorePanelForm : Form
    {
        public AddScorePanelForm()
        {
            InitializeComponent();
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
            dataSubScoreView.DataSource=sco.connectData(selectSearchBox.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (checkAll())
            {
                using (MyLinQDataContext db = new MyLinQDataContext())
                {
                    SCORE sc = new SCORE();


                    sc.score1= float.Parse(scoreTxt.Text);
                    sc.evalute = descriptionTxt.Text;
                    sc.studentID = studentIDtxt.Text;
                    sc.groupID = selectGroupID.Text;
                    db.SCOREs.InsertOnSubmit(sc);
                    MessageBox.Show("Insert sucess!");
                    db.SubmitChanges();


                }
                AddScorePanelForm_Load(sender, e);
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
                    return false;
                }
                //tu student id=> groupsubject =>core

                var src = from SCORE sc in db.SCOREs
                          join GROUPSUBJECT gr in db.GROUPSUBJECTs on sc.groupID equals gr.groupID
                          where sc.studentID == studentIDtxt.Text && sc != null&& gr.groupID==selectGroupID.Text
                          select sc;
                if (src.Count() > 0)
                {
                    MessageBox.Show("HAVE DATA about score student in that course");
                    return false;
                }
            }
            return true;
        }
        public void loadDataGrid(DataGridView data)
        {
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                var source = from SCORE s in db.SCOREs
                             join GROUPSUBJECT gr in db.GROUPSUBJECTs on s.groupID equals gr.groupID
                             join COURSE co in db.COURSEs on gr.courseID equals co.courseID
                             join STUDENT stu in db.STUDENTs on s.studentID equals stu.studentID
                             select new
                             {
                                 GroupID = gr.groupID,
                                 StudentID=stu.studentID,
                                 StudentName = stu.studentLName,
                                 CourseName = co.courseName,
                                
                                 Score = s.score1,

                             }
                             ;
                data.DataSource = source;

                var souceGroupID = from GROUPSUBJECT g in db.GROUPSUBJECTs
                                   group g.groupID by g.groupID into g
                                   select g.Key;


                selectGroupID.DataSource = souceGroupID;
                selectGroupID.DisplayMember = "groupID";
                selectSearchBox.DataSource = souceGroupID;
                selectSearchBox.DisplayMember = "groupID";

            }

        }
        private void AddScorePanelForm_Load(object sender, EventArgs e)
        {
            loadDataGrid(dataSubScoreView);


        }

        private void scoreTxt_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(scoreTxt.Text, @"\b\d+\b"))
            {
                MessageBox.Show("only Number");
            }
        }

        private void showStudentDataBtn_Click(object sender, EventArgs e)
        {
           
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                //show student follow select group ID =>

                var scource = from GROUPSUBJECT groupSub in db.GROUPSUBJECTs
                              join SCORE score in db.SCOREs on groupSub.groupID equals score.groupID
                              join STUDENT stu in db.STUDENTs on  score.studentID equals stu.studentID
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

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void editScoreBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataSubScoreView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
    }
