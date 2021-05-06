
namespace WindowClassProject.View.ViewCourse
{
    partial class AddCoursePanelForm
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
            this.resertBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.creditTxt = new System.Windows.Forms.TextBox();
            this.periodLbl = new System.Windows.Forms.Label();
            this.courseNameTxt = new System.Windows.Forms.TextBox();
            this.labelCourseLbl = new System.Windows.Forms.Label();
            this.idCourseTxt = new System.Windows.Forms.TextBox();
            this.idCourseLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentCombox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // resertBtn
            // 
            this.resertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resertBtn.Location = new System.Drawing.Point(505, 563);
            this.resertBtn.Name = "resertBtn";
            this.resertBtn.Size = new System.Drawing.Size(189, 45);
            this.resertBtn.TabIndex = 21;
            this.resertBtn.Text = "Resert";
            this.resertBtn.UseVisualStyleBackColor = true;
            this.resertBtn.Click += new System.EventHandler(this.resertBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(274, 563);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(189, 45);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.Location = new System.Drawing.Point(58, 563);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(160, 46);
            this.addCourseBtn.TabIndex = 19;
            this.addCourseBtn.Text = "Add";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(85, 461);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(466, 76);
            this.descriptionTxt.TabIndex = 18;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(84, 424);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(120, 25);
            this.descriptionLbl.TabIndex = 17;
            this.descriptionLbl.Text = "Description";
            this.descriptionLbl.Click += new System.EventHandler(this.descriptionLbl_Click);
            // 
            // creditTxt
            // 
            this.creditTxt.Location = new System.Drawing.Point(85, 269);
            this.creditTxt.Multiline = true;
            this.creditTxt.Name = "creditTxt";
            this.creditTxt.Size = new System.Drawing.Size(466, 42);
            this.creditTxt.TabIndex = 16;
            // 
            // periodLbl
            // 
            this.periodLbl.AutoSize = true;
            this.periodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodLbl.Location = new System.Drawing.Point(84, 224);
            this.periodLbl.Name = "periodLbl";
            this.periodLbl.Size = new System.Drawing.Size(70, 25);
            this.periodLbl.TabIndex = 15;
            this.periodLbl.Text = "Credit";
            // 
            // courseNameTxt
            // 
            this.courseNameTxt.Location = new System.Drawing.Point(85, 170);
            this.courseNameTxt.Multiline = true;
            this.courseNameTxt.Name = "courseNameTxt";
            this.courseNameTxt.Size = new System.Drawing.Size(466, 42);
            this.courseNameTxt.TabIndex = 14;
            // 
            // labelCourseLbl
            // 
            this.labelCourseLbl.AutoSize = true;
            this.labelCourseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseLbl.Location = new System.Drawing.Point(84, 125);
            this.labelCourseLbl.Name = "labelCourseLbl";
            this.labelCourseLbl.Size = new System.Drawing.Size(144, 25);
            this.labelCourseLbl.TabIndex = 13;
            this.labelCourseLbl.Text = "Course Name";
            // 
            // idCourseTxt
            // 
            this.idCourseTxt.Location = new System.Drawing.Point(85, 65);
            this.idCourseTxt.Multiline = true;
            this.idCourseTxt.Name = "idCourseTxt";
            this.idCourseTxt.Size = new System.Drawing.Size(466, 42);
            this.idCourseTxt.TabIndex = 12;
            // 
            // idCourseLbl
            // 
            this.idCourseLbl.AutoSize = true;
            this.idCourseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCourseLbl.Location = new System.Drawing.Point(84, 20);
            this.idCourseLbl.Name = "idCourseLbl";
            this.idCourseLbl.Size = new System.Drawing.Size(109, 25);
            this.idCourseLbl.TabIndex = 11;
            this.idCourseLbl.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Department";
            // 
            // departmentCombox
            // 
            this.departmentCombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentCombox.FormattingEnabled = true;
            this.departmentCombox.Location = new System.Drawing.Point(89, 363);
            this.departmentCombox.Name = "departmentCombox";
            this.departmentCombox.Size = new System.Drawing.Size(469, 33);
            this.departmentCombox.TabIndex = 23;
            // 
            // AddCoursePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 621);
            this.Controls.Add(this.departmentCombox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resertBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.creditTxt);
            this.Controls.Add(this.periodLbl);
            this.Controls.Add(this.courseNameTxt);
            this.Controls.Add(this.labelCourseLbl);
            this.Controls.Add(this.idCourseTxt);
            this.Controls.Add(this.idCourseLbl);
            this.Name = "AddCoursePanelForm";
            this.Text = "AddCoursePanelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resertBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox creditTxt;
        private System.Windows.Forms.Label periodLbl;
        private System.Windows.Forms.TextBox courseNameTxt;
        private System.Windows.Forms.Label labelCourseLbl;
        private System.Windows.Forms.TextBox idCourseTxt;
        private System.Windows.Forms.Label idCourseLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentCombox;
    }
}