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
using Word = Microsoft.Office.Interop.Word ;

using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WindowClassProject.View.ViewCourse
{
    public partial class CoursePanelForm : Form
    {
        public CoursePanelForm()
        {
            InitializeComponent();
        }

        private void CoursePanelForm_Load(object sender, EventArgs e)
        {
            CourseDAO course = new CourseDAO();
            //course.connectionDataBase(dataCourseGrid);
            DataTable tb = course.LoadCourse();
            dataCourseGrid.DataSource = tb;
            dataCourseGrid.RowTemplate.Height = 80;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            CoursePanelForm_Load(sender, e);
        }
        #region create document course
        private void exportWordFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WORD DOCUMENT (*.docx)|*.docx";
            sfd.FileName = "OutputCourse.docx";
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
                        MessageBox.Show("It wasn't possible to write data to word", "Error :" + ex.Message);
                    }
                }

                //check error file
                if (!fileError)
                {

                    try
                    {



                        //ExportToWord(dataStudentGridView, sfd.FileName);
                        CreateWordDocument(dataCourseGrid, sfd.FileName);




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }

                }
            }
        }


        public void CreateWordDocument(DataGridView dataGrid, string fileName)
        {
            try
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
                document.Content.Text = "List Course " + Environment.NewLine;

                //Add paragraph with Heading 1 style  

                Microsoft.Office.Interop.Word.Paragraph para0 = document.Content.Paragraphs.Add(ref missing);
                para0.Range.ParagraphFormat.FirstLineIndent = 5;
                object styleHeading0 = "Normal";
                para0.Range.set_Style(ref styleHeading0);
                para0.Range.Font.Size = 14;
                para0.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para0.Range.Text = "Term 2 - YEAR 2020-2021";
                para0.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Normal";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.ParagraphFormat.LineUnitAfter = 10;
                para2.Range.Font.Bold = 5;
                para2.Range.Font.Color = Word.WdColor.wdColorRed;
                para2.Range.Text = "SL Course " + dataGrid.Rows.Count;
                para2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                para2.Range.InsertParagraphAfter();

                //Create Table
                Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para2.Range, rows, columns, ref missing, ref missing);
                firstTable.Borders.Enable = 1;
                firstTable.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                firstTable.Range.Font.Name = "Verdana";
                firstTable.Range.Font.Size = 10;


                //Saves the file in the given path.

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

                            if (dataGrid.Rows[x - 1].Cells[y - 1].Value.GetType() == typeof(DateTime))
                            {
                                cell.Range.Text = ((DateTime)dataGrid.Rows[x - 1].Cells[y - 1].Value).ToString("dd /MM/yyyy");
                            }
                            else
                            {
                                cell.Range.Text = dataGrid.Rows[x - 1].Cells[y - 1].Value.ToString();
                            }
                        }
                    }

                    //set background of row
                    if (row.Index == 1)
                    {

                    }
                    if (row.Index % 2 == 0)
                    {

                    }

                }




                //Save the document
                winword.Application.Visible = true;
                document.SaveAs2(fileName);
                /*document.Close(ref missing, ref missing, ref missing);

                document = null;

               winword.Quit(ref missing, ref missing, ref missing);

                winword = null;*/
                MessageBox.Show("Document of Course Created Successfully!", "Export File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //open file document 
            } catch (Exception ex)
            {
                MessageBox.Show("Error Please Contact with me : *********!", "Error export file :" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion
        #region create document excel
        private void exportExcelFileBtn_Click(object sender, EventArgs e)
        {
            exExcel(dataCourseGrid);
        }
        public void exExcel(DataGridView dataView)
        {
            //event export file excel
            if (dataView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();//add reference microsof Office
                Microsoft.Office.Interop.Excel._Workbook workbook = xcel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null; //create worksheet excel
                xcel.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from Datastudent";
                for (int i = 1; i < dataView.Columns.Count + 1; i++)
                {
                    xcel.Cells[1, i] = dataView.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataView.Columns.Count; j++)
                    {

                        /* if (dataView.Rows[i].Cells[j].Value.GetType() == typeof(byte[]))
                         {
                             //store picture into byte
                             System.Drawing.Image image1 = byteArrayToImage((byte[])dataShowCoursePanel.Rows[i].Cells[j].Value);

                             image1.Save(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                             Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 2, j + 1];
                             float Left = (float)((double)oRange.Left); //set up size of picture
                             float Top = (float)((double)oRange.Top);

                             worksheet.Shapes.AddPicture(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 32, 32);
                             oRange.RowHeight = 36;
                             File.Delete(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                         }
                         else*/
                        xcel.Cells[i + 2, j + 1] = dataView.Rows[i].Cells[j].Value.ToString();


                    }
                    xcel.Columns.AutoFit();
                    xcel.Visible = true;




                }
            }
            #endregion
        }
        #region export PDF file
        private void exportPDFBtn_Click(object sender, EventArgs e)
        {
            exPDF(dataCourseGrid);
        }

        private void exPDF(DataGridView dataGridView)
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
                        MessageBox.Show("It wasn't possible to write data to pdf", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //check error file
                if (!fileError)
                {
                    //if no error
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;


                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {

                                /* if (dataView.Rows[i].Cells[j].Value.GetType() == typeof(byte[]))
                                 {
                                     //store picture into byte
                                     System.Drawing.Image image1 = byteArrayToImage((byte[])dataShowCoursePanel.Rows[i].Cells[j].Value);

                                     image1.Save(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                                     Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 2, j + 1];
                                     float Left = (float)((double)oRange.Left); //set up size of picture
                                     float Top = (float)((double)oRange.Top);

                                     worksheet.Shapes.AddPicture(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 32, 32);
                                     oRange.RowHeight = 36;
                                     File.Delete(@"E:\E_PART2\HKII__2021\Windown_Program\Day1\ex1\Screenshot 2021-02-25 000816.png");
                                 }
                                 else*/

                                pdfTable.AddCell(dataGridView.Rows[i].Cells[j].Value.ToString());


                            }
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

        private void fastManageBtn_Click(object sender, EventArgs e)
        {
            ManageCourseFast fast = new ManageCourseFast();
            fast.Show();
        }
     
    }
}
