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
        }
        public void resertAll()
        {
            //resert default value of form =)))) :I don't know why I can create some method realy stupid hmm


        }
        //position inside listbox 
        private int position = 0;

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
            CourseDAO courseDAO = new CourseDAO();
            DataTable table = courseDAO.getAllCourse();

            //load data for listbox

           
            for (int i = 0; i < table.Rows.Count; i++)
            {
                CourseModel course = new  CourseModel(table.Rows[i]["courseID"].ToString(),table.Rows[i]["courseName"].ToString(),table.Rows[i]["departmentID"].ToString(), Int32.Parse(table.Rows[i]["credit"].ToString()), table.Rows[i]["descriptionCourse"].ToString());
                listShowCourse.Items.Add(course);
               
            }

            listShowCourse.DisplayMember = "courseName";

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

        }
        public bool checkAddCourseValidatel()
        {
            if (idShowText.Text.Trim() == "" || courseShowText.Text.Trim() == "" || creditShowNumeric.Value.ToString().Trim() == "")
            {
                MessageBox.Show("NEED TO confirm all value");
                return false;
            }
            if (Int32.Parse(creditShowNumeric.Value.ToString()) > 10 || Int32.Parse(creditShowNumeric.Value.ToString()) < -1)
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
    }
}
