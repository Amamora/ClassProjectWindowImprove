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
    }
}
