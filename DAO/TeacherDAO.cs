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
    class TeacherDAO
    {

        #region check exist of teacher , can use Linq like student 

        public bool checkExistOfTeacher(string teacherID)
        {
            MyDataBase mydata = new MyDataBase();
            mydata.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[TEACHER] WHERE teacherID=@te", mydata.getConnection);

            command.Parameters.Add("@te", SqlDbType.NVarChar).Value = teacherID;
            DataTable tb = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = command;
            ap.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
        public void connectGetAllTeacher(DataGridView view)
        {
            MyDataBase mydata = new MyDataBase();
            mydata.openConnection();
            SqlCommand command = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY teacherID ASC) AS N'Order',teacherID,teacherFName,teacherLName,teacherEmail,picture  FROM [WINDOWCLASS].[dbo].[TEACHER]", mydata.getConnection);
            DataTable tb = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = command;
            ap.Fill(tb);


            view.DataSource = tb;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            view.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)view.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }


        public DataTable getDataTableTeacher(string teacherID)
        {
            MyDataBase mydata = new MyDataBase();
            mydata.openConnection();
            SqlCommand command = new SqlCommand("SELECT *  FROM [WINDOWCLASS].[dbo].[TEACHER] where teacherID=@te", mydata.getConnection);
            command.Parameters.Add("@te", SqlDbType.NVarChar).Value = teacherID;
            DataTable tb = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = command;
            ap.Fill(tb);


            mydata.closeConnection();
            return tb;
        }
        public void searchTeacher(string teacherID, DataGridView view)
        {

            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                var sco = from TEACHER t in db.TEACHERs
                          where t.teacherID == teacherID
                          select t;
                if (sco.Count() == 0)
                {
                    MessageBox.Show("ID teacher not exist's!");
                    return;
                }
            }
            MyDataBase mydata = new MyDataBase();
            mydata.openConnection();
            SqlCommand command = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY teacherID ASC) AS N'Order',teacherID,teacherFName,teacherLName,teacherEmail,picture  FROM [WINDOWCLASS].[dbo].[TEACHER] where teacherID=@te", mydata.getConnection);
            command.Parameters.Add("@te", SqlDbType.NVarChar).Value = teacherID;
            DataTable tb = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = command;
            ap.Fill(tb);


            view.DataSource = tb;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            view.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)view.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            mydata.closeConnection();

        }
        #region load update teachẻ
        public bool updateInforTeacher(string id, string fname, string lname, DateTimePicker bdate, int gender, string phone, string email, string cmnd, MemoryStream picture, string studentID)
        {
            MyDataBase myDataBase = new MyDataBase();




            SqlCommand sqlCommand = new SqlCommand("UPDATE [WINDOWCLASS].[dbo].[TEACHER] SET teacherID=@id, teacherFName=@fname, teacherLName=@lname, teacherBDate=@bdate,teacherGender=@gender, teacherPhone=@phone,teacherEmail=@email,teacherCMND=@cmnd,picture =@picture " + "WHERE teacherID=@initialID", myDataBase.getConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            sqlCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            sqlCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            sqlCommand.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate.Value;
            sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            sqlCommand.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;

            sqlCommand.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
            sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;


            sqlCommand.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            sqlCommand.Parameters.Add("@initialID", SqlDbType.NVarChar).Value = studentID;
            myDataBase.openConnection();
            if ((sqlCommand.ExecuteNonQuery() == 1))
            {
                myDataBase.closeConnection();
                return true;
            }
            else
            {
                myDataBase.closeConnection();
                return false;
            }
        }
        #endregion
    }
}
