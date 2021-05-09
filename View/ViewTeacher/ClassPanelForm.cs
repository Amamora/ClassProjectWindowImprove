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
    public partial class ClassPanelForm : Form
    {
        public ClassPanelForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool modeClass = true;
        private void ClassPanelForm_Load(object sender, EventArgs e)
        {

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
            panelChooseOption.Controls.Add(childForm);
            panelChooseOption.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void modeClassRadio_CheckedChanged(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddClassForm());
        }

        private void modeGroupRadio_CheckedChanged(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddGroupSubjectForm());
        }
    }
}
