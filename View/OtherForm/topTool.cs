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
    public partial class topTool : UserControl
    {
        public topTool()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.FormWindowState WindowState { get; set; }
        #region action expand and minimum size of your window FORM


        private void expandPictureBox_Click(object sender, EventArgs e)
        {

            if(WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }
        #endregion
    }
}
