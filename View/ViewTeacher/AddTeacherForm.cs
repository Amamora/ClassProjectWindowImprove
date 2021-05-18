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

namespace WindowClassProject.View.ViewTeacher
{
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
            birthDatePicker.Format = DateTimePickerFormat.Custom;
            birthDatePicker.CustomFormat = "dd/MM/yyyy";
        }
        int genderValue = 0;
        private void FeMaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderValue = 1;
        }
        string imagesLocation = "";
        private void addInforStudentBtn_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                using (MyLinQDataContext db = new MyLinQDataContext())
                {
                    TEACHER insert = new TEACHER();
                    insert.teacherID = IDTxt.Text;
                    insert.teacherFName = fNameTxt.Text;
                    insert.teacherLName = lNameTxt.Text;
                    insert.teacherPhone = phoneTxt.Text;
                    insert.teacherEmail = emailTxt.Text;
                    insert.teacherBDate = birthDatePicker.Value;

                    byte[] images = null;
                    FileStream stream = new FileStream(imagesLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bin = new BinaryReader(stream);
                    images = bin.ReadBytes((int)stream.Length);
                    MemoryStream myStream = new MemoryStream();
                    pictureAccount.Image.Save(myStream, System.Drawing.Imaging.ImageFormat.Png);
                    insert.picture = myStream.ToArray();
                    insert.teacherCMND = cmndTxt.Text;
                    db.TEACHERs.InsertOnSubmit(insert);

                    db.SubmitChanges();
                    MessageBox.Show("insert Sucess!!");
                    resertAll();

                }
            }
        }
        byte[] convertImageToBinary(Image img)
        {
            using (MemoryStream mm = new MemoryStream())
            {
                img.Save(mm, System.Drawing.Imaging.ImageFormat.Png);
                return mm.ToArray();
            }

        }
        private void AddTeacherForm_Load(object sender, EventArgs e)
        {

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
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                var count = from TEACHER te in db.TEACHERs
                            where te.teacherID == IDTxt.Text
                            select te;
                if (count.Count() > 0)
                {
                    MessageBox.Show("The already ID teacher exist in database");
                    return false;
                }

            }

                return true;

        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderValue = 0;
        }

        private void upImageBtn_Click(object sender, EventArgs e)
        {

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

        private void backPageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
