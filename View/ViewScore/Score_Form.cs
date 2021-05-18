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

namespace WindowClassProject.View.ViewScore
{
    public partial class Score_Form : Form
    {
        public Score_Form()
        {
            InitializeComponent();
           
        }

        private void Score_Form_Load(object sender, EventArgs e)
        {
            comboBoxSearch.SelectedIndex = 0;
            ScoreDAO sco = new ScoreDAO();
            sco.connectionDataBase(dataScoreDataGridView);
        }

        private void addScoreBtn_Click(object sender, EventArgs e)
        {
            AddScorePanelForm add = new AddScorePanelForm();
            add.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (comboBoxSearch.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;

            }
        }


    }
}
