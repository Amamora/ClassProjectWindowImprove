using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using(MyLinQDataContext db=new MyLinQDataContext())
            {
                var source = from SCORE sc in db.SCOREs 
                             select sc;
            }
        }
    }
}
