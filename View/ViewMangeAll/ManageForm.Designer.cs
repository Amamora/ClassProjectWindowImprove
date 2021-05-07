
namespace WindowClassProject.View.ViewManageStudent
{
    partial class ManageForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.openMailBoxPanel = new System.Windows.Forms.Button();
            this.openTimeTablePanel = new System.Windows.Forms.Button();
            this.openChartPanel = new System.Windows.Forms.Button();
            this.openManagePanel = new System.Windows.Forms.Panel();
            this.openDepartmentBtn = new System.Windows.Forms.Button();
            this.openClassPanelBtn = new System.Windows.Forms.Button();
            this.openScorePanelChild = new System.Windows.Forms.Button();
            this.openTeacherPanelChild = new System.Windows.Forms.Button();
            this.openCoursePanelChild = new System.Windows.Forms.Button();
            this.openStudentPanelChild = new System.Windows.Forms.Button();
            this.openManageBtn = new System.Windows.Forms.Button();
            this.openDashBtn = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.topTool1 = new WindowClassProject.View.OtherForm.topTool();
            this.menuPanel.SuspendLayout();
            this.openManagePanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.exitBtn);
            this.menuPanel.Controls.Add(this.openMailBoxPanel);
            this.menuPanel.Controls.Add(this.openTimeTablePanel);
            this.menuPanel.Controls.Add(this.openChartPanel);
            this.menuPanel.Controls.Add(this.openManagePanel);
            this.menuPanel.Controls.Add(this.openManageBtn);
            this.menuPanel.Controls.Add(this.openDashBtn);
            this.menuPanel.Controls.Add(this.userPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPanel.Size = new System.Drawing.Size(246, 887);
            this.menuPanel.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = global::WindowClassProject.Properties.Resources.shutdown;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(0, 799);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(246, 70);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // openMailBoxPanel
            // 
            this.openMailBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openMailBoxPanel.FlatAppearance.BorderSize = 0;
            this.openMailBoxPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMailBoxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMailBoxPanel.ForeColor = System.Drawing.Color.Silver;
            this.openMailBoxPanel.Image = global::WindowClassProject.Properties.Resources.icons8_mail_30px;
            this.openMailBoxPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openMailBoxPanel.Location = new System.Drawing.Point(0, 729);
            this.openMailBoxPanel.Name = "openMailBoxPanel";
            this.openMailBoxPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openMailBoxPanel.Size = new System.Drawing.Size(246, 70);
            this.openMailBoxPanel.TabIndex = 6;
            this.openMailBoxPanel.Text = "Mail Box";
            this.openMailBoxPanel.UseVisualStyleBackColor = true;
            this.openMailBoxPanel.Click += new System.EventHandler(this.openMailBoxPanel_Click);
            // 
            // openTimeTablePanel
            // 
            this.openTimeTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openTimeTablePanel.FlatAppearance.BorderSize = 0;
            this.openTimeTablePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTimeTablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTimeTablePanel.ForeColor = System.Drawing.Color.Silver;
            this.openTimeTablePanel.Image = global::WindowClassProject.Properties.Resources.icons8_timetable_32px;
            this.openTimeTablePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openTimeTablePanel.Location = new System.Drawing.Point(0, 659);
            this.openTimeTablePanel.Name = "openTimeTablePanel";
            this.openTimeTablePanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openTimeTablePanel.Size = new System.Drawing.Size(246, 70);
            this.openTimeTablePanel.TabIndex = 5;
            this.openTimeTablePanel.Text = "Time Table";
            this.openTimeTablePanel.UseVisualStyleBackColor = true;
            this.openTimeTablePanel.Click += new System.EventHandler(this.openTimeTablePanel_Click);
            // 
            // openChartPanel
            // 
            this.openChartPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openChartPanel.FlatAppearance.BorderSize = 0;
            this.openChartPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openChartPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openChartPanel.ForeColor = System.Drawing.Color.Silver;
            this.openChartPanel.Image = global::WindowClassProject.Properties.Resources.icons8_chart_30px;
            this.openChartPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openChartPanel.Location = new System.Drawing.Point(0, 589);
            this.openChartPanel.Name = "openChartPanel";
            this.openChartPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openChartPanel.Size = new System.Drawing.Size(246, 70);
            this.openChartPanel.TabIndex = 4;
            this.openChartPanel.Text = "Chart";
            this.openChartPanel.UseVisualStyleBackColor = true;
            this.openChartPanel.Click += new System.EventHandler(this.openChartPanel_Click);
            // 
            // openManagePanel
            // 
            this.openManagePanel.Controls.Add(this.openDepartmentBtn);
            this.openManagePanel.Controls.Add(this.openClassPanelBtn);
            this.openManagePanel.Controls.Add(this.openScorePanelChild);
            this.openManagePanel.Controls.Add(this.openTeacherPanelChild);
            this.openManagePanel.Controls.Add(this.openCoursePanelChild);
            this.openManagePanel.Controls.Add(this.openStudentPanelChild);
            this.openManagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openManagePanel.Location = new System.Drawing.Point(0, 240);
            this.openManagePanel.Name = "openManagePanel";
            this.openManagePanel.Size = new System.Drawing.Size(246, 349);
            this.openManagePanel.TabIndex = 3;
            // 
            // openDepartmentBtn
            // 
            this.openDepartmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.openDepartmentBtn.FlatAppearance.BorderSize = 0;
            this.openDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDepartmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDepartmentBtn.ForeColor = System.Drawing.Color.Silver;
            this.openDepartmentBtn.Image = global::WindowClassProject.Properties.Resources.icons8_department_32px;
            this.openDepartmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openDepartmentBtn.Location = new System.Drawing.Point(0, 270);
            this.openDepartmentBtn.Name = "openDepartmentBtn";
            this.openDepartmentBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.openDepartmentBtn.Size = new System.Drawing.Size(246, 54);
            this.openDepartmentBtn.TabIndex = 5;
            this.openDepartmentBtn.Text = "Department";
            this.openDepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // openClassPanelBtn
            // 
            this.openClassPanelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.openClassPanelBtn.FlatAppearance.BorderSize = 0;
            this.openClassPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openClassPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openClassPanelBtn.ForeColor = System.Drawing.Color.Silver;
            this.openClassPanelBtn.Image = global::WindowClassProject.Properties.Resources.icons8_class_32px;
            this.openClassPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openClassPanelBtn.Location = new System.Drawing.Point(0, 216);
            this.openClassPanelBtn.Name = "openClassPanelBtn";
            this.openClassPanelBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.openClassPanelBtn.Size = new System.Drawing.Size(246, 54);
            this.openClassPanelBtn.TabIndex = 4;
            this.openClassPanelBtn.Text = "Class";
            this.openClassPanelBtn.UseVisualStyleBackColor = true;
            // 
            // openScorePanelChild
            // 
            this.openScorePanelChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.openScorePanelChild.FlatAppearance.BorderSize = 0;
            this.openScorePanelChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openScorePanelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openScorePanelChild.ForeColor = System.Drawing.Color.Silver;
            this.openScorePanelChild.Image = global::WindowClassProject.Properties.Resources.icons8_average_30px;
            this.openScorePanelChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openScorePanelChild.Location = new System.Drawing.Point(0, 162);
            this.openScorePanelChild.Name = "openScorePanelChild";
            this.openScorePanelChild.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.openScorePanelChild.Size = new System.Drawing.Size(246, 54);
            this.openScorePanelChild.TabIndex = 3;
            this.openScorePanelChild.Text = "Score";
            this.openScorePanelChild.UseVisualStyleBackColor = true;
            // 
            // openTeacherPanelChild
            // 
            this.openTeacherPanelChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.openTeacherPanelChild.FlatAppearance.BorderSize = 0;
            this.openTeacherPanelChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTeacherPanelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTeacherPanelChild.ForeColor = System.Drawing.Color.Silver;
            this.openTeacherPanelChild.Image = global::WindowClassProject.Properties.Resources.icons8_teacher_22px;
            this.openTeacherPanelChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openTeacherPanelChild.Location = new System.Drawing.Point(0, 108);
            this.openTeacherPanelChild.Name = "openTeacherPanelChild";
            this.openTeacherPanelChild.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.openTeacherPanelChild.Size = new System.Drawing.Size(246, 54);
            this.openTeacherPanelChild.TabIndex = 2;
            this.openTeacherPanelChild.Text = "Teacher";
            this.openTeacherPanelChild.UseVisualStyleBackColor = true;
            // 
            // openCoursePanelChild
            // 
            this.openCoursePanelChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.openCoursePanelChild.FlatAppearance.BorderSize = 0;
            this.openCoursePanelChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCoursePanelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCoursePanelChild.ForeColor = System.Drawing.Color.Silver;
            this.openCoursePanelChild.Image = global::WindowClassProject.Properties.Resources.icons8_course_22px;
            this.openCoursePanelChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openCoursePanelChild.Location = new System.Drawing.Point(0, 54);
            this.openCoursePanelChild.Name = "openCoursePanelChild";
            this.openCoursePanelChild.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.openCoursePanelChild.Size = new System.Drawing.Size(246, 54);
            this.openCoursePanelChild.TabIndex = 1;
            this.openCoursePanelChild.Text = "Course";
            this.openCoursePanelChild.UseVisualStyleBackColor = true;
            this.openCoursePanelChild.Click += new System.EventHandler(this.openCoursePanelChild_Click);
            // 
            // openStudentPanelChild
            // 
            this.openStudentPanelChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.openStudentPanelChild.FlatAppearance.BorderSize = 0;
            this.openStudentPanelChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openStudentPanelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStudentPanelChild.ForeColor = System.Drawing.Color.Silver;
            this.openStudentPanelChild.Image = global::WindowClassProject.Properties.Resources.icons8_student_male_20px;
            this.openStudentPanelChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openStudentPanelChild.Location = new System.Drawing.Point(0, 0);
            this.openStudentPanelChild.Name = "openStudentPanelChild";
            this.openStudentPanelChild.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.openStudentPanelChild.Size = new System.Drawing.Size(246, 54);
            this.openStudentPanelChild.TabIndex = 0;
            this.openStudentPanelChild.Text = "Student";
            this.openStudentPanelChild.UseVisualStyleBackColor = true;
            // 
            // openManageBtn
            // 
            this.openManageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.openManageBtn.FlatAppearance.BorderSize = 0;
            this.openManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openManageBtn.ForeColor = System.Drawing.Color.Silver;
            this.openManageBtn.Image = global::WindowClassProject.Properties.Resources.icons8_management_30px;
            this.openManageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openManageBtn.Location = new System.Drawing.Point(0, 170);
            this.openManageBtn.Name = "openManageBtn";
            this.openManageBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openManageBtn.Size = new System.Drawing.Size(246, 70);
            this.openManageBtn.TabIndex = 2;
            this.openManageBtn.Text = "Manage";
            this.openManageBtn.UseVisualStyleBackColor = true;
            this.openManageBtn.Click += new System.EventHandler(this.openManageBtn_Click);
            // 
            // openDashBtn
            // 
            this.openDashBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.openDashBtn.FlatAppearance.BorderSize = 0;
            this.openDashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDashBtn.ForeColor = System.Drawing.Color.Silver;
            this.openDashBtn.Image = global::WindowClassProject.Properties.Resources.icons8_home_30px;
            this.openDashBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openDashBtn.Location = new System.Drawing.Point(0, 100);
            this.openDashBtn.Name = "openDashBtn";
            this.openDashBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openDashBtn.Size = new System.Drawing.Size(246, 70);
            this.openDashBtn.TabIndex = 1;
            this.openDashBtn.Text = "Dash Board";
            this.openDashBtn.UseVisualStyleBackColor = true;
            this.openDashBtn.Click += new System.EventHandler(this.openDashBtn_Click);
            this.openDashBtn.MouseCaptureChanged += new System.EventHandler(this.openDashBtn_MouseCaptureChanged);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.label1);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(246, 100);
            this.userPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(246, 53);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1136, 834);
            this.panelChildForm.TabIndex = 2;
            // 
            // topTool1
            // 
            this.topTool1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTool1.Location = new System.Drawing.Point(246, 0);
            this.topTool1.Name = "topTool1";
            this.topTool1.Size = new System.Drawing.Size(1136, 50);
            this.topTool1.TabIndex = 3;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 887);
            this.Controls.Add(this.topTool1);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(1400, 934);
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.openManagePanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
      
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button openTimeTablePanel;
        private System.Windows.Forms.Button openChartPanel;
        private System.Windows.Forms.Panel openManagePanel;
        private System.Windows.Forms.Button openScorePanelChild;
        private System.Windows.Forms.Button openTeacherPanelChild;
        private System.Windows.Forms.Button openCoursePanelChild;
        private System.Windows.Forms.Button openStudentPanelChild;
        private System.Windows.Forms.Button openManageBtn;
        private System.Windows.Forms.Button openDashBtn;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button openMailBoxPanel;
        private System.Windows.Forms.Button exitBtn;
        private OtherForm.topTool topTool1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openDepartmentBtn;
        private System.Windows.Forms.Button openClassPanelBtn;
    }
}