using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.Model;

namespace WindowClassProject.DAO
{
    class UserAccountDAO
    {

     
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

        public System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
                return returnImage;
            }
        }
       public bool loadImageForUserAccount(UserAccount user)
        {
            MyDataBase myData = new MyDataBase();
            myData.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT stu.picture FROM [WINDOWCLASS].[dbo].[USERACCOUNT] us JOIN [WINDOWCLASS].[dbo].[TEACHER] stu ON stu.userAccountID=us.userAccountID WHERE us.userAccount = @User", myData.getConnection);

            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = user.userAccount;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count>0)
            {
                Console.WriteLine("ASDAS");
                user.imageAccount = (byte[])table.Rows[0]["picture"];
                myData.closeConnection();
                return true;

            }

            myData.closeConnection();
            return false;
        }

    }
}
