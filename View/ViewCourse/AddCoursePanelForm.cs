using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowClassProject.View.ViewCourse
{
    public partial class AddCoursePanelForm : Form
    {
        public AddCoursePanelForm()
        {
            InitializeComponent();
        }

        private void descriptionLbl_Click(object sender, EventArgs e)
        {

        }

        private void resertBtn_Click(object sender, EventArgs e)
        {
            idCourseTxt.Text = "";
            descriptionTxt.Text = "";
            courseNameTxt.Text = "";
            creditTxt.Text = "";
            departmentCombox.SelectedIndex = 0;
            
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            if (checkAddCourseValidatel() == true)
            {
                using (MyLinQDataContext mydata = new MyLinQDataContext())
                {
                    COURSE co = new COURSE();
                    co.courseID = idCourseTxt.Text.Trim();
                    co.courseName = courseNameTxt.Text;
                    co.credit = Int32.Parse(creditTxt.Text);
                    DEPARTMENT de = departmentCombox.SelectedItem as DEPARTMENT;
                    co.departmentID = de.departmentID;
                    co.descriptionCourse = descriptionTxt.Text;
                    mydata.COURSEs.InsertOnSubmit(co);

                    mydata.SubmitChanges();
                    MessageBox.Show("Insert Suceess");

                }
            }
        }

        private void idCourseTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) == true || (e.KeyCode == Keys.Down) == true)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                courseNameTxt.Focus();

            }
        }

        private void creditTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter)==true||(e.KeyCode==Keys.Down)==true)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                departmentCombox.Focus();

            }
            if ((e.KeyCode == Keys.Up))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                courseNameTxt.Focus();
            }
        }

        private void courseNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) == true || (e.KeyCode == Keys.Down) == true)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
              creditTxt.Focus();

            }
            if ((e.KeyCode == Keys.Up))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
               idCourseTxt.Focus();
            }
        }

        private void departmentCombox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) == true || (e.KeyCode == Keys.Down) == true)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                descriptionTxt.Focus();

            }
            if ((e.KeyCode == Keys.Up))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                creditTxt.Focus();
            }
        }

        private void AddCoursePanelForm_Load(object sender, EventArgs e)
        {
            using(MyLinQDataContext data=new MyLinQDataContext())
            {
                var depart = from DEPARTMENT dep in data.DEPARTMENTs
                             select dep;
                departmentCombox.DataSource = depart;
                departmentCombox.DisplayMember = "departmentName";

                    
            }
        }
        public bool checkAddCourseValidatel()
        {
            if (idCourseTxt.Text.Trim() == "" || courseNameTxt.Text.Trim() == "" || creditTxt.Text.Trim() == "")
            {
                MessageBox.Show("NEED TO confirm all value");
                return false;
            }
            if (Int32.Parse(creditTxt.Text.Trim()) > 10 || Int32.Parse(creditTxt.Text.Trim()) < 0)
            {
                MessageBox.Show("Please FILL period value between 0 and 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool check = true;
            string id = idCourseTxt.Text.Trim();
            using (MyLinQDataContext db=new MyLinQDataContext())
            {
                var count = from COURSE c in db.COURSEs
                            where c.courseID == id
                            select c;
                if (count.Count() > 0)
                {
                    check = false;
                    return false;
                }

            }


            return true;

        }

        public void resertALl()
        {
            idCourseTxt.Text = "";
            courseNameTxt.Text = "";
            creditTxt.Text = "";
            descriptionTxt.Text = "";
            //lan sau check department combox xem co phan tu de hien thi ko nhe'
            departmentCombox.SelectedIndex = 0;
        }

        private void descriptionTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) == true || (e.KeyCode == Keys.Down) == true)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                departmentCombox.Focus();

            }
            
        }

        private void departmentCombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
