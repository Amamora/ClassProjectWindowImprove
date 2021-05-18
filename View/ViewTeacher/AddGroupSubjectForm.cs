using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowClassProject.View.ViewTeacher
{
    public partial class AddGroupSubjectForm : Form
    {
        public AddGroupSubjectForm()
        {
            InitializeComponent();
        }

        public AddGroupSubjectForm(DataGridView dataView)
        {
            InitializeComponent();

        }

        private void AddGroupSubjectForm_Load(object sender, EventArgs e)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {

                var teacherId = from TEACHER te in data.TEACHERs
                                select te;
                teacherCombox.DataSource = teacherId;
                teacherCombox.DisplayMember = "teacherID";

                var studentId = from STUDENT stu in data.STUDENTs //ban chat la list linq student
                                select stu;
                

                var course = from COURSE co in data.COURSEs
                             select co;
                courseCombox.DataSource = course;
                courseCombox.DisplayMember = "courseID";

                var sourceGroup = from GROUPSUBJECT g in data.GROUPSUBJECTs

                                  select new { g.groupID, g.groupName, g.teacherID,  g.courseID };
                dataShowGrid.DataSource = sourceGroup;
            }
        }

        private void modeGroupSubjectBtn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ClassPanelForm());
        }
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void departmentIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public bool checkAll()
        {
            if (groupIDTxt.Text.Trim() == "" || groupNameTxt.Text == "")
            {
                MessageBox.Show("Fill all data!");
                return false;
            }
            using (MyLinQDataContext db = new MyLinQDataContext())
            {


                TEACHER t = teacherCombox.SelectedItem as TEACHER;
                COURSE c = courseCombox.SelectedItem as COURSE;
            
                var gr = from GROUPSUBJECT g in db.GROUPSUBJECTs
                         where g.teacherID == t.teacherID && g.courseID == c.courseID 
                         select g;
                if (gr.Count() > 0)
                {
                    MessageBox.Show("The exist student ID and teacher ID in the same content of Group!!");
                    return false;
                }
            }
            return true;
        }
        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            if (checkAll())
            {
                using (MyLinQDataContext db = new MyLinQDataContext())
                {
                    GROUPSUBJECT g = new GROUPSUBJECT();
                    TEACHER t = teacherCombox.SelectedItem as TEACHER;
                    COURSE c = courseCombox.SelectedItem as COURSE;
                   

                    g.groupID = groupIDTxt.Text;
                    g.groupName = groupNameTxt.Text;
                    g.teacherID = t.teacherID;
                    g.courseID = c.courseID;
                  
                    db.GROUPSUBJECTs.InsertOnSubmit(g);
                    db.SubmitChanges();

                    MessageBox.Show("Sucess");



                }
            }
        }
        public bool editGroupSubject(GROUPSUBJECT gr)
        {
            if (groupIDTxt.Text.Trim() == "" || groupNameTxt.Text == "")
            {
                MessageBox.Show("Fill all data!");
                return false;
            }
            using (MyLinQDataContext db = new MyLinQDataContext())
            {

                GROUPSUBJECT nGroup = db.GROUPSUBJECTs.Single(p=>p.groupID==gr.groupID);
                nGroup.groupName = gr.groupName;
                nGroup.courseID = gr.courseID;
                nGroup.teacherID = gr.teacherID;
               

                db.SubmitChanges();

                MessageBox.Show("Edit Sucess");



            }
            return true;


        }
        private void editGroupBtn_Click(object sender, EventArgs e)
        {
            GROUPSUBJECT g = new GROUPSUBJECT();
            TEACHER t = teacherCombox.SelectedItem as TEACHER;
            COURSE c = courseCombox.SelectedItem as COURSE;
           
            g.groupID = groupIDTxt.Text;
            g.groupName = groupNameTxt.Text;
            g.teacherID = t.teacherID;
         
            g.courseID = c.courseID;
            editGroupSubject(g);


        }

        public static bool  deleteGroupSubject(string id)
        {

            using (MyLinQDataContext db = new MyLinQDataContext())
            {

                var count = from GROUPSUBJECT g in db.GROUPSUBJECTs
                            where g.groupID == id
                            select g;
                if (count.Count() == 0)
                {
                    MessageBox.Show("ID Group subject not exists");
                    return false;
                }
                GROUPSUBJECT user = db.GROUPSUBJECTs.Single(u => u.groupID == id);
                db.GROUPSUBJECTs.DeleteOnSubmit(user);
                db.SubmitChanges();

                MessageBox.Show("Delete sucess!");
            



            }
            return true;
        }
            private void removeGroupBtn_Click(object sender, EventArgs e)
        {
          bool check=  deleteGroupSubject(groupIDTxt.Text);
          
        }

        private void clearGroupBtn_Click(object sender, EventArgs e)
        {
            AddGroupSubjectForm_Load(sender, e);
        }

        private void groupNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void showGroupBtn_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {

               

                var sourceGroup = from GROUPSUBJECT g in data.GROUPSUBJECTs

                                  select new { g.groupID, g.groupName, g.teacherID, g.courseID };
                dataShowGrid.DataSource = sourceGroup;
            }


        }

        private void searchClassID_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                var check = from GROUPSUBJECT gr in data.GROUPSUBJECTs
                            where gr.groupID == groupIDTxt.Text
                            select gr;
                if (check.Count() == 0)
                {
                    MessageBox.Show("ID Group not exist!");
                    groupIDTxt.Focus();
                    return;
                }

                GROUPSUBJECT g = data.GROUPSUBJECTs.Single(x => x.groupID == groupIDTxt.Text);
                groupNameTxt.Text = g.groupName;
                teacherCombox.Text = g.teacherID;
              
                courseCombox.Text = g.courseID;


            }
            

        }

        private void showStudentInGroupBtn_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                var check = from GROUPSUBJECT gr in data.GROUPSUBJECTs
                            where gr.groupID == groupIDTxt.Text
                            select gr;
                if (check.Count() == 0)
                {
                    MessageBox.Show("ID Group not exist!");
                    groupIDTxt.Focus();
                    return;
                }

                var g = from GROUPSUBJECT sco in data.GROUPSUBJECTs
                        join COURSE co in data.COURSEs
                        on sco.courseID equals co.courseID
                       
                        join SCORE score in data.SCOREs
                        on sco.groupID equals score.groupID
                        join STUDENT stu in data.STUDENTs
                        on score.studentID equals stu.studentID

                        where sco.groupID == groupIDTxt.Text
                        select new
                        {
                            GroupName = sco.groupName,
                            GroupID = sco.groupID,
                            CourseName = co.courseName,
                            TeacherID = sco.teacherID,
                            Score = stu.studentID

                        };


            }

        }

        private void showStudentBtn_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                var check = from GROUPSUBJECT gr in data.GROUPSUBJECTs
                            where gr.groupID == groupIDTxt.Text
                            select gr;
                if (check.Count() == 0)
                {
                    MessageBox.Show("ID Group not exist!");
                    groupIDTxt.Focus();
                    return;
                }

                var g = from GROUPSUBJECT sco in data.GROUPSUBJECTs
                        join COURSE co in data.COURSEs
                        on sco.courseID equals co.courseID
                       
                        join SCORE score in data.SCOREs
                        on sco.groupID equals score.groupID
                        join STUDENT stu in data.STUDENTs
                        on score.studentID equals stu.studentID

                        where sco.groupID == groupIDTxt.Text
                        select new
                        {
                            GroupName = sco.groupName,
                            GroupID = sco.groupID,
                            CourseName = co.courseName,
                            TeacherID = sco.teacherID,
                            Score = stu.studentID

                        };


            }
        }

        private void dataShowGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupIDTxt.Text = dataShowGrid.CurrentRow.Cells[0].Value.ToString();
            groupNameTxt.Text = dataShowGrid.CurrentRow.Cells[1].Value.ToString();
            teacherCombox.Text = dataShowGrid.CurrentRow.Cells[2].Value.ToString();
          
            courseCombox.Text = dataShowGrid.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

