
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
            this.openManagePanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.topTool1 = new WindowClassProject.View.OtherForm.topTool();
            this.openMailBoxPanel = new System.Windows.Forms.Button();
            this.openTimeTablePanel = new System.Windows.Forms.Button();
            this.openChartPanel = new System.Windows.Forms.Button();
            this.openScorePanelChild = new System.Windows.Forms.Button();
            this.openTeacherPanelChild = new System.Windows.Forms.Button();
            this.openCoursePanelChild = new System.Windows.Forms.Button();
            this.openStudentPanelChild = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.openManagePanel.SuspendLayout();
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
            this.menuPanel.Controls.Add(this.button2);
            this.menuPanel.Controls.Add(this.button1);
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
            this.exitBtn.Location = new System.Drawing.Point(0, 681);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(246, 70);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // openManagePanel
            // 
            this.openManagePanel.Controls.Add(this.openScorePanelChild);
            this.openManagePanel.Controls.Add(this.openTeacherPanelChild);
            this.openManagePanel.Controls.Add(this.openCoursePanelChild);
            this.openManagePanel.Controls.Add(this.openStudentPanelChild);
            this.openManagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openManagePanel.Location = new System.Drawing.Point(0, 240);
            this.openManagePanel.Name = "openManagePanel";
            this.openManagePanel.Size = new System.Drawing.Size(246, 231);
            this.openManagePanel.TabIndex = 3;
            // 
            // userPanel
            // 
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(246, 100);
            this.userPanel.TabIndex = 0;
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
            // openMailBoxPanel
            // 
            this.openMailBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openMailBoxPanel.FlatAppearance.BorderSize = 0;
            this.openMailBoxPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMailBoxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMailBoxPanel.ForeColor = System.Drawing.Color.White;
            this.openMailBoxPanel.Image = global::WindowClassProject.Properties.Resources.icons8_mail_30px;
            this.openMailBoxPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openMailBoxPanel.Location = new System.Drawing.Point(0, 611);
            this.openMailBoxPanel.Name = "openMailBoxPanel";
            this.openMailBoxPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openMailBoxPanel.Size = new System.Drawing.Size(246, 70);
            this.openMailBoxPanel.TabIndex = 6;
            this.openMailBoxPanel.Text = "Mail Box";
            this.openMailBoxPanel.UseVisualStyleBackColor = true;
            // 
            // openTimeTablePanel
            // 
            this.openTimeTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openTimeTablePanel.FlatAppearance.BorderSize = 0;
            this.openTimeTablePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTimeTablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTimeTablePanel.ForeColor = System.Drawing.Color.White;
            this.openTimeTablePanel.Image = global::WindowClassProject.Properties.Resources.icons8_timetable_32px;
            this.openTimeTablePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openTimeTablePanel.Location = new System.Drawing.Point(0, 541);
            this.openTimeTablePanel.Name = "openTimeTablePanel";
            this.openTimeTablePanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openTimeTablePanel.Size = new System.Drawing.Size(246, 70);
            this.openTimeTablePanel.TabIndex = 5;
            this.openTimeTablePanel.Text = "Time Table";
            this.openTimeTablePanel.UseVisualStyleBackColor = true;
            // 
            // openChartPanel
            // 
            this.openChartPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openChartPanel.FlatAppearance.BorderSize = 0;
            this.openChartPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openChartPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openChartPanel.ForeColor = System.Drawing.Color.White;
            this.openChartPanel.Image = global::WindowClassProject.Properties.Resources.icons8_chart_30px;
            this.openChartPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openChartPanel.Location = new System.Drawing.Point(0, 471);
            this.openChartPanel.Name = "openChartPanel";
            this.openChartPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openChartPanel.Size = new System.Drawing.Size(246, 70);
            this.openChartPanel.TabIndex = 4;
            this.openChartPanel.Text = "Chart";
            this.openChartPanel.UseVisualStyleBackColor = true;
            // 
            // openScorePanelChild
            // 
            this.openScorePanelChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.openScorePanelChild.FlatAppearance.BorderSize = 0;
            this.openScorePanelChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openScorePanelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openScorePanelChild.ForeColor = System.Drawing.Color.White;
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
            this.openTeacherPanelChild.ForeColor = System.Drawing.Color.White;
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
            this.openCoursePanelChild.ForeColor = System.Drawing.Color.White;
            this.openCoursePanelChild.Image = global::WindowClassProject.Properties.Resources.icons8_course_22px;
            this.openCoursePanelChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openCoursePanelChild.Location = new System.Drawing.Point(0, 54);
            this.openCoursePanelChild.Name = "openCoursePanelChild";
            this.openCoursePanelChild.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.openCoursePanelChild.Size = new System.Drawing.Size(246, 54);
            this.openCoursePanelChild.TabIndex = 1;
            this.openCoursePanelChild.Text = "Course";
            this.openCoursePanelChild.UseVisualStyleBackColor = true;
            // 
            // openStudentPanelChild
            // 
            this.openStudentPanelChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.openStudentPanelChild.FlatAppearance.BorderSize = 0;
            this.openStudentPanelChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openStudentPanelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStudentPanelChild.ForeColor = System.Drawing.Color.White;
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
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowClassProject.Properties.Resources.icons8_management_30px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 170);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(246, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manage";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowClassProject.Properties.Resources.icons8_home_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(246, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dash Board";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.openManagePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button openMailBoxPanel;
        private System.Windows.Forms.Button exitBtn;
        private OtherForm.topTool topTool1;
    }
}