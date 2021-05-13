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

namespace WindowClassProject.View.ViewTeacher
{
    public partial class EditTeacherForm : Form
    {
        public EditTeacherForm()
        {
            InitializeComponent();
        }
        public EditTeacherForm(string teacherID)
        {
            InitializeComponent();
            this.teacherID = teacherID;
            loadDataTeacher();
        }
        private string teacherID;
        private bool genderV = true;

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            birthDatePicker.Format = DateTimePickerFormat.Custom;
            birthDatePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void upImageBtn_Click(object sender, EventArgs e)
        {
            string imagesLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagesLocation = dialog.FileName.ToString();

                    pictureAccount.ImageLocation = imagesLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadDataTeacher()
        {
            TeacherDAO teach = new TeacherDAO();
            DataTable table = teach.getDataTableTeacher(teacherID);
            this.IDTxt.Text = table.Rows[0]["teacherID"].ToString();
            this.fNameTxt.Text = table.Rows[0]["teacherFName"].ToString();
            this.lNameTxt.Text = table.Rows[0]["teacherLName"].ToString();
            this.cmndTxt.Text = table.Rows[0]["teacherCMND"].ToString();
            this.phoneTxt.Text = table.Rows[0]["teacherPhone"].ToString();
            this.emailTxt.Text = table.Rows[0]["teacherEmail"].ToString();

            this.genderV = (bool)table.Rows[0]["teacherGender"];
            this.birthDatePicker.Value = (DateTime)table.Rows[0]["teacherBDate"];



            byte[] pic;
            pic = (byte[])table.Rows[0]["picture"];
            MemoryStream picture = new MemoryStream(pic);

            pictureAccount.Image = System.Drawing.Image.FromStream(picture);
            //tru 1 false 0
            if (genderV == true)
            {
                maleRadio.Checked = true;

            }
            else
            {
                FeMaleRadio.Checked = true;
            }

        }
        public void resertAll()
        {
            IDTxt.Text = "";
            fNameTxt.Text = "";
            lNameTxt.Text = "";
            cmndTxt.Text = "";

            emailTxt.Text = "";
            phoneTxt.Text = "";
            pictureAccount.Image = null;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            resertAll();
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderV = true;
        }

        private void FeMaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderV = false;
        }

        private void backPageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void editInforBtn_Click(object sender, EventArgs e)
        {
            int born_year = birthDatePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year > 50))
            {
                MessageBox.Show("The teachẻ age need larger 20 years old", "Birth date error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (checkValid() == true)
            {
                MemoryStream pic = new MemoryStream();
                pictureAccount.Image.Save(pic, pictureAccount.Image.RawFormat);
                TeacherDAO teach = new TeacherDAO();
                int gen = true ? 1 : 0;
                teach.updateInforTeacher(IDTxt.Text, fNameTxt.Text, lNameTxt.Text, birthDatePicker, gen, phoneTxt.Text, emailTxt.Text, cmndTxt.Text, pic, teacherID);

            }



        }
        public bool checkValid()
        {
            if (lNameTxt.Text == "" || fNameTxt.Text == "" || phoneTxt.Text == "" || pictureAccount.Image == null)
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
            if (!Regex.IsMatch(fNameTxt.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                fNameTxt.Focus();
                return false;

            }
            if (!Regex.IsMatch(fNameTxt.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lNameTxt.Focus();
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
    }
}
