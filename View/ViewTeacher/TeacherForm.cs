using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowClassProject.DAO;

namespace WindowClassProject.View.ViewTeacher
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            dataTeacherGridView.RowTemplate.Height = 80;
        }
        /*
         well in here we will use thing more intersting ~~ LinQ c# truy van query instead of using query of SQL 
        advance: tu nhien va de dang hon
         
         */
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            TeacherDAO teach = new TeacherDAO();
            teach.connectGetAllTeacher(dataTeacherGridView);
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
              
               

                var count = db.TEACHERs.GroupBy(x => x.teacherID).Select(x => x.Count());
                totalTeacherLbl.Text = "Total Teacher:" + count.Count();
               /* var scourse = from TEACHER te in db.TEACHERs
                              select new
                              {
                                  TeacherID = te.teacherID,
                                  teacherImag = (te.picture).ToArray()
                              };

                dataTeacherGridView.DataSource = scourse;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
               dataTeacherGridView.RowTemplate.Height = 80;
                picCol = (DataGridViewImageColumn)dataTeacherGridView.Columns[1];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;*/


                //try to retrive binary to image~~



            }
    }


        #region action transfer binary to image or byte
        public static Image BinaryToImage(System.Data.Linq.Binary binaryData)
        {
            if (binaryData == null) return null;

            byte[] buffer = binaryData.ToArray();
            MemoryStream memStream = new MemoryStream();
            memStream.Write(buffer, 0, buffer.Length);
            return Image.FromStream(memStream);
        }

        public static byte[] ImageToBinary(string imagePath)
        {
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, (int)fileStream.Length);
            fileStream.Close();
            return buffer;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }

        #endregion
        private void searchButton_Click(object sender, EventArgs e)
        {
            using(MyLinQDataContext db=new MyLinQDataContext())
            {
                dataTeacherGridView.DataSource = from teach in db.TEACHERs
                                                 select teach;
            }
        }

        #region action direct in datagridview
        private void removeBtn_Click(object sender, EventArgs e)
        {
            using (MyLinQDataContext db = new MyLinQDataContext())
            {
                string teachID = dataTeacherGridView.SelectedCells[0].OwningRow.Cells["teacherID"].Value.ToString();

                TEACHER te = db.TEACHERs.Where(p => p.teacherID.Equals(teachID)).FirstOrDefault();
                db.TEACHERs.DeleteOnSubmit(te);

                db.SubmitChanges();
            }
            TeacherForm_Load(sender, e);
        }

      


        private void dataTeacherGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            removeBtn_Click(sender, e);
        }

        #endregion
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddTeacherForm add = new AddTeacherForm();
            add.Show();
        }
    }
}
