
namespace WindowClassProject.View.ViewTeacher
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titlePaneTeacher = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalTeacherLbl = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.importFileExcelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.workButton = new System.Windows.Forms.Button();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.importDatabaseBtn = new System.Windows.Forms.Button();
            this.exportPDFButton = new System.Windows.Forms.Button();
            this.dataTeacherGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.titlePaneTeacher.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacherGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePaneTeacher
            // 
            this.titlePaneTeacher.BackColor = System.Drawing.Color.White;
            this.titlePaneTeacher.Controls.Add(this.panel2);
            this.titlePaneTeacher.Controls.Add(this.searchBox);
            this.titlePaneTeacher.Controls.Add(this.searchButton);
            this.titlePaneTeacher.Controls.Add(this.panel1);
            this.titlePaneTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePaneTeacher.Location = new System.Drawing.Point(0, 0);
            this.titlePaneTeacher.Name = "titlePaneTeacher";
            this.titlePaneTeacher.Size = new System.Drawing.Size(1118, 113);
            this.titlePaneTeacher.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalTeacherLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(866, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 113);
            this.panel2.TabIndex = 18;
            // 
            // totalTeacherLbl
            // 
            this.totalTeacherLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTeacherLbl.AutoSize = true;
            this.totalTeacherLbl.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTeacherLbl.Location = new System.Drawing.Point(17, 39);
            this.totalTeacherLbl.Name = "totalTeacherLbl";
            this.totalTeacherLbl.Size = new System.Drawing.Size(110, 32);
            this.totalTeacherLbl.TabIndex = 18;
            this.totalTeacherLbl.Text = "Total Teacher:";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(369, 37);
            this.searchBox.MaximumSize = new System.Drawing.Size(263, 38);
            this.searchBox.MaxLength = 500;
            this.searchBox.MinimumSize = new System.Drawing.Size(263, 38);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(263, 38);
            this.searchBox.TabIndex = 17;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged_1);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(638, 37);
            this.searchButton.MaximumSize = new System.Drawing.Size(111, 38);
            this.searchButton.MinimumSize = new System.Drawing.Size(111, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 38);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 113);
            this.panel1.TabIndex = 2;
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.White;
            this.toolPanel.Controls.Add(this.removeBtn);
            this.toolPanel.Controls.Add(this.importFileExcelButton);
            this.toolPanel.Controls.Add(this.saveButton);
            this.toolPanel.Controls.Add(this.workButton);
            this.toolPanel.Controls.Add(this.exportExcelButton);
            this.toolPanel.Controls.Add(this.refreshBtn);
            this.toolPanel.Controls.Add(this.btnAddStudent);
            this.toolPanel.Controls.Add(this.importDatabaseBtn);
            this.toolPanel.Controls.Add(this.exportPDFButton);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolPanel.Location = new System.Drawing.Point(0, 113);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(1118, 47);
            this.toolPanel.TabIndex = 17;
            // 
            // removeBtn
            // 
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Location = new System.Drawing.Point(266, 0);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 47);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // importFileExcelButton
            // 
            this.importFileExcelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.importFileExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFileExcelButton.Location = new System.Drawing.Point(202, 0);
            this.importFileExcelButton.Name = "importFileExcelButton";
            this.importFileExcelButton.Size = new System.Drawing.Size(64, 47);
            this.importFileExcelButton.TabIndex = 5;
            this.importFileExcelButton.Text = "Save Edit";
            this.importFileExcelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Image = global::WindowClassProject.Properties.Resources.icons8_printer_30px;
            this.saveButton.Location = new System.Drawing.Point(803, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 47);
            this.saveButton.TabIndex = 4;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // workButton
            // 
            this.workButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.workButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workButton.Image = global::WindowClassProject.Properties.Resources.icons8_microsoft_word_30px;
            this.workButton.Location = new System.Drawing.Point(866, 0);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(63, 47);
            this.workButton.TabIndex = 3;
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // exportExcelButton
            // 
            this.exportExcelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportExcelButton.Image = global::WindowClassProject.Properties.Resources.icons8_file_excel_30px;
            this.exportExcelButton.Location = new System.Drawing.Point(929, 0);
            this.exportExcelButton.Name = "exportExcelButton";
            this.exportExcelButton.Size = new System.Drawing.Size(63, 47);
            this.exportExcelButton.TabIndex = 2;
            this.exportExcelButton.UseVisualStyleBackColor = true;
            this.exportExcelButton.Click += new System.EventHandler(this.exportExcelButton_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Image = global::WindowClassProject.Properties.Resources.icons8_refresh_32px;
            this.refreshBtn.Location = new System.Drawing.Point(122, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(80, 47);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click_1);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Image = global::WindowClassProject.Properties.Resources.icons8_add_20px;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(122, 47);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Teacher";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // importDatabaseBtn
            // 
            this.importDatabaseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.importDatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importDatabaseBtn.Image = global::WindowClassProject.Properties.Resources.icons8_database_view_30px;
            this.importDatabaseBtn.Location = new System.Drawing.Point(992, 0);
            this.importDatabaseBtn.Name = "importDatabaseBtn";
            this.importDatabaseBtn.Size = new System.Drawing.Size(63, 47);
            this.importDatabaseBtn.TabIndex = 1;
            this.importDatabaseBtn.UseVisualStyleBackColor = true;
            // 
            // exportPDFButton
            // 
            this.exportPDFButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportPDFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportPDFButton.Image = global::WindowClassProject.Properties.Resources.icons8_pdf_30px;
            this.exportPDFButton.Location = new System.Drawing.Point(1055, 0);
            this.exportPDFButton.Name = "exportPDFButton";
            this.exportPDFButton.Size = new System.Drawing.Size(63, 47);
            this.exportPDFButton.TabIndex = 2;
            this.exportPDFButton.UseVisualStyleBackColor = true;
            this.exportPDFButton.Click += new System.EventHandler(this.exportPDFButton_Click);
            // 
            // dataTeacherGridView
            // 
            this.dataTeacherGridView.AllowUserToAddRows = false;
            this.dataTeacherGridView.AllowUserToOrderColumns = true;
            this.dataTeacherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTeacherGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataTeacherGridView.ColumnHeadersHeight = 29;
            this.dataTeacherGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataTeacherGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTeacherGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataTeacherGridView.Location = new System.Drawing.Point(0, 160);
            this.dataTeacherGridView.Name = "dataTeacherGridView";
            this.dataTeacherGridView.RowHeadersWidth = 51;
            this.dataTeacherGridView.RowTemplate.Height = 24;
            this.dataTeacherGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTeacherGridView.Size = new System.Drawing.Size(1118, 631);
            this.dataTeacherGridView.TabIndex = 19;
            this.dataTeacherGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTeacherGridView_CellDoubleClick);
            this.dataTeacherGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataTeacherGridView_UserDeletedRow);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Seach by ID avoid Error";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.dataTeacherGridView);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.titlePaneTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.titlePaneTeacher.ResumeLayout(false);
            this.titlePaneTeacher.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacherGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePaneTeacher;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button importFileExcelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Button exportExcelButton;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button importDatabaseBtn;
        private System.Windows.Forms.Button exportPDFButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataTeacherGridView;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalTeacherLbl;
    }
}