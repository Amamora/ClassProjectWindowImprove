
namespace WindowClassProject.View.ViewStudent
{
    partial class StudentPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanelForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.addStudentJoinGroupBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.dataStudentGridView = new System.Windows.Forms.DataGridView();
            this.totalStudentLbl = new System.Windows.Forms.Label();
            this.searchButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.searchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.importFileExcelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.workButton = new System.Windows.Forms.Button();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.importDatabaseBtn = new System.Windows.Forms.Button();
            this.exportPDFButton = new System.Windows.Forms.Button();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.addStudentJoinGroupBtn);
            this.toolPanel.Controls.Add(this.removeBtn);
            this.toolPanel.Controls.Add(this.importFileExcelButton);
            this.toolPanel.Controls.Add(this.saveButton);
            this.toolPanel.Controls.Add(this.workButton);
            this.toolPanel.Controls.Add(this.exportExcelButton);
            this.toolPanel.Controls.Add(this.refreshBtn);
            this.toolPanel.Controls.Add(this.btnAddStudent);
            this.toolPanel.Controls.Add(this.importDatabaseBtn);
            this.toolPanel.Controls.Add(this.exportPDFButton);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolPanel.Location = new System.Drawing.Point(0, 126);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(1118, 57);
            this.toolPanel.TabIndex = 16;
            // 
            // addStudentJoinGroupBtn
            // 
            this.addStudentJoinGroupBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addStudentJoinGroupBtn.Location = new System.Drawing.Point(341, 0);
            this.addStudentJoinGroupBtn.Name = "addStudentJoinGroupBtn";
            this.addStudentJoinGroupBtn.Size = new System.Drawing.Size(183, 57);
            this.addStudentJoinGroupBtn.TabIndex = 8;
            this.addStudentJoinGroupBtn.Text = "Add Student Join Group";
            this.addStudentJoinGroupBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Location = new System.Drawing.Point(266, 0);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 57);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // dataStudentGridView
            // 
            this.dataStudentGridView.AllowUserToAddRows = false;
            this.dataStudentGridView.AllowUserToOrderColumns = true;
            this.dataStudentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStudentGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataStudentGridView.ColumnHeadersHeight = 29;
            this.dataStudentGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataStudentGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataStudentGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataStudentGridView.Location = new System.Drawing.Point(0, 183);
            this.dataStudentGridView.Name = "dataStudentGridView";
            this.dataStudentGridView.RowHeadersWidth = 51;
            this.dataStudentGridView.RowTemplate.Height = 24;
            this.dataStudentGridView.Size = new System.Drawing.Size(1118, 608);
            this.dataStudentGridView.TabIndex = 13;
            this.dataStudentGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudentGridView_CellDoubleClick);
            // 
            // totalStudentLbl
            // 
            this.totalStudentLbl.AutoSize = true;
            this.totalStudentLbl.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStudentLbl.Location = new System.Drawing.Point(662, 61);
            this.totalStudentLbl.Name = "totalStudentLbl";
            this.totalStudentLbl.Size = new System.Drawing.Size(109, 32);
            this.totalStudentLbl.TabIndex = 17;
            this.totalStudentLbl.Text = "Total Student:";
            this.totalStudentLbl.Click += new System.EventHandler(this.totalStudentLbl_Click);
            // 
            // searchButton
            // 
            this.searchButton.AllowAnimations = true;
            this.searchButton.AllowMouseEffects = true;
            this.searchButton.AllowToggling = false;
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.AnimationSpeed = 200;
            this.searchButton.AutoGenerateColors = false;
            this.searchButton.AutoRoundBorders = false;
            this.searchButton.AutoSizeLeftIcon = true;
            this.searchButton.AutoSizeRightIcon = true;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.ButtonText = "Search";
            this.searchButton.ButtonTextMarginLeft = 0;
            this.searchButton.ColorContrastOnClick = 45;
            this.searchButton.ColorContrastOnHover = 45;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.searchButton.CustomizableEdges = borderEdges1;
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.searchButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.searchButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.searchButton.IconMarginLeft = 11;
            this.searchButton.IconPadding = 10;
            this.searchButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.searchButton.IconSize = 25;
            this.searchButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.IdleBorderRadius = 40;
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.IdleIconLeftImage = null;
            this.searchButton.IdleIconRightImage = null;
            this.searchButton.IndicateFocus = false;
            this.searchButton.Location = new System.Drawing.Point(445, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.searchButton.OnDisabledState.BorderRadius = 40;
            this.searchButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.OnDisabledState.BorderThickness = 1;
            this.searchButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.searchButton.OnDisabledState.IconLeftImage = null;
            this.searchButton.OnDisabledState.IconRightImage = null;
            this.searchButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchButton.onHoverState.BorderRadius = 40;
            this.searchButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.onHoverState.BorderThickness = 1;
            this.searchButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.searchButton.onHoverState.IconLeftImage = null;
            this.searchButton.onHoverState.IconRightImage = null;
            this.searchButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.OnIdleState.BorderRadius = 40;
            this.searchButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.OnIdleState.BorderThickness = 1;
            this.searchButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.searchButton.OnIdleState.IconLeftImage = null;
            this.searchButton.OnIdleState.IconRightImage = null;
            this.searchButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.searchButton.OnPressedState.BorderRadius = 40;
            this.searchButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.OnPressedState.BorderThickness = 1;
            this.searchButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.searchButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.searchButton.OnPressedState.IconLeftImage = null;
            this.searchButton.OnPressedState.IconRightImage = null;
            this.searchButton.Size = new System.Drawing.Size(137, 59);
            this.searchButton.TabIndex = 19;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchButton.TextMarginLeft = 0;
            this.searchButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.searchButton.UseDefaultRadiusAndThickness = true;
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = false;
            this.searchBox.AcceptsTab = false;
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchBox.AnimationSpeed = 200;
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBox.BackgroundImage")));
            this.searchBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchBox.BorderRadius = 1;
            this.searchBox.BorderThickness = 1;
            this.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.searchBox.DefaultText = "";
            this.searchBox.FillColor = System.Drawing.Color.White;
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.HideSelection = true;
            this.searchBox.IconLeft = null;
            this.searchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.IconPadding = 10;
            this.searchBox.IconRight = null;
            this.searchBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(22, 50);
            this.searchBox.MaxLength = 32767;
            this.searchBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBox.Modified = false;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            stateProperties1.BorderColor = System.Drawing.Color.Gray;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Black;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnIdleState = stateProperties4;
            this.searchBox.Padding = new System.Windows.Forms.Padding(3);
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBox.PlaceholderText = "Search by Student ID......";
            this.searchBox.ReadOnly = false;
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(417, 59);
            this.searchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchBox.TabIndex = 18;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TextMarginBottom = 0;
            this.searchBox.TextMarginLeft = 3;
            this.searchBox.TextMarginTop = 0;
            this.searchBox.TextPlaceholder = "Search by Student ID......";
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.WordWrap = true;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // importFileExcelButton
            // 
            this.importFileExcelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.importFileExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFileExcelButton.Image = global::WindowClassProject.Properties.Resources.icons8_csv_30px;
            this.importFileExcelButton.Location = new System.Drawing.Point(202, 0);
            this.importFileExcelButton.Name = "importFileExcelButton";
            this.importFileExcelButton.Size = new System.Drawing.Size(64, 57);
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
            this.saveButton.Size = new System.Drawing.Size(63, 57);
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
            this.workButton.Size = new System.Drawing.Size(63, 57);
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
            this.exportExcelButton.Size = new System.Drawing.Size(63, 57);
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
            this.refreshBtn.Size = new System.Drawing.Size(80, 57);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Image = global::WindowClassProject.Properties.Resources.icons8_add_20px;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(122, 57);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Add Student";
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
            this.importDatabaseBtn.Size = new System.Drawing.Size(63, 57);
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
            this.exportPDFButton.Size = new System.Drawing.Size(63, 57);
            this.exportPDFButton.TabIndex = 0;
            this.exportPDFButton.UseVisualStyleBackColor = true;
            this.exportPDFButton.Click += new System.EventHandler(this.exportPDFButton_Click);
            // 
            // StudentPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.dataStudentGridView);
            this.Controls.Add(this.totalStudentLbl);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "StudentPanelForm";
            this.Text = "StudentPanelForm";
            this.Load += new System.EventHandler(this.StudentPanelForm_Load);
            this.toolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button importFileExcelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Button exportExcelButton;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button importDatabaseBtn;
        private System.Windows.Forms.Button exportPDFButton;
        private System.Windows.Forms.DataGridView dataStudentGridView;
        private System.Windows.Forms.Label totalStudentLbl;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addStudentJoinGroupBtn;
        private Bunifu.UI.WinForms.BunifuTextBox searchBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton searchButton;
    }
}