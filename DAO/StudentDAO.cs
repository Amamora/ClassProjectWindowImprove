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
        public bool insertNewStudent(string studentID, string  studentFName, string lastName, DateTime date, string adress,int gender, string phone,string email,string cmnd, MemoryStream picture,string classID)
        {
            mydata.openConnection();
            if (checkExistStudent(studentID) == true)
            {
                MessageBox.Show("Duplicated student !!");
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [WINDOWCLASS].[dbo].[STUDENT](studentID,studentFName,studentLName,studentBDate,studentAddress,studentGender,studentPhone,studentEmail,studentCMND,picture,classID) VALUES(@id,@sN,@fL,@bDate,@add,@gen,@phone,@email,@cmnd,@pic,@idClass)", mydata.getConnection);

            //@id,@sN,@fL,@bDate,@add,@gen,@phone,@email,@cmnd,@pic,@idClass
            //if you think it really mix and complicate =>create object and insert it into constructor
           
            sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = studentID;
            sqlCommand.Parameters.Add("@sN", SqlDbType.NVarChar).Value = studentFName;
            sqlCommand.Parameters.Add("@fL", SqlDbType.NVarChar).Value = lastName;
            sqlCommand.Parameters.Add("@bDate", SqlDbType.DateTime).Value = date;
            sqlCommand.Parameters.Add("@add", SqlDbType.NVarChar).Value = adress;
            sqlCommand.Parameters.Add("@gen", SqlDbType.Bit).Value = gender;
            sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            sqlCommand.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            sqlCommand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            sqlCommand.Parameters.Add("@idClass", SqlDbType.NVarChar).Value = classID;



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
        public bool checkExistStudent(string studentID)
        {
            mydata.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[STUDENT] WHERE studentID=@stu", mydata.getConnection);
            command.Parameters.Add("@stu", SqlDbType.NVarChar).Value = studentID;
            
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            MessageBox.Show("Already student ID in your database");
            return true;

        }

        public void connectionDataBase(DataGridView dataGridView1)
        {
            MyDataBase myDataBase = new MyDataBase();

            myDataBase.openConnection();
            DataSet dataSet = new DataSet();
            SqlCommand command = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY studentID ASC) AS N'Order',studentID as 'Student ID',studentFName as 'First Name',studentLName as 'Last Name',studentBDate,studentEmail,picture FROM [WINDOWCLASS].[dbo].[STUDENT] ", myDataBase.getConnection);


            command.CommandType = CommandType.Text;
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);
            myDataBase.closeConnection();



            dataGridView1.DataSource = dt;
           DataGridViewImageColumn picCol = new DataGridViewImageColumn();
              dataGridView1.RowTemplate.Height = 80;
              picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
              picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;



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
