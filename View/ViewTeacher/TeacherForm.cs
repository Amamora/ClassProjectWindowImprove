using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Word;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            loadDataTeacher();

        }
        private void loadDataTeacher()
        {

            TeacherDAO teach = new TeacherDAO();
            teach.connectGetAllTeacher(dataTeacherGridView);

        }


        #region action transfer binary to image or byte
        public static System.Drawing.Image BinaryToImage(System.Data.Linq.Binary binaryData)
        {
            if (binaryData == null) return null;

            byte[] buffer = binaryData.ToArray();
            MemoryStream memStream = new MemoryStream();
            memStream.Write(buffer, 0, buffer.Length);
            return System.Drawing.Image.FromStream(memStream);
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

        public System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = System.Drawing.Image.FromStream(ms);

                return returnImage;
            }
        }

        #endregion
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchLoadTeacher();
        }
        public void searchLoadTeacher()
        {
            TeacherDAO teach = new TeacherDAO();
            teach.searchTeacher(searchBox.Text, dataTeacherGridView);
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
            add.ShowDialog();
        }

        private void dataTeacherGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditTeacherForm edit = new EditTeacherForm(dataTeacherGridView.CurrentRow.Cells[1].Value.ToString());
            edit.ShowDialog();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {




        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            TeacherDAO teach = new TeacherDAO();
            teach.searchTeacher(searchBox.Text, dataTeacherGridView);


        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == (char)Keys.Enter)
            {

                
            }*/

            /*if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }*/
        }

        private void searchBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = searchBox.Text;
                TeacherDAO teach = new TeacherDAO();

                teach.searchTeacher(id, dataTeacherGridView);
                searchBox.Clear();

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            TeacherForm_Load(sender, e);
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            //export file word
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WORD DOCUMENT (*.docx)|*.docx";
            sfd.FileName = "OutputTeacher.docx";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write data to word", ex.Message);
                    }
                }

                //check error file
                if (!fileError)
                {

                    try
                    {

                        Export(dataTeacherGridView, sfd.FileName);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }

                }

            }
        }
        #region action spire doc
        private void AddHeaderTitle(Spire.Doc.Section section)
        {
            Spire.Doc.Documents.Paragraph para1 = section.AddParagraph();
            para1.AppendText("TRƯỜNG ĐẠI HỌC SPKT TP.HCM").CharacterFormat.Bold = true;
            Spire.Doc.Tab tab1 = para1.Format.Tabs.AddTab(639);
            tab1.TabLeader = TabLeader.NoLeader;
            para1.AppendText("\tNgày :01/05/2021\n");

            Spire.Doc.Documents.Paragraph para2 = section.AddParagraph();
            Spire.Doc.Tab tab2 = para1.Format.Tabs.AddTab(36);
            para1.AppendText("\tPHÒNG ĐÀO TẠO\t").CharacterFormat.Bold = true;
            tab2 = para1.Format.Tabs.AddTab(693);
            tab2.TabLeader = TabLeader.NoLeader;

            Spire.Doc.Documents.Paragraph para3 = section.AddParagraph();
            para3.AppendText("DANH SÁCH GIÁO VIÊN\n").CharacterFormat.Bold = true;
            para3.AppendText("\nHỌC KỲ: HK02 - NĂM HỌC 2020 - 2021\n").CharacterFormat.Bold = true;
            para3.AppendText("\nSố Lượng :" + dataTeacherGridView.Rows.Count + "\n").CharacterFormat.Bold = true;
            para3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;


        }

        public void Export(DataGridView dataGrid, string filename)
        {
            Spire.Doc.Document document = new Spire.Doc.Document();
            Spire.Doc.Section section = document.AddSection();
            section.PageSetup.Orientation = Spire.Doc.Documents.PageOrientation.Landscape;

            AddHeaderTitle(section);

            Spire.Doc.Table table = section.AddTable(true);
            String[] header = { "Order", "Teacher ID", "Teacher  Firstname", " Teacher LastName", "Email", "Picture" };
            int RowCount = dataGrid.Rows.Count;
            int ColumnCount = dataGrid.Columns.Count;
            String[][] data = new String[RowCount][];
            for (int i = 0; i < RowCount; i++)
            {
                data[i] = new String[ColumnCount];
            }

            //add rows
            for (int c = 0; c < ColumnCount; c++)
            {
                for (int r = 0; r < RowCount; r++)
                {
                    if (dataGrid.Rows[r].Cells[c].Value.GetType() != typeof(byte[]))
                    {
                        if (dataGrid.Rows[r].Cells[c].Value.GetType() == typeof(DateTime))
                        {
                            data[r][c] = ((DateTime)dataGrid.Rows[r].Cells[c].Value).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            data[r][c] = dataGrid.Rows[r].Cells[c].Value.ToString();
                        }
                    }
                    else
                    {
                        data[r][c] = "";
                    }
                }
            }

            table.ResetCells(data.Length + 1, header.Length);

            TableRow FRow = table.Rows[0];
            FRow.IsHeader = false;
            FRow.Height = 23;
            //FRow.RowFormat.BackColor = Color.AliceBlue;
            for (int i = 0; i < header.Length; i++)
            {
                //Cell Alignment
                Spire.Doc.Documents.Paragraph p = FRow.Cells[i].AddParagraph();
                FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                //Data Format
                Spire.Doc.Fields.TextRange TR = p.AppendText(header[i]);
                TR.CharacterFormat.FontName = "Calibri";
                TR.CharacterFormat.FontSize = 14;
                TR.CharacterFormat.TextColor = Color.Black;
                TR.CharacterFormat.Bold = true;
            }

            //Data Row
            for (int r = 0; r < data.Length; r++)
            {
                TableRow DataRow = table.Rows[r + 1];

                //Row Height
                DataRow.Height = 20;

                //C Represents Column.
                for (int c = 0; c < data[r].Length; c++)
                {
                    //Cell Alignment
                    DataRow.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    //Fill Data in Rows
                    Spire.Doc.Documents.Paragraph p2 = DataRow.Cells[c].AddParagraph();
                    Spire.Doc.Fields.TextRange TR2 = p2.AppendText(data[r][c]);
                    //Format Cells
                    p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                    TR2.CharacterFormat.FontName = "Calibri";
                    TR2.CharacterFormat.FontSize = 12;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }

            for (int i = 0; i < RowCount; i++)
            {
                string path = System.Windows.Forms.Application.StartupPath;
                System.Drawing.Image image1 = byteArrayToImage((byte[])dataGrid.Rows[i].Cells[5].Value);
                image1.Save(path + "\\p1.PNG");
                DocPicture pic = table.Rows[i + 1].Cells[5].Paragraphs[0].AppendPicture((image1));
                pic.Width = 80;
                pic.Height = 80;
                File.Delete(path + "\\p1.PNG");
            }

            //Save and Launch
            document.SaveToFile(filename);
            MessageBox.Show("Export DOC file sucess!", "Export File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();

        }
        #endregion


        #region byte array to image
        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
        #endregion

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void exportExcelButton_Click(object sender, EventArgs e)
        {
            exportToExcel(dataTeacherGridView);

        }

        #region action export excel file
        public void exportToExcel(DataGridView dataStudentGridView)
        {

            //event export file excel
            if (dataStudentGridView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();//add reference microsof Office
                Microsoft.Office.Interop.Excel._Workbook workbook = xcel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null; //create worksheet excel
                xcel.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from Datastudent";
                for (int i = 1; i < dataStudentGridView.Columns.Count + 1; i++)
                {
                    xcel.Cells[1, i] = dataStudentGridView.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataStudentGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataStudentGridView.Columns.Count; j++)
                    {

                        if (dataStudentGridView.Rows[i].Cells[j].Value.GetType() == typeof(byte[]))
                        {
                            //store picture into byte
                            System.Drawing.Image image1 = byteArrayToImage((byte[])dataStudentGridView.Rows[i].Cells[j].Value);

                            image1.Save(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                            Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 2, j + 1];
                            float Left = (float)((double)oRange.Left); //set up size of picture
                            float Top = (float)((double)oRange.Top);

                            worksheet.Shapes.AddPicture(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 32, 32);
                            oRange.RowHeight = 36;
                            File.Delete(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                        }
                        else
                            xcel.Cells[i + 2, j + 1] = dataStudentGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;




            }
        }
        #endregion
        #region action PDF
        private void exportPDFButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "OutputTeacher.pdf";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write data to pdf", ex.Message);
                    }
                }

                //check error file
                if (!fileError)
                {
                    //if no error
                    try
                    {
                        iTextSharp.text.pdf.PdfPTable pdfTable = new PdfPTable(dataTeacherGridView.Columns.Count);

                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        //focuss how to create unicode with itexsharp.........

                        foreach (DataGridViewColumn column in dataTeacherGridView.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }
                        for (int i = 0; i < dataTeacherGridView.Rows.Count; i++)
                        {

                            string id = dataTeacherGridView.Rows[i].Cells[0].Value.ToString();
                            pdfTable.AddCell(id);
                            pdfTable.AddCell(dataTeacherGridView.Rows[i].Cells[1].Value.ToString());
                            pdfTable.AddCell(dataTeacherGridView.Rows[i].Cells[2].Value.ToString());
                            pdfTable.AddCell(dataTeacherGridView.Rows[i].Cells[3].Value.ToString());
                            pdfTable.AddCell(dataTeacherGridView.Rows[i].Cells[4].Value.ToString());


                            byte[] imagesbyte = (byte[])(dataTeacherGridView.Rows[i].Cells[5].Value);
                            iTextSharp.text.Image myimage = iTextSharp.text.Image.GetInstance(imagesbyte);
                            pdfTable.AddCell(myimage);




                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);

                            pdfDoc.Close();
                            stream.Close();

                        }

                        MessageBox.Show(" PDF Data Exported Successfully !!!", "Info");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Info");
                }
            }
        }


        #endregion

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            TeacherForm_Load(sender,e);
        }
    }
}


