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
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[SCORE]", mydata.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            data.DataSource = table;
            mydata.closeConnection();
        }

        //add score
        //check exist student score
        //get avg score of course

        // delete score base groupid and studentid

        //selectcoure
        //
        public DataTable connectData(string groupID)
        {
            mydata.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT stu.studentID,stu.studentFname,stu.studentLName, gr.groupID,gr.groupName,score.score from [WINDOWCLASS].[dbo].[SCORE] score join [WINDOWCLASS].[dbo].[STUDENT] stu on score.studentID=stu.studentID join [WINDOWCLASS].[dbo].[GROUPSUBJECT] gr on gr.groupID=score.groupID where gr.groupID= @groupID", mydata.getConnection);
            command.Parameters.Add("@groupID", SqlDbType.NVarChar).Value = groupID;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            mydata.closeConnection();
            return table;

        }

        public DataTable searchByCourseID(string courseID)
        {

            mydata.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT stu.studentID,stu.studentFname,stu.studentLName, gr.groupID,gr.groupName,score.score from [WINDOWCLASS].[dbo].[SCORE] score join [WINDOWCLASS].[dbo].[STUDENT] stu on score.studentID=stu.studentID join [WINDOWCLASS].[dbo].[GROUPSUBJECT] gr on gr.groupID=score.groupID where gr.courseID= @groupID", mydata.getConnection);
            command.Parameters.Add("@groupID", SqlDbType.NVarChar).Value = courseID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            mydata.closeConnection();
            return table;
        }

    }
}
