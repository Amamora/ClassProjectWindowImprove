using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowClassProject.View.OtherForm
{
    public partial class AddPerson : UserControl
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void addPersonPanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backPagePanel_Paint(object sender, PaintEventArgs e)
        {

        }
       public int gender = 0;
        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gender = 0;
        }

        private void FeMaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }
    }
}
