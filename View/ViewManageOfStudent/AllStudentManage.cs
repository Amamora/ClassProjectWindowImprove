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
            groupIDLbl.Text = " Student ID in group ID " + groupID;
            loadData(dataStudentInGroupID);
        }
        string groupID;
        
        public void loadData(DataGridView dataShowGrid)
        {
            ScoreDAO sco = new ScoreDAO();
        dataShowGrid.DataSource=  sco.connectData(groupID);
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
