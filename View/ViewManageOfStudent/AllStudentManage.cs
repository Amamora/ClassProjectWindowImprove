using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowClassProject.View.ViewManageOfStudent
{
    public partial class AllStudentManage : Form
    {
        public AllStudentManage()
        {
            InitializeComponent();
        }
        public AllStudentManage(string groupID)
        {
            InitializeComponent();
            this.groupID = groupID;
        }
        string groupID;
        
        public void loadData(DataGridView dataShowGrid)
        {
            using (MyLinQDataContext data = new MyLinQDataContext())
            {



                var sourceGroup = from GROUPSUBJECT g in data.GROUPSUBJECTs
                                  join STUDENT stu in data.STUDENTs on g.studentID equals stu.studentID 
                                  where g.groupID==groupID
                                  select new { g.groupID, g.groupName, g.teacherID, g.studentID,studentFullName=stu.studentFName+" "+stu.studentLName ,g.courseID };
                dataShowGrid.DataSource = sourceGroup;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void AllStudentManage_Load(object sender, EventArgs e)
        {

        }
    }
}
