
namespace WindowClassProject.View.ViewCourse
{
    partial class ManageCourseFast
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
            this.listShowCourse = new System.Windows.Forms.ListBox();
            this.panelSLideRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.totalCourseLbl = new System.Windows.Forms.Label();
            this.lastLoadListbox = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.previousLoadListbox = new System.Windows.Forms.Button();
            this.nextLoadListbox = new System.Windows.Forms.Button();
            this.firstLoadListbox = new System.Windows.Forms.Button();
            this.creditShowNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionShowText = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.courseShowText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idShowText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departLbl = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.panelSLideRight.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditShowNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listShowCourse
            // 
            this.listShowCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listShowCourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listShowCourse.FormattingEnabled = true;
            this.listShowCourse.ItemHeight = 24;
            this.listShowCourse.Items.AddRange(new object[] {
            ""});
            this.listShowCourse.Location = new System.Drawing.Point(0, 139);
            this.listShowCourse.Name = "listShowCourse";
            this.listShowCourse.Size = new System.Drawing.Size(495, 508);
            this.listShowCourse.TabIndex = 55;
            this.listShowCourse.SelectedIndexChanged += new System.EventHandler(this.listShowCourse_SelectedIndexChanged);
            // 
            // panelSLideRight
            // 
            this.panelSLideRight.Controls.Add(this.panel2);
            this.panelSLideRight.Controls.Add(this.totalCourseLbl);
            this.panelSLideRight.Controls.Add(this.listShowCourse);
            this.panelSLideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSLideRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSLideRight.Location = new System.Drawing.Point(650, 0);
            this.panelSLideRight.Name = "panelSLideRight";
            this.panelSLideRight.Size = new System.Drawing.Size(495, 647);
            this.panelSLideRight.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 56);
            this.panel2.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(285, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Short";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Detail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalCourseLbl
            // 
            this.totalCourseLbl.AutoSize = true;
            this.totalCourseLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalCourseLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalCourseLbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCourseLbl.Location = new System.Drawing.Point(0, 0);
            this.totalCourseLbl.Name = "totalCourseLbl";
            this.totalCourseLbl.Size = new System.Drawing.Size(141, 29);
            this.totalCourseLbl.TabIndex = 1;
            this.totalCourseLbl.Text = "Total Course:";
            // 
            // lastLoadListbox
            // 
            this.lastLoadListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastLoadListbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLoadListbox.Location = new System.Drawing.Point(495, 503);
            this.lastLoadListbox.Name = "lastLoadListbox";
            this.lastLoadListbox.Size = new System.Drawing.Size(122, 35);
            this.lastLoadListbox.TabIndex = 30;
            this.lastLoadListbox.Text = "Last";
            this.lastLoadListbox.UseVisualStyleBackColor = true;
            this.lastLoadListbox.Click += new System.EventHandler(this.lastLoadListbox_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(495, 572);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(122, 35);
            this.removeBtn.TabIndex = 29;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(335, 572);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(122, 35);
            this.editBtn.TabIndex = 28;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.Location = new System.Drawing.Point(168, 572);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(122, 35);
            this.addCourseBtn.TabIndex = 27;
            this.addCourseBtn.Text = "Add";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // previousLoadListbox
            // 
            this.previousLoadListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousLoadListbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousLoadListbox.Location = new System.Drawing.Point(321, 503);
            this.previousLoadListbox.Name = "previousLoadListbox";
            this.previousLoadListbox.Size = new System.Drawing.Size(136, 33);
            this.previousLoadListbox.TabIndex = 26;
            this.previousLoadListbox.Text = "Previous";
            this.previousLoadListbox.UseVisualStyleBackColor = true;
            this.previousLoadListbox.Click += new System.EventHandler(this.previousLoadListbox_Click);
            // 
            // nextLoadListbox
            // 
            this.nextLoadListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextLoadListbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLoadListbox.Location = new System.Drawing.Point(168, 501);
            this.nextLoadListbox.Name = "nextLoadListbox";
            this.nextLoadListbox.Size = new System.Drawing.Size(120, 33);
            this.nextLoadListbox.TabIndex = 25;
            this.nextLoadListbox.Text = "Next";
            this.nextLoadListbox.UseVisualStyleBackColor = true;
            this.nextLoadListbox.Click += new System.EventHandler(this.nextLoadListbox_Click);
            // 
            // firstLoadListbox
            // 
            this.firstLoadListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstLoadListbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLoadListbox.Location = new System.Drawing.Point(21, 500);
            this.firstLoadListbox.Name = "firstLoadListbox";
            this.firstLoadListbox.Size = new System.Drawing.Size(126, 34);
            this.firstLoadListbox.TabIndex = 24;
            this.firstLoadListbox.Text = "First";
            this.firstLoadListbox.UseVisualStyleBackColor = true;
            this.firstLoadListbox.Click += new System.EventHandler(this.firstLoadListbox_Click);
            // 
            // creditShowNumeric
            // 
            this.creditShowNumeric.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditShowNumeric.Location = new System.Drawing.Point(180, 221);
            this.creditShowNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.creditShowNumeric.Name = "creditShowNumeric";
            this.creditShowNumeric.Size = new System.Drawing.Size(374, 32);
            this.creditShowNumeric.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Credit";
            // 
            // descriptionShowText
            // 
            this.descriptionShowText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionShowText.Location = new System.Drawing.Point(174, 354);
            this.descriptionShowText.Multiline = true;
            this.descriptionShowText.Name = "descriptionShowText";
            this.descriptionShowText.Size = new System.Drawing.Size(377, 108);
            this.descriptionShowText.TabIndex = 21;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(12, 354);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(128, 29);
            this.descriptionLbl.TabIndex = 20;
            this.descriptionLbl.Text = "Description";
            this.descriptionLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // courseShowText
            // 
            this.courseShowText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseShowText.Location = new System.Drawing.Point(177, 162);
            this.courseShowText.Multiline = true;
            this.courseShowText.Name = "courseShowText";
            this.courseShowText.Size = new System.Drawing.Size(377, 42);
            this.courseShowText.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Course Name";
            // 
            // idShowText
            // 
            this.idShowText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idShowText.Location = new System.Drawing.Point(177, 88);
            this.idShowText.Multiline = true;
            this.idShowText.Name = "idShowText";
            this.idShowText.Size = new System.Drawing.Size(377, 45);
            this.idShowText.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Course";
            // 
            // departLbl
            // 
            this.departLbl.AutoSize = true;
            this.departLbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departLbl.Location = new System.Drawing.Point(12, 278);
            this.departLbl.Name = "departLbl";
            this.departLbl.Size = new System.Drawing.Size(135, 29);
            this.departLbl.TabIndex = 32;
            this.departLbl.Text = "Department";
            // 
            // departmentBox
            // 
            this.departmentBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentBox.DropDownHeight = 110;
            this.departmentBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.IntegralHeight = false;
            this.departmentBox.Location = new System.Drawing.Point(177, 279);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(380, 32);
            this.departmentBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 37);
            this.label5.TabIndex = 34;
            this.label5.Text = "Choose Course ";
            // 
            // newBtn
            // 
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(25, 572);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(122, 35);
            this.newBtn.TabIndex = 35;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // ManageCourseFast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 647);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.departLbl);
            this.Controls.Add(this.panelSLideRight);
            this.Controls.Add(this.lastLoadListbox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.previousLoadListbox);
            this.Controls.Add(this.nextLoadListbox);
            this.Controls.Add(this.firstLoadListbox);
            this.Controls.Add(this.creditShowNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionShowText);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.courseShowText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idShowText);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1300, 694);
            this.MinimumSize = new System.Drawing.Size(1163, 694);
            this.Name = "ManageCourseFast";
            this.Text = "ManageCourseFast";
            this.Load += new System.EventHandler(this.ManageCourseFast_Load);
            this.panelSLideRight.ResumeLayout(false);
            this.panelSLideRight.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditShowNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listShowCourse;
        private System.Windows.Forms.Panel panelSLideRight;
        private System.Windows.Forms.Label totalCourseLbl;
        private System.Windows.Forms.Button lastLoadListbox;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button previousLoadListbox;
        private System.Windows.Forms.Button nextLoadListbox;
        private System.Windows.Forms.Button firstLoadListbox;
        private System.Windows.Forms.NumericUpDown creditShowNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionShowText;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox courseShowText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idShowText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label departLbl;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newBtn;
    }
}