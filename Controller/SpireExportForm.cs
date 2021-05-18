using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowClassProject.Controller
{
    class SpireExportForm
    {
        #region
        private void AddHeaderTitle(Spire.Doc.Section section)
        {
            Spire.Doc.Documents.Paragraph para1 = section.AddParagraph();
            para1.AppendText("TRƯỜNG ĐẠI HỌC SPKT TP.HCM").CharacterFormat.Bold = true;
            Spire.Doc.Tab tab1 = para1.Format.Tabs.AddTab(639);
            tab1.TabLeader = TabLeader.NoLeader;
            para1.AppendText("\tNgày in: 14/04/2021\n");

            Spire.Doc.Documents.Paragraph para2 = section.AddParagraph();
            Spire.Doc.Tab tab2 = para1.Format.Tabs.AddTab(36);
            para1.AppendText("\tPHÒNG ĐÀO TẠO\t").CharacterFormat.Bold = true;
            tab2 = para1.Format.Tabs.AddTab(693);
            tab2.TabLeader = TabLeader.NoLeader;
            para1.AppendText("\t Trang: 1\n");

            Spire.Doc.Documents.Paragraph para3 = section.AddParagraph();
            para3.AppendText("DANH SÁCH LỚP\n").CharacterFormat.Bold = true;
            para3.AppendText("\nHỌC KỲ: HK02 - NĂM HỌC 2020 - 2021\n").CharacterFormat.Bold = true;
            para3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

            Spire.Doc.Documents.Paragraph para4 = section.AddParagraph();
            para4.AppendText("Môn học/Nhóm:\t");
            Spire.Doc.Tab tab4 = para4.Format.Tabs.AddTab(261);
            tab4.TabLeader = TabLeader.NoLeader;
            para4.AppendText("Windows Programming (2+1) - 01CLC\t").CharacterFormat.Bold = true;
            tab4 = para4.Format.Tabs.AddTab(639);
            tab4.TabLeader = TabLeader.NoLeader;
            para4.AppendText("Số tín chỉ: 3\n");
            para4.AppendText("\nLớp học phần:\t");
            para4.AppendText("202WINPR230579E_01CLC\n").CharacterFormat.Bold = true;
            para4.AppendText("\nCBGD:\t");
            para4.AppendText("Lê Vĩnh Thịnh (0132)\n").CharacterFormat.Bold = true;
            para4.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
        }

        public void Export(DataGridView dataGrid, string filename)
        {
            Spire.Doc.Document document = new Spire.Doc.Document();
            Spire.Doc.Section section = document.AddSection();
            section.PageSetup.Orientation = Spire.Doc.Documents.PageOrientation.Landscape;

            AddHeaderTitle(section);

            Spire.Doc.Table table = section.AddTable(true);
            String[] header = { "ID", "Full Name", "Date of birth", "Gender", "Phone", "Email", "Position" };
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
                    if (dataGrid.Rows[r].Cells[c].Value.GetType() == typeof(DateTime))
                    {
                        data[r][c] = ((DateTime)dataGrid.Rows[r].Cells[c].Value).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        data[r][c] = dataGrid.Rows[r].Cells[c].Value.ToString();
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

            //Save and Launch
            document.SaveToFile(filename);
            MessageBox.Show("Document Created Successfully!", "Export File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();
        }
#endregion
    }
}
