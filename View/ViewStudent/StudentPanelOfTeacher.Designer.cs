
namespace WindowClassProject.View.ViewStudent
{
    partial class StudentPanelOfTeacher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.importFileExcelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.workButton = new System.Windows.Forms.Button();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.importDatabaseBtn = new System.Windows.Forms.Button();
            this.exportPDFButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 147);
            this.panel1.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(671, 33);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(223, 38);
            this.searchBox.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(900, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 38);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "StudentID",
            "StudentName",
            "Gender",
            "ClassID"});
            this.comboBox1.Location = new System.Drawing.Point(398, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 47);
            this.panel2.TabIndex = 2;
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.importFileExcelButton);
            this.toolPanel.Controls.Add(this.saveButton);
            this.toolPanel.Controls.Add(this.workButton);
            this.toolPanel.Controls.Add(this.exportExcelButton);
            this.toolPanel.Controls.Add(this.refreshBtn);
            this.toolPanel.Controls.Add(this.btnAddStudent);
            this.toolPanel.Controls.Add(this.importDatabaseBtn);
            this.toolPanel.Controls.Add(this.exportPDFButton);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(1118, 47);
            this.toolPanel.TabIndex = 17;
            // 
            // importFileExcelButton
            // 
            this.importFileExcelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.importFileExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFileExcelButton.Image = global::WindowClassProject.Properties.Resources.icons8_csv_30px;
            this.importFileExcelButton.Location = new System.Drawing.Point(202, 0);
            this.importFileExcelButton.Name = "importFileExcelButton";
            this.importFileExcelButton.Size = new System.Drawing.Size(64, 47);
            this.importFileExcelButton.TabIndex = 5;
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
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudent.UseVisualStyleBackColor = true;
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
            this.exportPDFButton.TabIndex = 0;
            this.exportPDFButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 597);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 597);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 522);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1118, 75);
            this.panel4.TabIndex = 1;
            // 
            // StudentPanelOfTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentPanelOfTeacher";
            this.Text = "StudentPanelOfTeacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button importFileExcelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Button exportExcelButton;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button importDatabaseBtn;
        private System.Windows.Forms.Button exportPDFButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel4;
    }
}