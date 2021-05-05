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


        #region action expand and minimum size of your window FORM

        int lX, lY;
        int sw, sh;
        bool mini = false;

        private void expandPictureBox_Click(object sender, EventArgs e)
        {
            lX = this.Location.X;
            lY = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            if (mini == false)
            {
                mini = true;


            }
            else
            {
                mini = false;
            }
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }
        #endregion
    }
}
