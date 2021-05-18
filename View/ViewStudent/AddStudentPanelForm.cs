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
using WindowClassProject.Model;

namespace WindowClassProject.View.ViewStudent
{
    public partial class AddStudentPanelForm : Form
    {
        public AddStudentPanelForm()
        {
            InitializeComponent();
            birthDatePicker.Format = DateTimePickerFormat.Custom;
            birthDatePicker.CustomFormat = "dd/MM/yyyy";

        }
    
        private void AddStudentPanelForm_Load(object sender, EventArgs e)
        {
            loadClassBox();
        }

        private void addPerson1_Load(object sender, EventArgs e)
        {

        }


        public void loadClassBox()
        {
            ClassDAO cla = new ClassDAO();
            DataTable dt = cla.getDataClassIntoDataTable();
        
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ClassModel mo = new ClassModel(dt.Rows[i]["classID"].ToString(), Int32.Parse(dt.Rows[i]["schoolyear"].ToString()));
                classCombox.Items.Add(mo);
            }
            classCombox.DisplayMember = "classID";
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
        byte[] convertImageToBinary(Image img)
        {
            using (MemoryStream mm = new MemoryStream())
            {
                img.Save(mm, System.Drawing.Imaging.ImageFormat.Png);
                return mm.ToArray();
            }

        }
        public void resertAll()
        {
            IDTxt.Text = "";
            fNameTxt.Text = "";
            lNameTxt.Text = "";
            cmndTxt.Text = "";
            addressTxt.Text = "";
            emailTxt.Text = "";
            phoneTxt.Text = "";
            pictureAccount.Image = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resertAll();
        }
        string imagesLocation = "";
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

        //
        int genderValue = 0;
        //male =0, female=1
        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderValue = 0;
        }

        private void FeMaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderValue = 1;
        }

        private void addInforStudentBtn_Click(object sender, EventArgs e)
        {
            StudentDAO stu = new StudentDAO();
            if (checkValid()==true && stu.checkExistStudent(IDTxt.Text) == false)
            {

                byte[] images = null;
                FileStream stream = new FileStream(imagesLocation, FileMode.Open, FileAccess.Read);
                BinaryReader bin = new BinaryReader(stream);
                images = bin.ReadBytes((int)stream.Length);
                MemoryStream myStream = new MemoryStream();
               pictureAccount.Image.Save(myStream, System.Drawing.Imaging.ImageFormat.Png);
                ClassModel co = classCombox.SelectedItem as ClassModel;

              bool check=  stu.insertNewStudent(IDTxt.Text,fNameTxt.Text,lNameTxt.Text,birthDatePicker.Value,addressTxt.Text,genderValue,phoneTxt.Text,emailTxt.Text,cmndTxt.Text,myStream,co.classID);
                if (check == true)
                {
                    MessageBox.Show("Add sucess", "Information");
                    
                }
            }

        }

        private void cmndTxt_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(cmndTxt.Text, @"\b\d+\b"))
            {
                MessageBox.Show("only Number");
            }
        }

        private void backPageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
