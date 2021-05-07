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
    class UserAccountDAO
    {

        MyDataBase mydata = new MyDataBase();
        UserAccount user = new UserAccount();
        public UserAccount loginUserAccount(string userTxt, string passTxt)
        {

            
            MyDataBase myData = new MyDataBase();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[USERACCOUNT] WHERE userAccount = @User AND password = @Pass ", myData.getConnection);

            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = userTxt;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = passTxt;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);


            if ((table.Rows.Count > 0))
            {

                user.userAccountID = Int32.Parse(table.Rows[0]["userAccountID"].ToString());
                user.userAccount = table.Rows[0]["userAccount"].ToString();
                user.password = table.Rows[0]["password"].ToString();
                user.typeID = Int32.Parse(table.Rows[0]["typeID"].ToString());

                return user;

            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return null;

            }
        }
    }
}
