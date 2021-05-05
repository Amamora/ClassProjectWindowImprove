using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClassProject.Model
{
   public class MyDataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GV657V4;Initial Catalog=WINDOWCLASS;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return sqlConnection;
            }
        }
        // open the connection
        public void openConnection()
        {
            if ((sqlConnection.State == ConnectionState.Closed))
            {
                sqlConnection.Open();
            }

        }
        public void closeConnection()
        {
            if ((getConnection.State == ConnectionState.Open))
            {
                getConnection.Close();
            }

        }
    }
}
