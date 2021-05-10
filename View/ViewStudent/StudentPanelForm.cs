using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Word;
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
using Word = Microsoft.Office.Interop.Word;

namespace WindowClassProject.View.ViewStudent
{
    public partial class StudentPanelForm : Form
    {
        public StudentPanelForm()
        {

            InitializeComponent();

            

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentPanelForm add = new AddStudentPanelForm();
            add.Show();
        }

        private void StudentPanelForm_Load(object sender, EventArgs e)
        {
            using (MyLinQDataContext mydata = new MyLinQDataContext())
            {
                var counts = mydata.STUDENTs.GroupBy(x => x.studentID).Select(g => g.Count());

                totalStudentLbl.Text = "Total Student: " + counts.Count();
            }
            loadDataForDataGrid(dataStudentGridView);
            
        }
        private void loadDataForDataGrid(DataGridView dataGridView)
        {
            StudentDAO stu = new StudentDAO();
            stu.connectionDataBase(dataGridView);
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            //export file word
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WORD DOCUMENT (*.docx)|*.docx";
            sfd.FileName = "Output.docx";
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
                        MessageBox.Show("It wasn't possible to write data to word",ex.Message);
                    }
                }

                //check error file
                if (!fileError)
                {

                    try
                    { 
                        CreateWordDocument(dataStudentGridView, sfd.FileName);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }

                }

            }
        }

        #region exportExcelFile
        private void exportExcelButton_Click(object sender, EventArgs e)
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

        #region button export PDF file
        private void exportPDFButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Output.pdf";
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
                        MessageBox.Show("It wasn't possible to write data to pdf",ex.Message);
                    }
                }

                //check error file
                if (!fileError)
                {
                    //if no error
                    try
                    {
                        iTextSharp.text.pdf.PdfPTable pdfTable = new PdfPTable(dataStudentGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;


                        foreach (DataGridViewColumn column in dataStudentGridView.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }
                        for (int i = 0; i < dataStudentGridView.Rows.Count; i++)
                        {

                            string id = dataStudentGridView.Rows[i].Cells[0].Value.ToString();
                            pdfTable.AddCell(id);
                            pdfTable.AddCell(dataStudentGridView.Rows[i].Cells[1].Value.ToString());
                            pdfTable.AddCell(dataStudentGridView.Rows[i].Cells[2].Value.ToString());
                            pdfTable.AddCell(dataStudentGridView.Rows[i].Cells[3].Value.ToString());
                            pdfTable.AddCell(dataStudentGridView.Rows[i].Cells[4].Value.ToString());
                            pdfTable.AddCell(dataStudentGridView.Rows[i].Cells[5].Value.ToString());
                            pdfTable.AddCell(dataStudentGridView.Rows[i].Cells[6].Value.ToString());

                            byte[] imagesbyte = (byte[])(dataStudentGridView.Rows[i].Cells[7].Value);
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

        #region creadocument for report
        public void CreateWordDocument(DataGridView dataGrid, string fileName)
        {
            //Declare size of table
            int rows = dataGrid.Rows.Count + 1;
            int columns = dataGrid.Columns.Count;

            //Create an instance for word app  
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            //Set status for word application is to be visible or not.  
            winword.Visible = false;

            //Create a missing variable for missing value  
            object missing = System.Reflection.Missing.Value;

            //Create a new document  
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            //Set page orientation
            document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

            //adding text to document  
            document.Content.SetRange(0, 0);
            document.Range(0, document.Content.Text.Length).Font.Bold = 3;
            document.Range(0, document.Content.Text.Length).Font.Name = "Times New Roman";
            document.Range(0, document.Content.Text.Length).Font.Size = 20;
            winword.Selection.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            document.Content.Text = "List Student " + Environment.NewLine;

            //Add paragraph with Heading 1 style  

            Microsoft.Office.Interop.Word.Paragraph para0 = document.Content.Paragraphs.Add(ref missing);
            para0.Range.ParagraphFormat.FirstLineIndent = 5;
            object styleHeading0 = "Normal";
            para0.Range.set_Style(ref styleHeading0);
            para0.Range.Font.Size = 14;
            para0.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            para0.Range.Text = "Term : " + Environment.NewLine;
            para0.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
            object styleHeading1 = "Normal";
            para1.Range.set_Style(ref styleHeading1);
            para1.Range.Font.Bold = 4;
            para1.Range.Font.Size = 10;


            string pa1 = "\n Subject : WindowPrograming \n Hoc Phan:\n CBGD: \n Hình thức đánh giá quá trình:";
            para1.Range.Text = pa1;
            para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            para1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para1.Range.InsertParagraphAfter();



            //Add paragraph with Heading 2 style  
            Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
            object styleHeading2 = "Normal";
            para2.Range.set_Style(ref styleHeading2);
            para2.Range.ParagraphFormat.LineUnitAfter = 10;
            para2.Range.Text = "SL Student: " + dataStudentGridView.Rows.Count;
            para2.Range.Font.Size = 10;
            para2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            para2.Range.InsertParagraphAfter();

            //Create Table
            Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para1.Range, rows, columns, ref missing, ref missing);
            firstTable.Borders.Enable = 1;
            firstTable.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            firstTable.Range.Font.Name = "Verdana";
            firstTable.Range.Font.Size = 10;

            foreach (Microsoft.Office.Interop.Word.Row row in firstTable.Rows)
            {
                foreach (Microsoft.Office.Interop.Word.Cell cell in row.Cells)
                {
                    //Header row  
                    if (cell.RowIndex == 1)
                    {
                        cell.Range.Text = dataGrid.Columns[cell.ColumnIndex - 1].HeaderText;

                        cell.Range.Font.Bold = 1;
                        cell.Range.Font.Name = "Verdana";
                        cell.Range.Font.Size = 10;

                        cell.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    }
                    //Data row  
                    else
                    {
                        int x = cell.RowIndex - 1;
                        int y = cell.ColumnIndex;

                        cell.Range.Font.Bold = 0;
                        cell.Range.Font.Name = "Verdana";
                        cell.Range.Font.Size = 9.5f;

                        if (dataGrid.Rows[x - 1].Cells[y - 1].Value.GetType() == typeof(byte[]))
                        {
                            System.Drawing.Image image1 = byteArrayToImage((byte[])dataGrid.Rows[x - 1].Cells[y - 1].Value);
                            image1.Save(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                            cell.Select();
                            cell.Range.Text = " ";
                            document.InlineShapes.AddPicture(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                            File.Delete(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                        }
                        else if (dataGrid.Rows[x - 1].Cells[y - 1].Value.GetType() == typeof(DateTime))
                        {
                            cell.Range.Text = ((DateTime)dataGrid.Rows[x - 1].Cells[y - 1].Value).ToString("dd /MM/yyyy");
                        }
                        else
                        {
                            cell.Range.Text = dataGrid.Rows[x - 1].Cells[y - 1].Value.ToString();
                        }
                    }
                }
            }

            //Save the document
            winword.Application.Visible = true;
            document.SaveAs2(fileName);
            /*document.Close(ref missing, ref missing, ref missing);
            
            document = null;
           
           winword.Quit(ref missing, ref missing, ref missing);
           
            winword = null;*/
            MessageBox.Show("Document Created Successfully!", "Export File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //open file document

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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            StudentPanelForm_Load(sender, e);
        }

        private void totalStudentLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
