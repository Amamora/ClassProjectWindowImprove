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

        #region insert new student by parameter

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
        #endregion
        #region check exist student by sql code or linq 
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

        public bool checkExistByLinQ(string studentID)
        {
            using(MyLinQDataContext db=new MyLinQDataContext())
            {
                var scource = from STUDENT stu in db.STUDENTs
                              where stu.studentID == studentID
                              select stu;
                if (scource.Count() > 0)
                {
                    return false;
                }
            }
            return false;

        }
        #endregion

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
              dataGridView1.RowTemplate.Height = 90;
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
        #region
        public void connectionDetailStudent()
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



           /* dataGridView1.DataSource = dt;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
        }
        #endregion

        #region load data for editting panel
        public DataTable LoadDataToEdit(string studentID)
        {
            MyDataBase myDataBase = new MyDataBase();

            myDataBase.openConnection();


            SqlCommand command = new SqlCommand("SELECT * FROM [WINDOWCLASS].[dbo].[STUDENT] WHERE studentID=@stu", myDataBase.getConnection);
            command.Parameters.Add("@stu", SqlDbType.NVarChar).Value = studentID;

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);
            sqlAdapt.SelectCommand = command;


            sqlAdapt.Fill(dt);
            myDataBase.closeConnection();



            return dt;



        }
        #endregion

        #region update information for student
        //(string studentID, string  studentFName, string lastName, DateTime date, string adress,int gender, string phone,string email,string cmnd, MemoryStream picture,string classID)
        public bool updateInforStudent(string id, string fname, string lname, DateTimePicker bdate, string adress, int gender, string phone, string email, string cmnd, MemoryStream picture, string classID, string studentID)
        {
            MyDataBase myDataBase = new MyDataBase();




            SqlCommand sqlCommand = new SqlCommand("UPDATE [WINDOWCLASS].[dbo].[STUDENT] SET studentID=@id, studentFName=@fname, studentLName=@lname, studentBDate=@bdate,studentAddress=@address,studentGender=@gender, studentPhone=@phone,studentEmail=@email,studentCMND=@cmnd,picture =@picture,classID=@class " + "WHERE studentID=@initialID", myDataBase.getConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            sqlCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            sqlCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            sqlCommand.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate.Value;
            sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = adress;
            sqlCommand.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;

            sqlCommand.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
            sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;


            sqlCommand.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            sqlCommand.Parameters.Add("@class", SqlDbType.NVarChar).Value = classID;
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
        #region search student by ID
        public void searchStudentByid(string id, DataGridView dataGridView1)
        {
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                var count = from STUDENT s in db.STUDENTs
                            where s.studentID == id
                            select s;
                if (count.Count() == 0)
                {
                    MessageBox.Show("ID student not exist");
                    return;
                }

            }
            MyDataBase myDataBase = new MyDataBase();
            myDataBase.openConnection();
            DataSet dataSet = new DataSet();
            SqlCommand command = new SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY studentID ASC) AS N'Order',studentID as 'Student ID',studentFName as 'First Name',studentLName as 'Last Name', studentBDate, studentEmail, picture FROM [WINDOWCLASS].[dbo].[STUDENT] WHERE studentID =@stu ", myDataBase.getConnection);
            command.Parameters.Add("@stu", SqlDbType.NVarChar).Value = id;
            dataGridView1.RowTemplate.Height = 80;

            command.CommandType = CommandType.Text;
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlAdapt.Fill(dt);




            dataGridView1.DataSource = dt;
            myDataBase.closeConnection();

        }
        #endregion



    }
}
