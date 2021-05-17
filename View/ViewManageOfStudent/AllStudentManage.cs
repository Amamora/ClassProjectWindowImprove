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
        

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
