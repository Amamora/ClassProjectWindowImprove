
namespace WindowClassProject.View.ViewTeacher
{
    partial class AddClassForm
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
            this.classIDTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.teacherIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schoolYearTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentIDTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkStudentInClassBtn = new System.Windows.Forms.Button();
            this.clearClassBtn = new System.Windows.Forms.Button();
            this.removeClassBtn = new System.Windows.Forms.Button();
            this.editClassBtn = new System.Windows.Forms.Button();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.searchClassID = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classIDTxt
            // 
            this.classIDTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classIDTxt.Location = new System.Drawing.Point(31, 110);
            this.classIDTxt.Multiline = true;
            this.classIDTxt.Name = "classIDTxt";
            this.classIDTxt.Size = new System.Drawing.Size(327, 34);
            this.classIDTxt.TabIndex = 5;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(36, 70);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(94, 25);
            this.firstNameLbl.TabIndex = 4;
            this.firstNameLbl.Text = "Class ID";
            // 
            // teacherIDTxt
            // 
            this.teacherIDTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teacherIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIDTxt.Location = new System.Drawing.Point(31, 219);
            this.teacherIDTxt.Multiline = true;
            this.teacherIDTxt.Name = "teacherIDTxt";
            this.teacherIDTxt.Size = new System.Drawing.Size(327, 34);
            this.teacherIDTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teacher ID";
            // 
            // schoolYearTxt
            // 
            this.schoolYearTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.schoolYearTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearTxt.Location = new System.Drawing.Point(31, 320);
            this.schoolYearTxt.Multiline = true;
            this.schoolYearTxt.Name = "schoolYearTxt";
            this.schoolYearTxt.Size = new System.Drawing.Size(327, 34);
            this.schoolYearTxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "School Year";
            // 
            // departmentIDTxt
            // 
            this.departmentIDTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departmentIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentIDTxt.Location = new System.Drawing.Point(31, 427);
            this.departmentIDTxt.Multiline = true;
            this.departmentIDTxt.Name = "departmentIDTxt";
            this.departmentIDTxt.Size = new System.Drawing.Size(327, 34);
            this.departmentIDTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Department ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkStudentInClassBtn);
            this.panel1.Controls.Add(this.clearClassBtn);
            this.panel1.Controls.Add(this.removeClassBtn);
            this.panel1.Controls.Add(this.editClassBtn);
            this.panel1.Controls.Add(this.addClassBtn);
            this.panel1.Location = new System.Drawing.Point(1, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 55);
            this.panel1.TabIndex = 12;
            // 
            // checkStudentInClassBtn
            // 
            this.checkStudentInClassBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkStudentInClassBtn.Image = global::WindowClassProject.Properties.Resources.icons8_show_sidepanel_30px;
            this.checkStudentInClassBtn.Location = new System.Drawing.Point(300, 0);
            this.checkStudentInClassBtn.Name = "checkStudentInClassBtn";
            this.checkStudentInClassBtn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.checkStudentInClassBtn.Size = new System.Drawing.Size(152, 55);
            this.checkStudentInClassBtn.TabIndex = 4;
            this.checkStudentInClassBtn.Text = "Show Student";
            this.checkStudentInClassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkStudentInClassBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkStudentInClassBtn.UseVisualStyleBackColor = true;
            // 
            // clearClassBtn
            // 
            this.clearClassBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearClassBtn.Image = global::WindowClassProject.Properties.Resources.icons8_reset_30px;
            this.clearClassBtn.Location = new System.Drawing.Point(225, 0);
            this.clearClassBtn.Name = "clearClassBtn";
            this.clearClassBtn.Size = new System.Drawing.Size(75, 55);
            this.clearClassBtn.TabIndex = 3;
            this.clearClassBtn.UseVisualStyleBackColor = true;
            // 
            // removeClassBtn
            // 
            this.removeClassBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeClassBtn.Image = global::WindowClassProject.Properties.Resources.icons8_remove_30px;
            this.removeClassBtn.Location = new System.Drawing.Point(150, 0);
            this.removeClassBtn.Name = "removeClassBtn";
            this.removeClassBtn.Size = new System.Drawing.Size(75, 55);
            this.removeClassBtn.TabIndex = 2;
            this.removeClassBtn.UseVisualStyleBackColor = true;
            // 
            // editClassBtn
            // 
            this.editClassBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editClassBtn.Image = global::WindowClassProject.Properties.Resources.icons8_edit_30px;
            this.editClassBtn.Location = new System.Drawing.Point(75, 0);
            this.editClassBtn.Name = "editClassBtn";
            this.editClassBtn.Size = new System.Drawing.Size(75, 55);
            this.editClassBtn.TabIndex = 1;
            this.editClassBtn.UseVisualStyleBackColor = true;
            // 
            // addClassBtn
            // 
            this.addClassBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addClassBtn.Image = global::WindowClassProject.Properties.Resources.icons8_add_30px;
            this.addClassBtn.Location = new System.Drawing.Point(0, 0);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(75, 55);
            this.addClassBtn.TabIndex = 0;
            this.addClassBtn.UseVisualStyleBackColor = true;
            // 
            // searchClassID
            // 
            this.searchClassID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchClassID.Location = new System.Drawing.Point(368, 111);
            this.searchClassID.Name = "searchClassID";
            this.searchClassID.Size = new System.Drawing.Size(75, 34);
            this.searchClassID.TabIndex = 13;
            this.searchClassID.UseVisualStyleBackColor = true;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 602);
            this.Controls.Add(this.searchClassID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.departmentIDTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.schoolYearTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherIDTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classIDTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox classIDTxt;
        public System.Windows.Forms.Label firstNameLbl;
        public System.Windows.Forms.TextBox teacherIDTxt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox schoolYearTxt;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox departmentIDTxt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button checkStudentInClassBtn;
        private System.Windows.Forms.Button clearClassBtn;
        private System.Windows.Forms.Button removeClassBtn;
        private System.Windows.Forms.Button editClassBtn;
        private System.Windows.Forms.Button addClassBtn;
        private System.Windows.Forms.Button searchClassID;
    }
}