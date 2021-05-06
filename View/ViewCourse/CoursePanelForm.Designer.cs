
namespace WindowClassProject.View.ViewCourse
{
    partial class CoursePanelForm
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
            this.topCoursePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolCoursePanel = new System.Windows.Forms.Panel();
            this.dataShowCoursePanel = new System.Windows.Forms.Panel();
            this.dataCourseGrid = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.exportPDFBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.importExcelBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.topCoursePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolCoursePanel.SuspendLayout();
            this.dataShowCoursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCourseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // topCoursePanel
            // 
            this.topCoursePanel.Controls.Add(this.panel1);
            this.topCoursePanel.Controls.Add(this.label1);
            this.topCoursePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topCoursePanel.Location = new System.Drawing.Point(0, 0);
            this.topCoursePanel.Name = "topCoursePanel";
            this.topCoursePanel.Size = new System.Drawing.Size(1118, 152);
            this.topCoursePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(505, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 152);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(486, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(27, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 48);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Course :";
            // 
            // toolCoursePanel
            // 
            this.toolCoursePanel.Controls.Add(this.button8);
            this.toolCoursePanel.Controls.Add(this.button7);
            this.toolCoursePanel.Controls.Add(this.button6);
            this.toolCoursePanel.Controls.Add(this.button5);
            this.toolCoursePanel.Controls.Add(this.exportPDFBtn);
            this.toolCoursePanel.Controls.Add(this.button3);
            this.toolCoursePanel.Controls.Add(this.importExcelBtn);
            this.toolCoursePanel.Controls.Add(this.refreshBtn);
            this.toolCoursePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolCoursePanel.Location = new System.Drawing.Point(0, 152);
            this.toolCoursePanel.Name = "toolCoursePanel";
            this.toolCoursePanel.Size = new System.Drawing.Size(1118, 47);
            this.toolCoursePanel.TabIndex = 1;
            // 
            // dataShowCoursePanel
            // 
            this.dataShowCoursePanel.Controls.Add(this.dataCourseGrid);
            this.dataShowCoursePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataShowCoursePanel.Location = new System.Drawing.Point(0, 199);
            this.dataShowCoursePanel.Name = "dataShowCoursePanel";
            this.dataShowCoursePanel.Size = new System.Drawing.Size(1118, 592);
            this.dataShowCoursePanel.TabIndex = 2;
            // 
            // dataCourseGrid
            // 
            this.dataCourseGrid.AllowUserToAddRows = false;
            this.dataCourseGrid.AllowUserToDeleteRows = false;
            this.dataCourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCourseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCourseGrid.Location = new System.Drawing.Point(0, 0);
            this.dataCourseGrid.Name = "dataCourseGrid";
            this.dataCourseGrid.RowHeadersWidth = 51;
            this.dataCourseGrid.RowTemplate.Height = 24;
            this.dataCourseGrid.Size = new System.Drawing.Size(1118, 592);
            this.dataCourseGrid.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::WindowClassProject.Properties.Resources.icons8_printer_30px;
            this.button8.Location = new System.Drawing.Point(798, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 47);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::WindowClassProject.Properties.Resources.icons8_microsoft_word_30px;
            this.button7.Location = new System.Drawing.Point(862, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 47);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::WindowClassProject.Properties.Resources.icons8_file_excel_30px;
            this.button6.Location = new System.Drawing.Point(926, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 47);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::WindowClassProject.Properties.Resources.icons8_database_view_30px;
            this.button5.Location = new System.Drawing.Point(990, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 47);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // exportPDFBtn
            // 
            this.exportPDFBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportPDFBtn.Image = global::WindowClassProject.Properties.Resources.icons8_pdf_30px;
            this.exportPDFBtn.Location = new System.Drawing.Point(1054, 0);
            this.exportPDFBtn.Name = "exportPDFBtn";
            this.exportPDFBtn.Size = new System.Drawing.Size(64, 47);
            this.exportPDFBtn.TabIndex = 3;
            this.exportPDFBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::WindowClassProject.Properties.Resources.icons8_csv_30px;
            this.button3.Location = new System.Drawing.Point(128, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 47);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // importExcelBtn
            // 
            this.importExcelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.importExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importExcelBtn.Image = global::WindowClassProject.Properties.Resources.icons8_refresh_32px;
            this.importExcelBtn.Location = new System.Drawing.Point(64, 0);
            this.importExcelBtn.Name = "importExcelBtn";
            this.importExcelBtn.Size = new System.Drawing.Size(64, 47);
            this.importExcelBtn.TabIndex = 1;
            this.importExcelBtn.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Image = global::WindowClassProject.Properties.Resources.icons8_add_30px;
            this.refreshBtn.Location = new System.Drawing.Point(0, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(64, 47);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // CoursePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.dataShowCoursePanel);
            this.Controls.Add(this.toolCoursePanel);
            this.Controls.Add(this.topCoursePanel);
            this.Name = "CoursePanelForm";
            this.Text = "CoursePanelForm";
            this.topCoursePanel.ResumeLayout(false);
            this.topCoursePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolCoursePanel.ResumeLayout(false);
            this.dataShowCoursePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCourseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topCoursePanel;
        private System.Windows.Forms.Panel toolCoursePanel;
        private System.Windows.Forms.Panel dataShowCoursePanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button exportPDFBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button importExcelBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataCourseGrid;
    }
}