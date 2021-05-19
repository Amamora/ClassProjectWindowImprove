using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowClassProject.View.ViewMangeAll
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
            LoadDataForChart();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }
        
        Color panMaleColor;
        Color panFemaleColor;
        public void LoadDataForChart()
        {
           
            panMaleColor = System.Drawing.Color.BlueViolet;
            panFemaleColor = System.Drawing.Color.Green;

            double totalMale = 0;
            double totalFemale = 0;
            double totalStudent = 0;
            using(MyLinQDataContext db =new MyLinQDataContext())
            {
                var countMale = from STUDENT ss in db.STUDENTs
                                where ss.studentGender == false
                                select ss;

                var totalCount = from STUDENT all in db.STUDENTs
                                 select all;
                totalMale = countMale.Count();
                totalStudent = totalCount.Count();
                totalFemale = totalCount.Count() - totalMale;
            }
            double maleStudentsPercentage = (totalMale * (100 / totalStudent));
            double femaleStudentsPercentage = (totalFemale * (100 / totalStudent));
           
           totalMaleLbl.Text = ("  Male : " + (maleStudentsPercentage.ToString("0.00") + "%"));
            totalFemaleLbl.Text = ("Female : " + (femaleStudentsPercentage.ToString("0.00") + "%"));
            totalStudentLbl.Text = "Total Student : " + totalStudent.ToString();

            if (femaleStudentsPercentage == 0)
            {
                chartShow.Series["s1"].Points.AddXY("Male", "" + maleStudentsPercentage);

            }
            else if (maleStudentsPercentage == 0)
            {
                chartShow.Series["s1"].Points.AddXY(" ", "" + maleStudentsPercentage);
                chartShow.Series["s1"].Points.AddXY("Female", "" + femaleStudentsPercentage);
            }
            else
            {
                chartShow.Series["s1"].Points.AddXY("Male", "" + maleStudentsPercentage);
                chartShow.Series["s1"].Points.AddXY("Female", "" + femaleStudentsPercentage);

            }


        }
        private void chartShow_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
