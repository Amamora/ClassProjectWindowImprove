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
        MyDataBase mydata = new MyDataBase();


        public bool checkExistOfTeacher(string teacherID)
        {
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
        public void connectGetAllTeacher(DataGridView view)
        {
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
    }
}
