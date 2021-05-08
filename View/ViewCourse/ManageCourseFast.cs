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

namespace WindowClassProject.View.ViewCourse
{
    public partial class ManageCourseFast : Form
    {
        public ManageCourseFast()
        {
            InitializeComponent();
        }

        private void ManageCourseFast_Load(object sender, EventArgs e)
        {
            reloadListBox();
            loadDataForDepartment(departmentBox);
            resertAll();
        }
        public void resertAll()
        {
            //resert default value of form =)))) :I don't know why I can create some method realy stupid hmm

            idShowText.Text = "";
            courseShowText.Text = "";
            creditShowNumeric.Value = 0;
            departmentBox.SelectedIndex = 0;
            descriptionShowText.Text = "";



        }
       
       

        /*
         Okay we have some control here:
        focus lisbox , combox
        -step 1: load data
        step 2: show =)))
        --go to youtobe and learn about combox listbox :
        ideal: load data from database and create object course and create list or not
        then add into listbox nao also combox
        nên nhớ chúng ta tác động vào listbox nó sẽ ảnh hưởng vào những control khác thì cứ dựa vào nó mà làm
        --Tạo function load index in listbox đó sẽ là sự đồng nhất hợp lí ~~
         
         */
        public void reloadListBox()
        {
            listShowCourse.Items.Clear();
            CourseDAO courseDAO = new CourseDAO();
            DataTable table = courseDAO.getAllCourse();

            //load data for listbox

           
            for (int i = 0; i < table.Rows.Count; i++)
            {
                CourseModel course = new  CourseModel(table.Rows[i]["courseID"].ToString(),table.Rows[i]["courseName"].ToString(),table.Rows[i]["departmentID"].ToString(), Int32.Parse(table.Rows[i]["credit"].ToString()), table.Rows[i]["descriptionCourse"].ToString());
                listShowCourse.Items.Add(course);
               
            }

            listShowCourse.DisplayMember = "courseName";
            totalCourseLbl.Text = "Total Course : " + table.Rows.Count;

            //display list view

          

          


            
        }
        private void  loadDataForDepartment(ComboBox com)
        {
                    DepartmentDAO depDAO = new DepartmentDAO();
                    DataTable tableDep = depDAO.loadDataTablseDepart();
                    for(int i = 0; i < tableDep.Rows.Count; i++)
                    {
                        DepartmentModel dep = new DepartmentModel(tableDep.Rows[i]["departmentID"].ToString(), tableDep.Rows[i]["departmentName"].ToString(), tableDep.Rows[i]["teacherID"].ToString());

                com.Items.Add(dep);
                    }

            ///show com box just display member name
            ///
            com.DisplayMember = "departmentName";
        }

        private void firstLoadListbox_Click(object sender, EventArgs e)
        {
            listShowCourse.SelectedIndex = 0;
        }
        public bool checkAddCourseValidatel()
        {
            if (idShowText.Text.Trim() == "" || courseShowText.Text.Trim() == "" || creditShowNumeric.Value.ToString().Trim() == "")
            {
                MessageBox.Show("NEED TO confirm all value");
                return false;
            }
            if (Int32.Parse(creditShowNumeric.Value.ToString()) > 10 || Int32.Parse(creditShowNumeric.Value.ToString()) < 0)
            {
                MessageBox.Show("Please FILL period value between 0 and 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           


            return true;

        }
        #region check valid for this panel
        public bool checkValidEditCousre()
        {
            return true;
        }
        #endregion

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            CourseDAO course = new CourseDAO();
            if (course.checkAlreadyCourse(idShowText.Text))
            {
                return;
            }
            if (checkAddCourseValidatel() == true)
            {
                

                DepartmentModel cou = new DepartmentModel();
                cou = departmentBox.SelectedItem as DepartmentModel;
                course.insertNewCourse(idShowText.Text, courseShowText.Text, cou.departmentID, int.Parse(creditShowNumeric.Value.ToString()), descriptionShowText.Text);

                ManageCourseFast_Load(sender, e);


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #region action do with manage fast
        private void listShowCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**
             the ideal : base on listview ~~~
             */
            CourseModel course = new CourseModel();
            course=listShowCourse.SelectedItem as CourseModel;
            //load for data this sit will use for the document 
            idShowText.Text = course.courseID;
            courseShowText.Text = course.courseName;
            creditShowNumeric.Value = course.credit;
            string idDep = course.departmentID;
            DepartmentModel cou = new DepartmentModel();
            descriptionShowText.Text = course.descriptionCourse;
           for (int i = 0; i < departmentBox.Items.Count; i++)
            {
               
                    departmentBox.SelectedIndex = i;
                 cou = departmentBox.SelectedItem as DepartmentModel;
                if (cou.departmentID == idDep)
                {
                    break;
                }
            }

        }


        private void nextLoadListbox_Click(object sender, EventArgs e)
        {
            int position = listShowCourse.SelectedIndex;
            position++;
            if ( position> (listShowCourse.Items.Count - 1)){
                listShowCourse.SelectedIndex = 0;
                return;
            }
            listShowCourse.SelectedIndex = position;
            
        }

        private void previousLoadListbox_Click(object sender, EventArgs e)
        {

            int position = listShowCourse.SelectedIndex;
            position--;
            if (position<0)
            {
                listShowCourse.SelectedIndex = listShowCourse.Items.Count - 1;
                return;
            }
            listShowCourse.SelectedIndex = position;

        }

        private void lastLoadListbox_Click(object sender, EventArgs e)
        {
            listShowCourse.SelectedIndex = listShowCourse.Items.Count - 1;

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            CourseDAO course = new CourseDAO();
            DepartmentModel cou = new DepartmentModel();
            cou = departmentBox.SelectedItem as DepartmentModel;
            // some condition check =))) or more advance you can use express regular bieu thuc chinh quy ~~~
            if (idShowText.Text.Trim() == "" || courseShowText.Text.Trim() == "")
            {
                MessageBox.Show("Insert some information need !!!!");
                return;
            }
            if (Int32.Parse(creditShowNumeric.Value.ToString()) > 10 || Int32.Parse(creditShowNumeric.Value.ToString()) < 0)
            {
                MessageBox.Show("Please FILL period value between 0 and 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            CourseModel model = listShowCourse.SelectedItem as CourseModel;

            if(course.updateCourse(idShowText.Text, courseShowText.Text,cou.departmentID, Int32.Parse(creditShowNumeric.Value.ToString()), descriptionShowText.Text, model.courseID) == true)
            {
                MessageBox.Show("Edit sucess !!!!");
                ManageCourseFast_Load(sender, e);
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            CourseDAO course= new CourseDAO();
            course.deleteCourse(idShowText.Text);
            ManageCourseFast_Load(sender, e);

        }
        #endregion

        private void newBtn_Click(object sender, EventArgs e)
        {
            resertAll();

        }
    }
}
