using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.Model;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace WindowClassProject.DAO
{
    class ScoreDAO
    {
        MyDataBase mydata = new MyDataBase();
        //get information for datagridview
        public void connectionDataBase(DataGridView data)
        {
            mydata.openConnection();
            SqlCommand command = new SqlCommand("");
        }

        //add score
        //check exist student score
        //get avg score of course

        // delete score base groupid and studentid

        //selectcoure
        //

    }
}
