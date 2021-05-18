
namespace WindowClassProject.View.ViewManageOfStudent
{
    partial class StudentManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManageForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkAllStudentBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.chooseGroupLbl = new System.Windows.Forms.Label();
            this.listGroupIDCheck = new System.Windows.Forms.ComboBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.logoutLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureAccountBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addStudentGroupBtn = new System.Windows.Forms.Button();
            this.selectGroupIDAddCom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editScoreBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.selectSearchBox = new System.Windows.Forms.ComboBox();
            this.showScoreDataBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.showStudentDataBtn = new System.Windows.Forms.Button();
            this.dataSubScoreView = new System.Windows.Forms.DataGridView();
            this.selectGroupID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.scoreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIDtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avgByScoreBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccountBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubScoreView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 352);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkAllStudentBtn);
            this.panel2.Controls.Add(this.chooseGroupLbl);
            this.panel2.Controls.Add(this.listGroupIDCheck);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 211);
            this.panel2.TabIndex = 1;
            // 
            // checkAllStudentBtn
            // 
            this.checkAllStudentBtn.AllowAnimations = true;
            this.checkAllStudentBtn.AllowMouseEffects = true;
            this.checkAllStudentBtn.AllowToggling = false;
            this.checkAllStudentBtn.AnimationSpeed = 200;
            this.checkAllStudentBtn.AutoGenerateColors = false;
            this.checkAllStudentBtn.AutoRoundBorders = false;
            this.checkAllStudentBtn.AutoSizeLeftIcon = true;
            this.checkAllStudentBtn.AutoSizeRightIcon = true;
            this.checkAllStudentBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkAllStudentBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.checkAllStudentBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkAllStudentBtn.BackgroundImage")));
            this.checkAllStudentBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.checkAllStudentBtn.ButtonText = "Check All Student ";
            this.checkAllStudentBtn.ButtonTextMarginLeft = 0;
            this.checkAllStudentBtn.ColorContrastOnClick = 45;
            this.checkAllStudentBtn.ColorContrastOnHover = 45;
            this.checkAllStudentBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.checkAllStudentBtn.CustomizableEdges = borderEdges1;
            this.checkAllStudentBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkAllStudentBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.checkAllStudentBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.checkAllStudentBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.checkAllStudentBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.checkAllStudentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkAllStudentBtn.ForeColor = System.Drawing.Color.White;
            this.checkAllStudentBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkAllStudentBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.checkAllStudentBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.checkAllStudentBtn.IconMarginLeft = 11;
            this.checkAllStudentBtn.IconPadding = 10;
            this.checkAllStudentBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkAllStudentBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.checkAllStudentBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.checkAllStudentBtn.IconSize = 25;
            this.checkAllStudentBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.checkAllStudentBtn.IdleBorderRadius = 1;
            this.checkAllStudentBtn.IdleBorderThickness = 1;
            this.checkAllStudentBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.checkAllStudentBtn.IdleIconLeftImage = null;
            this.checkAllStudentBtn.IdleIconRightImage = null;
            this.checkAllStudentBtn.IndicateFocus = false;
            this.checkAllStudentBtn.Location = new System.Drawing.Point(65, 133);
            this.checkAllStudentBtn.Name = "checkAllStudentBtn";
            this.checkAllStudentBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.checkAllStudentBtn.OnDisabledState.BorderRadius = 1;
            this.checkAllStudentBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.checkAllStudentBtn.OnDisabledState.BorderThickness = 1;
            this.checkAllStudentBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.checkAllStudentBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.checkAllStudentBtn.OnDisabledState.IconLeftImage = null;
            this.checkAllStudentBtn.OnDisabledState.IconRightImage = null;
            this.checkAllStudentBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkAllStudentBtn.onHoverState.BorderRadius = 1;
            this.checkAllStudentBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.checkAllStudentBtn.onHoverState.BorderThickness = 1;
            this.checkAllStudentBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkAllStudentBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.checkAllStudentBtn.onHoverState.IconLeftImage = null;
            this.checkAllStudentBtn.onHoverState.IconRightImage = null;
            this.checkAllStudentBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkAllStudentBtn.OnIdleState.BorderRadius = 1;
            this.checkAllStudentBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.checkAllStudentBtn.OnIdleState.BorderThickness = 1;
            this.checkAllStudentBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.checkAllStudentBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.checkAllStudentBtn.OnIdleState.IconLeftImage = null;
            this.checkAllStudentBtn.OnIdleState.IconRightImage = null;
            this.checkAllStudentBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.checkAllStudentBtn.OnPressedState.BorderRadius = 1;
            this.checkAllStudentBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.checkAllStudentBtn.OnPressedState.BorderThickness = 1;
            this.checkAllStudentBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.checkAllStudentBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.checkAllStudentBtn.OnPressedState.IconLeftImage = null;
            this.checkAllStudentBtn.OnPressedState.IconRightImage = null;
            this.checkAllStudentBtn.Size = new System.Drawing.Size(273, 42);
            this.checkAllStudentBtn.TabIndex = 2;
            this.checkAllStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAllStudentBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkAllStudentBtn.TextMarginLeft = 0;
            this.checkAllStudentBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.checkAllStudentBtn.UseDefaultRadiusAndThickness = true;
            this.checkAllStudentBtn.Click += new System.EventHandler(this.checkAllStudentBtn_Click);
            // 
            // chooseGroupLbl
            // 
            this.chooseGroupLbl.AutoSize = true;
            this.chooseGroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseGroupLbl.Location = new System.Drawing.Point(420, 45);
            this.chooseGroupLbl.Name = "chooseGroupLbl";
            this.chooseGroupLbl.Size = new System.Drawing.Size(164, 25);
            this.chooseGroupLbl.TabIndex = 1;
            this.chooseGroupLbl.Text = "Choose Group ID";
            // 
            // listGroupIDCheck
            // 
            this.listGroupIDCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGroupIDCheck.FormattingEnabled = true;
            this.listGroupIDCheck.Location = new System.Drawing.Point(65, 42);
            this.listGroupIDCheck.Name = "listGroupIDCheck";
            this.listGroupIDCheck.Size = new System.Drawing.Size(332, 33);
            this.listGroupIDCheck.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.logoutLbl);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.pictureAccountBox);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(613, 145);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLbl.Location = new System.Drawing.Point(442, 87);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(121, 36);
            this.logoutLbl.TabIndex = 2;
            this.logoutLbl.Text = "Log Out";
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Profile";
            // 
            // pictureAccountBox
            // 
            this.pictureAccountBox.AllowFocused = false;
            this.pictureAccountBox.AutoSizeHeight = false;
            this.pictureAccountBox.BorderRadius = 72;
            this.pictureAccountBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureAccountBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureAccountBox.Image")));
            this.pictureAccountBox.IsCircle = true;
            this.pictureAccountBox.Location = new System.Drawing.Point(0, 0);
            this.pictureAccountBox.Name = "pictureAccountBox";
            this.pictureAccountBox.Size = new System.Drawing.Size(160, 145);
            this.pictureAccountBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAccountBox.TabIndex = 0;
            this.pictureAccountBox.TabStop = false;
            this.pictureAccountBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addStudentGroupBtn);
            this.panel3.Controls.Add(this.selectGroupIDAddCom);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(613, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 220);
            this.panel3.TabIndex = 1;
            // 
            // addStudentGroupBtn
            // 
            this.addStudentGroupBtn.Location = new System.Drawing.Point(298, 145);
            this.addStudentGroupBtn.Name = "addStudentGroupBtn";
            this.addStudentGroupBtn.Size = new System.Drawing.Size(271, 42);
            this.addStudentGroupBtn.TabIndex = 40;
            this.addStudentGroupBtn.Text = "Add Student ";
            this.addStudentGroupBtn.UseVisualStyleBackColor = true;
            this.addStudentGroupBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectGroupIDAddCom
            // 
            this.selectGroupIDAddCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGroupIDAddCom.FormattingEnabled = true;
            this.selectGroupIDAddCom.Location = new System.Drawing.Point(298, 85);
            this.selectGroupIDAddCom.Name = "selectGroupIDAddCom";
            this.selectGroupIDAddCom.Size = new System.Drawing.Size(389, 37);
            this.selectGroupIDAddCom.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Select GroupID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(297, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 33);
            this.textBox1.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Student ID";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.editScoreBtn);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.selectGroupID);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.descriptionTxt);
            this.panel4.Controls.Add(this.scoreTxt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.studentIDtxt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.avgByScoreBtn);
            this.panel4.Controls.Add(this.removeBtn);
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1382, 522);
            this.panel4.TabIndex = 2;
            // 
            // editScoreBtn
            // 
            this.editScoreBtn.Location = new System.Drawing.Point(426, 448);
            this.editScoreBtn.Name = "editScoreBtn";
            this.editScoreBtn.Size = new System.Drawing.Size(159, 50);
            this.editScoreBtn.TabIndex = 41;
            this.editScoreBtn.Text = "Edit Score";
            this.editScoreBtn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.selectSearchBox);
            this.panel5.Controls.Add(this.showScoreDataBtn);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.showStudentDataBtn);
            this.panel5.Controls.Add(this.dataSubScoreView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(689, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(691, 520);
            this.panel5.TabIndex = 36;
            // 
            // selectSearchBox
            // 
            this.selectSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSearchBox.FormattingEnabled = true;
            this.selectSearchBox.Location = new System.Drawing.Point(189, 85);
            this.selectSearchBox.Name = "selectSearchBox";
            this.selectSearchBox.Size = new System.Drawing.Size(389, 37);
            this.selectSearchBox.TabIndex = 28;
            // 
            // showScoreDataBtn
            // 
            this.showScoreDataBtn.Location = new System.Drawing.Point(353, 18);
            this.showScoreDataBtn.Name = "showScoreDataBtn";
            this.showScoreDataBtn.Size = new System.Drawing.Size(225, 50);
            this.showScoreDataBtn.TabIndex = 2;
            this.showScoreDataBtn.Text = "Show Score";
            this.showScoreDataBtn.UseVisualStyleBackColor = true;
            this.showScoreDataBtn.Click += new System.EventHandler(this.showScoreDataBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Select GroupID";
            // 
            // showStudentDataBtn
            // 
            this.showStudentDataBtn.Location = new System.Drawing.Point(71, 18);
            this.showStudentDataBtn.Name = "showStudentDataBtn";
            this.showStudentDataBtn.Size = new System.Drawing.Size(219, 50);
            this.showStudentDataBtn.TabIndex = 1;
            this.showStudentDataBtn.Text = "ShowStudent";
            this.showStudentDataBtn.UseVisualStyleBackColor = true;
            this.showStudentDataBtn.Click += new System.EventHandler(this.showStudentDataBtn_Click);
            // 
            // dataSubScoreView
            // 
            this.dataSubScoreView.AllowUserToAddRows = false;
            this.dataSubScoreView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSubScoreView.BackgroundColor = System.Drawing.Color.White;
            this.dataSubScoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubScoreView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataSubScoreView.Location = new System.Drawing.Point(0, 141);
            this.dataSubScoreView.Name = "dataSubScoreView";
            this.dataSubScoreView.RowHeadersWidth = 51;
            this.dataSubScoreView.RowTemplate.Height = 24;
            this.dataSubScoreView.Size = new System.Drawing.Size(687, 375);
            this.dataSubScoreView.TabIndex = 0;
            // 
            // selectGroupID
            // 
            this.selectGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGroupID.FormattingEnabled = true;
            this.selectGroupID.Location = new System.Drawing.Point(202, 96);
            this.selectGroupID.Name = "selectGroupID";
            this.selectGroupID.Size = new System.Drawing.Size(389, 37);
            this.selectGroupID.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Select GroupID";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(202, 305);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(390, 100);
            this.descriptionTxt.TabIndex = 33;
            // 
            // scoreTxt
            // 
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(202, 232);
            this.scoreTxt.Multiline = true;
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(390, 43);
            this.scoreTxt.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Score";
            // 
            // studentIDtxt
            // 
            this.studentIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDtxt.Location = new System.Drawing.Point(202, 22);
            this.studentIDtxt.Multiline = true;
            this.studentIDtxt.Name = "studentIDtxt";
            this.studentIDtxt.Size = new System.Drawing.Size(390, 33);
            this.studentIDtxt.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Student ID";
            // 
            // avgByScoreBtn
            // 
            this.avgByScoreBtn.Location = new System.Drawing.Point(396, 521);
            this.avgByScoreBtn.Name = "avgByScoreBtn";
            this.avgByScoreBtn.Size = new System.Drawing.Size(195, 36);
            this.avgByScoreBtn.TabIndex = 40;
            this.avgByScoreBtn.Text = "Average by score";
            this.avgByScoreBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(257, 448);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(123, 50);
            this.removeBtn.TabIndex = 39;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(98, 448);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 50);
            this.addBtn.TabIndex = 37;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Evaluate";
            // 
            // StudentManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 887);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1400, 934);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 934);
            this.Name = "StudentManageForm";
            this.Text = "StudentManageForm";
            this.Load += new System.EventHandler(this.StudentManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccountBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubScoreView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox listGroupIDCheck;
        private System.Windows.Forms.Label logoutLbl;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureAccountBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton checkAllStudentBtn;
        private System.Windows.Forms.Label chooseGroupLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addStudentGroupBtn;
        private System.Windows.Forms.ComboBox selectGroupIDAddCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button editScoreBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox selectSearchBox;
        private System.Windows.Forms.Button showScoreDataBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showStudentDataBtn;
        private System.Windows.Forms.DataGridView dataSubScoreView;
        private System.Windows.Forms.ComboBox selectGroupID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox scoreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIDtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button avgByScoreBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label6;
    }
}