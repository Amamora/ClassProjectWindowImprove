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
    class DepartmentDAO
    {
        MyDataBase mydata = new MyDataBase();
        //

        #region load data Department DAO
        //we should action with datatable or list hmmm
        public DataTable loadDataTablseDepart()
        {
            mydata.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM DEPARTMENT ", mydata.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;

        }
        public bool checkExistDepartment(string departmentID)
        {
            mydata.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM DEPARTMENT WHERE departmentID =@dep  ", mydata.getConnection);

            command.Parameters.Add("@dep", SqlDbType.NVarChar).Value = departmentID;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Exist Department ID ", "Duplicated!");
                return true;

            }
            return false;

        }
        #endregion

        #region 
        #endregion

    }
}
