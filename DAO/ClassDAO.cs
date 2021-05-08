using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.Model;

namespace WindowClassProject.DAO
{
    class ClassDAO
    {
        ///create datable now
        ///publi]
        ///
        MyDataBase mydata = new MyDataBase();
        public DataTable getDataClassIntoDataTable()
        {
            mydata.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[CLASS]",mydata.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            MessageBox.Show("Error get data!");
            return table;//or we can set null

            

        }
    }
}
