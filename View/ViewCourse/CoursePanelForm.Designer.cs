
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursePanelForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.topCoursePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.totalCourseLbl = new System.Windows.Forms.Label();
            this.toolCoursePanel = new System.Windows.Forms.Panel();
            this.fastManageBtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.exportWordFileBtn = new System.Windows.Forms.Button();
            this.exportExcelFileBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.exportPDFBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.dataShowCoursePanel = new System.Windows.Forms.Panel();
            this.dataCourseGrid = new System.Windows.Forms.DataGridView();
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
            this.topCoursePanel.Controls.Add(this.totalCourseLbl);
            this.topCoursePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topCoursePanel.Location = new System.Drawing.Point(0, 0);
            this.topCoursePanel.Name = "topCoursePanel";
            this.topCoursePanel.Size = new System.Drawing.Size(1118, 152);
            this.topCoursePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(505, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 152);
            this.panel1.TabIndex = 1;
            // 
            // searchTxt
            // 
            this.searchTxt.AcceptsReturn = false;
            this.searchTxt.AcceptsTab = false;
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchTxt.AnimationSpeed = 200;
            this.searchTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchTxt.BackColor = System.Drawing.Color.Transparent;
            this.searchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTxt.BackgroundImage")));
            this.searchTxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchTxt.BorderRadius = 40;
            this.searchTxt.BorderThickness = 2;
            this.searchTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.searchTxt.DefaultText = "";
            this.searchTxt.FillColor = System.Drawing.Color.White;
            this.searchTxt.HideSelection = true;
            this.searchTxt.IconLeft = null;
            this.searchTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.IconPadding = 10;
            this.searchTxt.IconRight = global::WindowClassProject.Properties.Resources.icons8_cancel_30px;
            this.searchTxt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.searchTxt.Lines = new string[0];
            this.searchTxt.Location = new System.Drawing.Point(39, 71);
            this.searchTxt.MaxLength = 32767;
            this.searchTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchTxt.Modified = false;
            this.searchTxt.Multiline = false;
            this.searchTxt.Name = "searchTxt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTxt.OnIdleState = stateProperties4;
            this.searchTxt.Padding = new System.Windows.Forms.Padding(3);
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchTxt.PlaceholderText = "Search Course By ID course";
            this.searchTxt.ReadOnly = false;
            this.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTxt.SelectedText = "";
            this.searchTxt.SelectionLength = 0;
            this.searchTxt.SelectionStart = 0;
            this.searchTxt.ShortcutsEnabled = true;
            this.searchTxt.Size = new System.Drawing.Size(457, 60);
            this.searchTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchTxt.TabIndex = 0;
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTxt.TextMarginBottom = 0;
            this.searchTxt.TextMarginLeft = 3;
            this.searchTxt.TextMarginTop = 0;
            this.searchTxt.TextPlaceholder = "Search Course By ID course";
            this.searchTxt.UseSystemPasswordChar = false;
            this.searchTxt.WordWrap = true;
            this.searchTxt.OnIconRightClick += new System.EventHandler(this.bunifuTextBox1_OnIconRightClick);
            // 
            // totalCourseLbl
            // 
            this.totalCourseLbl.AutoSize = true;
            this.totalCourseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCourseLbl.Location = new System.Drawing.Point(21, 52);
            this.totalCourseLbl.Name = "totalCourseLbl";
            this.totalCourseLbl.Size = new System.Drawing.Size(206, 32);
            this.totalCourseLbl.TabIndex = 0;
            this.totalCourseLbl.Text = "Total Course :";
            // 
            // toolCoursePanel
            // 
            this.toolCoursePanel.Controls.Add(this.fastManageBtn);
            this.toolCoursePanel.Controls.Add(this.button8);
            this.toolCoursePanel.Controls.Add(this.exportWordFileBtn);
            this.toolCoursePanel.Controls.Add(this.exportExcelFileBtn);
            this.toolCoursePanel.Controls.Add(this.button5);
            this.toolCoursePanel.Controls.Add(this.exportPDFBtn);
            this.toolCoursePanel.Controls.Add(this.button3);
            this.toolCoursePanel.Controls.Add(this.refreshBtn);
            this.toolCoursePanel.Controls.Add(this.addCourseBtn);
            this.toolCoursePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolCoursePanel.Location = new System.Drawing.Point(0, 152);
            this.toolCoursePanel.Name = "toolCoursePanel";
            this.toolCoursePanel.Size = new System.Drawing.Size(1118, 47);
            this.toolCoursePanel.TabIndex = 1;
            // 
            // fastManageBtn
            // 
            this.fastManageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.fastManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastManageBtn.Location = new System.Drawing.Point(192, 0);
            this.fastManageBtn.Name = "fastManageBtn";
            this.fastManageBtn.Size = new System.Drawing.Size(127, 47);
            this.fastManageBtn.TabIndex = 8;
            this.fastManageBtn.Text = "Fast Manage";
            this.fastManageBtn.UseVisualStyleBackColor = true;
            this.fastManageBtn.Click += new System.EventHandler(this.fastManageBtn_Click);
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
            // exportWordFileBtn
            // 
            this.exportWordFileBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportWordFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportWordFileBtn.Image = global::WindowClassProject.Properties.Resources.icons8_microsoft_word_30px;
            this.exportWordFileBtn.Location = new System.Drawing.Point(862, 0);
            this.exportWordFileBtn.Name = "exportWordFileBtn";
            this.exportWordFileBtn.Size = new System.Drawing.Size(64, 47);
            this.exportWordFileBtn.TabIndex = 6;
            this.exportWordFileBtn.UseVisualStyleBackColor = true;
            this.exportWordFileBtn.Click += new System.EventHandler(this.exportWordFileBtn_Click);
            // 
            // exportExcelFileBtn
            // 
            this.exportExcelFileBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportExcelFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportExcelFileBtn.Image = global::WindowClassProject.Properties.Resources.icons8_file_excel_30px;
            this.exportExcelFileBtn.Location = new System.Drawing.Point(926, 0);
            this.exportExcelFileBtn.Name = "exportExcelFileBtn";
            this.exportExcelFileBtn.Size = new System.Drawing.Size(64, 47);
            this.exportExcelFileBtn.TabIndex = 5;
            this.exportExcelFileBtn.UseVisualStyleBackColor = true;
            this.exportExcelFileBtn.Click += new System.EventHandler(this.exportExcelFileBtn_Click);
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
            this.exportPDFBtn.Click += new System.EventHandler(this.exportPDFBtn_Click);
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
            // refreshBtn
            // 
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Image = global::WindowClassProject.Properties.Resources.icons8_refresh_32px;
            this.refreshBtn.Location = new System.Drawing.Point(64, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(64, 47);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseBtn.Image = global::WindowClassProject.Properties.Resources.icons8_add_30px;
            this.addCourseBtn.Location = new System.Drawing.Point(0, 0);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(64, 47);
            this.addCourseBtn.TabIndex = 0;
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
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
            this.dataCourseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCourseGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataCourseGrid.ColumnHeadersHeight = 28;
            this.dataCourseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCourseGrid.Location = new System.Drawing.Point(0, 0);
            this.dataCourseGrid.Name = "dataCourseGrid";
            this.dataCourseGrid.RowHeadersWidth = 51;
            this.dataCourseGrid.RowTemplate.Height = 24;
            this.dataCourseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCourseGrid.Size = new System.Drawing.Size(1118, 592);
            this.dataCourseGrid.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.CoursePanelForm_Load);
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
        private System.Windows.Forms.Button exportWordFileBtn;
        private System.Windows.Forms.Button exportExcelFileBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button exportPDFBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalCourseLbl;
        private System.Windows.Forms.DataGridView dataCourseGrid;
        private System.Windows.Forms.Button fastManageBtn;
        private Bunifu.UI.WinForms.BunifuTextBox searchTxt;
    }
}