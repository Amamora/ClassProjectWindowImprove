
namespace WindowClassProject.View.ViewScore
{
    partial class Score_Form
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
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.liveChartBtn = new System.Windows.Forms.Button();
            this.averageBtn = new System.Windows.Forms.Button();
            this.addScoreBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exportPdfBtn = new System.Windows.Forms.Button();
            this.exportExcelBtn = new System.Windows.Forms.Button();
            this.exportWordBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxSearch);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 100);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Course ID",
            "Group ID",
            "Student ID",
            "Score"});
            this.comboBoxSearch.Location = new System.Drawing.Point(87, 34);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(216, 33);
            this.comboBoxSearch.TabIndex = 18;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(369, 31);
            this.searchBox.MaximumSize = new System.Drawing.Size(263, 38);
            this.searchBox.MaxLength = 500;
            this.searchBox.MinimumSize = new System.Drawing.Size(263, 38);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(263, 38);
            this.searchBox.TabIndex = 17;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(638, 31);
            this.searchButton.MaximumSize = new System.Drawing.Size(111, 38);
            this.searchButton.MinimumSize = new System.Drawing.Size(111, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 38);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.liveChartBtn);
            this.panel2.Controls.Add(this.averageBtn);
            this.panel2.Controls.Add(this.addScoreBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 691);
            this.panel2.TabIndex = 1;
            // 
            // liveChartBtn
            // 
            this.liveChartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.liveChartBtn.Location = new System.Drawing.Point(0, 231);
            this.liveChartBtn.Name = "liveChartBtn";
            this.liveChartBtn.Size = new System.Drawing.Size(200, 102);
            this.liveChartBtn.TabIndex = 4;
            this.liveChartBtn.Text = "Live Chart";
            this.liveChartBtn.UseVisualStyleBackColor = true;
            // 
            // averageBtn
            // 
            this.averageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.averageBtn.Location = new System.Drawing.Point(0, 102);
            this.averageBtn.Name = "averageBtn";
            this.averageBtn.Size = new System.Drawing.Size(200, 129);
            this.averageBtn.TabIndex = 3;
            this.averageBtn.Text = "Average Score Each Group and Course";
            this.averageBtn.UseVisualStyleBackColor = true;
            // 
            // addScoreBtn
            // 
            this.addScoreBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addScoreBtn.Location = new System.Drawing.Point(0, 0);
            this.addScoreBtn.Name = "addScoreBtn";
            this.addScoreBtn.Size = new System.Drawing.Size(200, 102);
            this.addScoreBtn.TabIndex = 0;
            this.addScoreBtn.Text = "Manage Score";
            this.addScoreBtn.UseVisualStyleBackColor = true;
            this.addScoreBtn.Click += new System.EventHandler(this.addScoreBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.exportPdfBtn);
            this.panel3.Controls.Add(this.exportExcelBtn);
            this.panel3.Controls.Add(this.exportWordBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1054, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 691);
            this.panel3.TabIndex = 2;
            // 
            // exportPdfBtn
            // 
            this.exportPdfBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportPdfBtn.Image = global::WindowClassProject.Properties.Resources.icons8_pdf_30px;
            this.exportPdfBtn.Location = new System.Drawing.Point(0, 126);
            this.exportPdfBtn.Name = "exportPdfBtn";
            this.exportPdfBtn.Size = new System.Drawing.Size(64, 63);
            this.exportPdfBtn.TabIndex = 2;
            this.exportPdfBtn.UseVisualStyleBackColor = true;
            // 
            // exportExcelBtn
            // 
            this.exportExcelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportExcelBtn.Image = global::WindowClassProject.Properties.Resources.icons8_file_excel_30px;
            this.exportExcelBtn.Location = new System.Drawing.Point(0, 63);
            this.exportExcelBtn.Name = "exportExcelBtn";
            this.exportExcelBtn.Size = new System.Drawing.Size(64, 63);
            this.exportExcelBtn.TabIndex = 1;
            this.exportExcelBtn.UseVisualStyleBackColor = true;
            // 
            // exportWordBtn
            // 
            this.exportWordBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportWordBtn.Image = global::WindowClassProject.Properties.Resources.icons8_microsoft_word_30px;
            this.exportWordBtn.Location = new System.Drawing.Point(0, 0);
            this.exportWordBtn.Name = "exportWordBtn";
            this.exportWordBtn.Size = new System.Drawing.Size(64, 63);
            this.exportWordBtn.TabIndex = 0;
            this.exportWordBtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataScoreDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 691);
            this.panel4.TabIndex = 3;
            // 
            // dataScoreDataGridView
            // 
            this.dataScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataScoreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataScoreDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataScoreDataGridView.Name = "dataScoreDataGridView";
            this.dataScoreDataGridView.RowHeadersWidth = 51;
            this.dataScoreDataGridView.RowTemplate.Height = 24;
            this.dataScoreDataGridView.Size = new System.Drawing.Size(854, 691);
            this.dataScoreDataGridView.TabIndex = 0;
            // 
            // Score_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Score_Form";
            this.Text = "Score_Form";
            this.Load += new System.EventHandler(this.Score_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataScoreDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataScoreDataGridView;
        private System.Windows.Forms.Button addScoreBtn;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button liveChartBtn;
        private System.Windows.Forms.Button averageBtn;
        private System.Windows.Forms.Button exportPdfBtn;
        private System.Windows.Forms.Button exportExcelBtn;
        private System.Windows.Forms.Button exportWordBtn;
    }
}