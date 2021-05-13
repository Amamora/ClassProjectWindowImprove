using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.DAO;

namespace WindowClassProject.View.ViewStudent
{
    public partial class EditStudentPanelForm : Form
    { 
        //create student object
       
        public EditStudentPanelForm()
        {
            InitializeComponent();
           
            birthDateTimePick.Format = DateTimePickerFormat.Custom;
            birthDateTimePick.CustomFormat = "dd/MM/yyyy";
        }
        private string studentID;
        private bool genderV;
        public EditStudentPanelForm(string studentID)
        {
            InitializeComponent();

            birthDateTimePick.Format = DateTimePickerFormat.Custom;
            birthDateTimePick.CustomFormat = "dd/MM/yyyy";
            this.studentID = studentID;
        }
        

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditStudentPanelForm_Load(object sender, EventArgs e)
        {
            StudentDAO stuDao = new StudentDAO();
            DataTable table = stuDao.LoadDataToEdit(studentID);
            this.studentIDTxt.Text = table.Rows[0]["studentID"].ToString();
            this.studentFNameTxt.Text = table.Rows[0]["studentFName"].ToString();
            this.studentLNameTxt.Text = table.Rows[0]["studentLName"].ToString();
            this.cmndTxt.Text = table.Rows[0]["studentCMND"].ToString();
            this.phoneTxt.Text = table.Rows[0]["studentPhone"].ToString();
            this.EmailTxt.Text = table.Rows[0]["studentEmail"].ToString();
            this.addressTxt.Text = table.Rows[0]["studentAddress"].ToString();
            this.genderV = (bool)table.Rows[0]["studentGender"];
            this.birthDateTimePick.Value = (DateTime)table.Rows[0]["studentBDate"];
            this.classCombox.Text = table.Rows[0]["classID"].ToString();


            byte[] pic;
            pic = (byte[])table.Rows[0]["picture"];
            MemoryStream picture = new MemoryStream(pic);

          pictureBoxStudent.Image = System.Drawing.Image.FromStream(picture);
            //tru 1 false 0
            if (genderV == true)
            {
                maleGenderRadio.Checked = true;

            }
            else
            {
                femaleGenderRadio.Checked = true;
            }
        }

        private void maleGenderRadio_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            genderV = true;

        }

        private void femaleGenderRadio_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            genderV = false;
        }


        private bool checkValid()
        {
            if (studentLNameTxt.Text == "" || studentFNameTxt.Text == "" || phoneTxt.Text == "" || pictureBoxStudent.Image == null)
            {
                // display popup box  
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } // end if 
            /* if (!Regex.Match(firstNameText.Text, "^[A-Z][a-zA-Z]").Success)
             {
                 // first name was incorrect  
                 MessageBox.Show("Invalid first name (ex:Kalist)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 firstNameText.Focus();
                 return false;
             } // end if   
             // if last name format invalid show message  
             if (!Regex.Match(lastNameText.Text, "^[A-Z][a-zA-Z]").Success)
             {
                 // last name was incorrect  
                 MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 lastNameText.Focus();
                 return false;
             }*/
            if (!Regex.IsMatch(studentFNameTxt.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

               studentLNameTxt.Focus();
                return false;

            }
            if (!Regex.IsMatch(studentLNameTxt.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               studentLNameTxt.Focus();
                return false;

            }

            // string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  //^([\w_\.\-\+])+\@([\w\-]+\.)+([\w]{2,10})+$
            string phonePattern = @"((09|03|07|08|05)+([0-9]{8})\b)$"; // VN Phone number pattern   
                                                                       //bool isEmailValid = Regex.IsMatch(emailText.Text, emailPattern);

            bool isPhoneValid = Regex.IsMatch(phoneTxt.Text, phonePattern);
            /* if (!isEmailValid)
             {
                 MessageBox.Show("Please enter a valid email");
                 return false;
             }*/


            if (!isPhoneValid)
            {
                MessageBox.Show("Please enter a valid phone number");
                return false;
            }
            //regex for only a sequence number \b\d+\b
            //


            return true;

        }

        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            int born_year = birthDateTimePick.Value.Year;
            int this_year = DateTime.Now.Year;
            int gen = (genderV == true) ? 1 : 0;
            if ((this_year - born_year) < 10 || (this_year - born_year > 50))
            {
                MessageBox.Show("The student age between 10 and 50 year", "Birth date error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (checkValid() == true)
            {
                StudentDAO stu = new StudentDAO();
                MemoryStream pic = new MemoryStream();
                pictureBoxStudent.Image.Save(pic, pictureBoxStudent.Image.RawFormat);

                stu.updateInforStudent(studentIDTxt.Text,studentFNameTxt.Text, studentLNameTxt.Text, birthDateTimePick, addressTxt.Text, gen, phoneTxt.Text, EmailTxt.Text, cmndTxt.Text, pic, classCombox.Text, studentID);


                this.Close();
            }

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            string imagesLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagesLocation = dialog.FileName.ToString();

                    pictureBoxStudent.ImageLocation = imagesLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
