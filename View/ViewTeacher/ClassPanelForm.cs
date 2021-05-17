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

namespace WindowClassProject.View.ViewTeacher
{
    public partial class ClassPanelForm : Form
    {
        public ClassPanelForm()
        {
            InitializeComponent();

            /*
             may ham nay dang le re tach ra thanh nhung ham function rieng cho de tai' su dung
             */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        private void ClassPanelForm_Load(object sender, EventArgs e)
        {
            LoadDataGrid(dataShowGrid);

        }
        public void LoadDataGrid(DataGridView data)
        {
            using (MyLinQDataContext dt = new MyLinQDataContext())
            {
                var scource = from CLASS c in dt.CLASSes
                              select new { 
                              ClassID =c.classID,
                              TeacherID=c.teacherID,
                              Year=c.schoolyear,
                              DepartmentID=c.departmentID

                              };
                var dtc = from DEPARTMENT d in dt.DEPARTMENTs

                          select d;
                departmentSelectBox.DataSource = dtc;
                departmentSelectBox.DisplayMember = "departmentID";

                data.DataSource = scource;
            }
        }
        #region create method chosse option ~~=))) met qua' dam ra luoi code frontend v
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
        #endregion

        
        #region action keyboard
        private void departmentIDTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                schoolYearTxt.Focus();
            }
        }

        private void schoolYearTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode
               == Keys.Down)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                departmentSelectBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                teacherIDTxt.Focus();
            }
        }

        private void teacherIDTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode
               == Keys.Down)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                schoolYearTxt.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                classIDTxt.Focus();
            }
        }

        private void classIDTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) == true || (e.KeyCode == Keys.Down))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                teacherIDTxt.Focus();
            }
        }
#endregion
        private void addClassBtn_Click(object sender, EventArgs e)
        {

            if (!checkAllValid())
            {
                return;

            }
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                CLASS cl = new CLASS();
                cl.classID = classIDTxt.Text;
                cl.teacherID = teacherIDTxt.Text;
                cl.schoolyear = Int32.Parse(schoolYearTxt.Text);
                DEPARTMENT dep = departmentSelectBox.SelectedItem as DEPARTMENT;
                 
                cl.departmentID = dep.departmentID;

                data.CLASSes.InsertOnSubmit(cl);
                data.SubmitChanges();
                LoadDataGrid(dataShowGrid);

            }
        }
        #region
        public bool checkAllValid()
        {
            if (classIDTxt.Text.Trim() == "" || schoolYearTxt.Text.Trim() == ""  || teacherIDTxt.Text == "")
            {
                MessageBox.Show("Fill all information ");
                return false;

            }
            bool check = true;
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                var dtB = from TEACHER t in data.TEACHERs
                          where t.teacherID == teacherIDTxt.Text.Trim()
                          select t;
                if (dtB.Count() == 0)
                {
                    MessageBox.Show("The ID of teacher not exists!");
                    teacherIDTxt.Focus();
                    check = false;

                }

                var dtC = from CLASS c in data.CLASSes
                          where c.classID == classIDTxt.Text
                          select c;
                if (dtC.Count() > 0)
                {
                    MessageBox.Show("Class ID exists @");
                    classIDTxt.Focus();
                    check = false;
                }
               
               

            }
            if (check == false)
            {
                return false;
            }

            return true;
        }
#endregion

        private void searchClassID_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext dt = new MyLinQDataContext())
            {
                var dtC = from CLASS c in dt.CLASSes
                          where c.classID == classIDTxt.Text
                          select c;
                if (dtC.Count() == 0)
                {
                    MessageBox.Show("Class ID not  exists !");
                    classIDTxt.Focus();
                    return;



                }
                else
                {
                    CLASS cl = dt.CLASSes.Single(x => x.classID == classIDTxt.Text);
                    teacherIDTxt.Text = cl.teacherID;
                    departmentSelectBox.Text = cl.departmentID;
                    schoolYearTxt.Text = cl.schoolyear.ToString();
                }
            }
            }

        private void classIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void schoolYearTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public void editclass(CLASS cl)
        {
            if (classIDTxt.Text.Trim() == "" || teacherIDTxt.Text == "")
            {
                MessageBox.Show("Fill all information!");
                return;
            }
            using (MyLinQDataContext dt = new MyLinQDataContext())
            {
                var dtC = from CLASS c in dt.CLASSes
                          where c.classID == classIDTxt.Text
                          select c;
                if (dtC.Count() == 0)
                {
                    MessageBox.Show("Class ID not  exists !");
                    classIDTxt.Focus();
                    return;



                }

                CLASS cls = dt.CLASSes.Single(x => x.classID == cl.classID);
                cls.classID = cl.classID;
                cls.departmentID = cl.departmentID;
                cls.teacherID = cl.teacherID;
                cls.schoolyear = cl.schoolyear;
                dt.SubmitChanges();
                MessageBox.Show("Edit sucess!");




            }
        }

        private void editClassBtn_Click(object sender, EventArgs e)
        {
            


                CLASS cl = new CLASS();
                DEPARTMENT dep = departmentSelectBox.SelectedItem as DEPARTMENT;
                cl.classID = classIDTxt.Text;
                cl.teacherID = teacherIDTxt.Text;
                cl.schoolyear = Int32.Parse(schoolYearTxt.Text);
                cl.departmentID = dep.departmentID;
            editclass(cl);
            


        }

        private void removeClassBtn_Click(object sender, EventArgs e)
        {
            deleteClass(classIDTxt.Text);
        }
        public  bool deleteClass(string id)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                var dtC = from CLASS c in data.CLASSes
                          where c.classID == id
                          select c;
                if (dtC.Count() == 0)
                {
                    MessageBox.Show("Class ID not  exists !");
                    classIDTxt.Focus();
                    return false;
                }
                //here is code delete class


                CLASS user = data.CLASSes.Single(u => u.classID==id);
                data.CLASSes.DeleteOnSubmit(user);
               data.SubmitChanges();

                MessageBox.Show("Delete sucess!");

            }
            return true;
        }

        private void clearClassBtn_Click(object sender, EventArgs e)
        {
            ClassPanelForm_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext dt = new MyLinQDataContext())
            {
                var scource = from CLASS c in dt.CLASSes
                              select new
                              {
                                  ClassID = c.classID,
                                  TeacherID = c.teacherID,
                                  Year = c.schoolyear,
                                  DepartmentID = c.departmentID

                              };
               

                dataShowGrid.DataSource = scource;
            }
        }

        private void studentOfClassShowBtn_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {
                var dtC = from CLASS c in data.CLASSes
                          where c.classID == classIDTxt.Text
                          select c;
                if (dtC.Count() == 0)
                {
                    MessageBox.Show("Class ID not  exists !");
                    classIDTxt.Focus();
                    return;
                }

                var source = from STUDENT s in data.STUDENTs
                             where s.classID == classIDTxt.Text
                             select new
                             {
                                 StudentID = s.studentID,
                                 StudentFName = s.studentFName,
                                 StudentLName = s.studentLName,
                                 StudentMail = s.studentEmail
                             };
                dataShowGrid.DataSource = source;

                

            }


        }

        private void dataShowGrid_DoubleClick(object sender, EventArgs e)
        {
            string test = dataShowGrid.CurrentRow.Cells[0].Value.ToString();
            
            classIDTxt.Text = dataShowGrid.CurrentRow.Cells[0].Value.ToString();
            if (dataShowGrid.CurrentRow.Cells[1].Value == null)
            {
                teacherIDTxt.Text = "";
            }
            else
            {
                teacherIDTxt.Text = dataShowGrid.CurrentRow.Cells[1].Value.ToString();
            }
           schoolYearTxt.Text = dataShowGrid.CurrentRow.Cells[2].Value.ToString();
           departmentSelectBox.Text = dataShowGrid.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataShowGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            deleteClass(dataShowGrid.CurrentRow.Cells[0].Value.ToString());
            
        }
    }
}
