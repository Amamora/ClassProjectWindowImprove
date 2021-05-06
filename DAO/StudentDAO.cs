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
    class StudentDAO
    {
        MyDataBase mydata = new MyDataBase();
        public bool insertNewStudent(string studentID, string firstName, string lastName, DateTime date, string gender, string phone,string email,string cmnd, MemoryStream picture)
        {
            mydata.openConnection();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [viduDB].[dbo].[user_infor](Id, fname, lname, bdate, gender, phone, picture) VALUES (@id, @fn, @ln, @bd, @gen, @ph, @pic)", mydata.getConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = studentID;
            sqlCommand.Parameters.Add("@fn", SqlDbType.NVarChar).Value = firstName;
            sqlCommand.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastName;
            sqlCommand.Parameters.Add("@bd", SqlDbType.DateTime).Value = date;
            sqlCommand.Parameters.Add("@gen", SqlDbType.NVarChar).Value = gender;
            sqlCommand.Parameters.Add("@ph", SqlDbType.NVarChar).Value = phone;
            sqlCommand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();


            if ((sqlCommand.ExecuteNonQuery() == 1))
            {
                mydata.closeConnection();
                return true;
            }
            else
            {
                mydata.closeConnection();
                return false;
            }
        }


        public void connectionDataBase(DataGridView dataGridView1)
        {
            MyDataBase myDataBase = new MyDataBase();

            myDataBase.openConnection();
            DataSet dataSet = new DataSet();
            SqlCommand command = new SqlCommand("SELECT Id as 'ID' ,fname as 'FirstName',lname as 'LName',bdate as 'BirthDate',gender as 'Gender',phone as 'Phone',picture as 'Picture' FROM  [viduDB].[dbo].[user_infor] ", myDataBase.getConnection);


            command.CommandType = CommandType.Text;
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            myDataBase.closeConnection();



            dataGridView1.DataSource = dt;
            /*  DataGridViewImageColumn picCol = new DataGridViewImageColumn();
              dataGridView1.RowTemplate.Height = 80;
              picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
              picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;*/



        }
        #region view Sub in Score panel
        //create view for sub
        public void connection3Column(DataGridView dataGridView1)
        {
            MyDataBase myDataBase = new MyDataBase();

            myDataBase.openConnection();
            DataSet dataSet = new DataSet();
            SqlCommand command = new SqlCommand("SELECT Id as 'ID' ,fname as 'FirstName',lname as 'LastName' FROM  [viduDB].[dbo].[user_infor] ", myDataBase.getConnection);


            command.CommandType = CommandType.Text;
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            myDataBase.closeConnection();



            dataGridView1.DataSource = dt;
            /*  DataGridViewImageColumn picCol = new DataGridViewImageColumn();
              dataGridView1.RowTemplate.Height = 80;
              picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
              picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;*/



        }

        #endregion

        public bool updateInforStudent(int id, string fname, string lname, DateTimePicker bdate, string gender, string phone, MemoryStream picture, int initialID)
        {
            MyDataBase myDataBase = new MyDataBase();




            SqlCommand sqlCommand = new SqlCommand("UPDATE [viduDB].[dbo].[user_infor] SET Id=@id, fname=@fname, lname=@lname, bdate=@bdate, gender=@gender, phone=@phone, picture =@picture " +
                "WHERE Id=@initialID", myDataBase.getConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            sqlCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            sqlCommand.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate.Value;
            sqlCommand.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            sqlCommand.Parameters.Add("@initialID", SqlDbType.Int).Value = initialID;

            sqlCommand.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            myDataBase.openConnection();
            if ((sqlCommand.ExecuteNonQuery() == 1))
            {
                mydata.closeConnection();
                return true;
            }
            else
            {
                mydata.closeConnection();
                return false;
            }
        }

        ///search student by id
        public void searchStudentByid(int id, DataGridView dataGridView1)
        {
            MyDataBase myDataBase = new MyDataBase();
            myDataBase.openConnection();
            DataSet dataSet = new DataSet();
            SqlCommand command = new SqlCommand("SELECT * FROM  [viduDB].[dbo].[user_infor] WHERE Id=@id ", myDataBase.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            dataGridView1.RowTemplate.Height = 80;

            command.CommandType = CommandType.Text;
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            myDataBase.closeConnection();



            dataGridView1.DataSource = dt;

        }

    }
}
