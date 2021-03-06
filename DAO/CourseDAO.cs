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
    class CourseDAO
    {
        MyDataBase myDataBase = new MyDataBase();

        /**Keep open and close connection to avoid error
         * 
         * /hmm DATABASE nay co van de roi chiu thoi
         */
        public void connectionDataBase(DataGridView dataGridView1)
        {


            myDataBase.openConnection();


            SqlCommand command = new SqlCommand("SELECT courseID, courseName , departmentID ,credit, descriptionCourse FROM  [WINDOWCLASS].[dbo].[COURSE] ", myDataBase.getConnection);
            DataSet dataSet = new DataSet();

            dataGridView1.RowTemplate.Height = 80;

            command.CommandType = CommandType.Text;
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            myDataBase.closeConnection();



            dataGridView1.DataSource = dt;




        }

        #region get all course for manage Fast course

        public DataTable getAllCourse()
        {


            myDataBase.openConnection();


            SqlCommand command = new SqlCommand("SELECT courseID, courseName, departmentID, credit, descriptionCourse FROM [WINDOWCLASS].[dbo].[COURSE] ", myDataBase.getConnection);
            DataSet dataSet = new DataSet();

            command.CommandType = CommandType.Text;
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            myDataBase.closeConnection();
            return dt;

        }
        #endregion
        #region getdata course name

        #endregion


        #region addNew Course into database
        public bool insertNewCourse(string id, string name, string departID, int credit, string description)
        {

            myDataBase.openConnection();


            SqlCommand sqlcommand = new SqlCommand("INSERT INTO [WINDOWCLASS].[dbo].[COURSE](courseID,courseName,departmentID,credit,descriptionCourse) VALUES(@id,@name,@did,@cre,@des)", myDataBase.getConnection);

            sqlcommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            sqlcommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            sqlcommand.Parameters.Add("@did", SqlDbType.NVarChar).Value = departID;
            sqlcommand.Parameters.Add("@cre", SqlDbType.Int).Value = credit;
            sqlcommand.Parameters.Add("@des", SqlDbType.NText).Value = description;




            if ((sqlcommand.ExecuteNonQuery() == 1))
            {
                myDataBase.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Insert Failed ");
                myDataBase.closeConnection();
                return false;
            }


        }
        #endregion

        #region
        // count course


        #endregion

        #region check course id have already in database or not
        public bool checkAlreadyCourse(string courseid)
        {
            bool check = false;
            myDataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[COURSE] WHERE courseID=@courseid", myDataBase.getConnection);

            cmd.Parameters.Add("@courseid", SqlDbType.NVarChar).Value = courseid;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);


            if ((table.Rows.Count > 0))
            {

                MessageBox.Show("Already ID COURSE IN Database");
                check = true;///false is wrong



            }
            myDataBase.closeConnection();
            return check;



        }
        #endregion


        #region find and insert value into edit panel
        public bool findInCourse(string idm)
        {


            myDataBase.openConnection();
            SqlCommand sqlcommand = new SqlCommand("SELECT *FROM [WINDOWCLASS].[dbo].[COURSE] WHERE courseID=@id", myDataBase.getConnection);
            sqlcommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = idm;
            //   sqlcommand.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(edit.courseIDtxt.Text.ToString());


            if ((sqlcommand.ExecuteNonQuery() == 1))
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

        #region load all infor
        public void LoadAllCourseName(System.Windows.Forms.ListBox list)
        {
            for (int i = 0; i < LoadCourse().Rows.Count; i++)
            {
                list.Items.Add(LoadCourse().Rows[i]["Course Name"].ToString());
            }
        }
        public DataTable LoadCourse()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY courseID ASC) AS N'Order',courseID, courseName, departmentID, credit, descriptionCourse FROM[WINDOWCLASS].[dbo].[COURSE]";

            //object[] parameters = new object[] { <List parameters> };
            return this.ExecuteQuery(query);
        }
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable table = new DataTable();


            try
            {
                using (SqlConnection connection = myDataBase.getConnection)
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameters != null)
                    {
                        string[] temp = query.Split(' ');

                        List<string> listParameters = new List<string>();
                        foreach (string item in temp)
                        {
                            if (item[0] == '@')
                                listParameters.Add(item.Replace(",", ""));
                        }

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            command.Parameters.AddWithValue(listParameters[i], parameters[i]);
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(table);

                    connection.Close();
                }
            }
            catch (Exception)
            {

            }
            return table;
        }
        #endregion

        #region edit Infor Course

        public bool updateCourse(string newID, string courseNameTxt, string deparmentID, int credit, string descriptionTxt, string previousID)
        {
            myDataBase.openConnection();//create connection to connect with databse
            SqlCommand sqlcommand = new SqlCommand("UPDATE [WINDOWCLASS].[dbo].[COURSE] SET courseID=@id,courseName=@name,departmentID=@did,credit=@cre,descriptionCourse=@des WHERE courseID=@previousID", myDataBase.getConnection);

            sqlcommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = newID;
            sqlcommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseNameTxt;
            sqlcommand.Parameters.Add("@did", SqlDbType.NVarChar).Value = deparmentID;
            sqlcommand.Parameters.Add("@cre", SqlDbType.Int).Value = credit;
            sqlcommand.Parameters.Add("@des", SqlDbType.NText).Value = descriptionTxt;
            sqlcommand.Parameters.Add("@previousID", SqlDbType.NVarChar).Value = previousID;






            if ((sqlcommand.ExecuteNonQuery() == 1))
            {
                myDataBase.closeConnection();
                return true;
            }
            else
            {
                myDataBase.closeConnection();
                MessageBox.Show("ERROR!!1");
                return false;
            }




        }

        #endregion

        //find table
        public DataTable gainInforTable(string selectValue)
        {
            MyDataBase mydata = new MyDataBase();
            mydata.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[COURSE] WHERE courseID=@id", mydata.getConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = selectValue;

            DataSet dataSet = new DataSet();
            sqlCommand.CommandType = CommandType.Text;

            SqlDataAdapter sqlAdapt = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            mydata.closeConnection();


            //DataRow dtRow = dt.Rows[0];


            return dt;
        }


        //get all information of something

        //find id course

        public int gainCourseId(string nameCourse)
        {
            MyDataBase mydata = new MyDataBase();
            mydata.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT courseID FROM [WINDOWCLASS].[dbo].[COURSE] WHERE courseName=@lab", mydata.getConnection);
            sqlCommand.Parameters.Add("@lab", SqlDbType.NVarChar).Value = nameCourse;
            DataSet dataSet = new DataSet();
            sqlCommand.CommandType = CommandType.Text;

            SqlDataAdapter sqlAdapt = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            mydata.closeConnection();


            int di = Int32.Parse(dt.Rows[0]["courseID"].ToString());
            return di;
            //DataRow dtRow = dt.Rows[0];

        }
        #region get number of student this course
       /* public int getNumberCourse()
        {
            myDataBase.openConnection();
           
        }*/
        #endregion
        #region delete
        public bool deleteCourse(string id)
        {
            bool run = true;
            MyDataBase mydate = new MyDataBase();
            mydate.openConnection();


            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [WINDOWCLASS].[dbo].[COURSE] WHERE courseID = @ID", mydate.getConnection);
            sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

            if ((sqlCommand.ExecuteNonQuery() == 1))
            {
                mydate.closeConnection();

                run = true;
            }
            else
            {
                mydate.closeConnection();
                MessageBox.Show("ERROR!!1");
                run = false;
            }


            return run;


        }
        #endregion


    }
}
