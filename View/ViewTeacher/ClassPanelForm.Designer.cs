
namespace WindowClassProject.View.ViewTeacher
{
    partial class ClassPanelForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studentOfClassShowBtn = new System.Windows.Forms.Button();
            this.showClassBtn = new System.Windows.Forms.Button();
            this.dataShowGrid = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelChooseOption = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clearClassBtn = new System.Windows.Forms.Button();
            this.removeClassBtn = new System.Windows.Forms.Button();
            this.editClassBtn = new System.Windows.Forms.Button();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.schoolYearTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classIDTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.searchClassID = new System.Windows.Forms.Button();
            this.departmentSelectBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelChooseOption.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 791);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataShowGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(473, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 791);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.studentOfClassShowBtn);
            this.panel3.Controls.Add(this.showClassBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 42);
            this.panel3.TabIndex = 1;
            // 
            // studentOfClassShowBtn
            // 
            this.studentOfClassShowBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.studentOfClassShowBtn.Location = new System.Drawing.Point(430, 0);
            this.studentOfClassShowBtn.Name = "studentOfClassShowBtn";
            this.studentOfClassShowBtn.Size = new System.Drawing.Size(215, 42);
            this.studentOfClassShowBtn.TabIndex = 1;
            this.studentOfClassShowBtn.Text = "Show Student of Class";
            this.studentOfClassShowBtn.UseVisualStyleBackColor = true;
            this.studentOfClassShowBtn.Click += new System.EventHandler(this.studentOfClassShowBtn_Click);
            // 
            // showClassBtn
            // 
            this.showClassBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.showClassBtn.Location = new System.Drawing.Point(0, 0);
            this.showClassBtn.Name = "showClassBtn";
            this.showClassBtn.Size = new System.Drawing.Size(237, 42);
            this.showClassBtn.TabIndex = 0;
            this.showClassBtn.Text = "Show CLass";
            this.showClassBtn.UseVisualStyleBackColor = true;
            this.showClassBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataShowGrid
            // 
            this.dataShowGrid.AllowUserToAddRows = false;
            this.dataShowGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataShowGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataShowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataShowGrid.Location = new System.Drawing.Point(0, 82);
            this.dataShowGrid.Name = "dataShowGrid";
            this.dataShowGrid.RowHeadersWidth = 51;
            this.dataShowGrid.RowTemplate.Height = 24;
            this.dataShowGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataShowGrid.Size = new System.Drawing.Size(645, 709);
            this.dataShowGrid.TabIndex = 0;
            this.dataShowGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataShowGrid_UserDeletedRow);
            this.dataShowGrid.DoubleClick += new System.EventHandler(this.dataShowGrid_DoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelChooseOption);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(473, 791);
            this.panel5.TabIndex = 2;
            // 
            // panelChooseOption
            // 
            this.panelChooseOption.Controls.Add(this.departmentSelectBox);
            this.panelChooseOption.Controls.Add(this.panel4);
            this.panelChooseOption.Controls.Add(this.label3);
            this.panelChooseOption.Controls.Add(this.schoolYearTxt);
            this.panelChooseOption.Controls.Add(this.label2);
            this.panelChooseOption.Controls.Add(this.teacherIDTxt);
            this.panelChooseOption.Controls.Add(this.label1);
            this.panelChooseOption.Controls.Add(this.classIDTxt);
            this.panelChooseOption.Controls.Add(this.firstNameLbl);
            this.panelChooseOption.Controls.Add(this.searchClassID);
            this.panelChooseOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChooseOption.Location = new System.Drawing.Point(0, 142);
            this.panelChooseOption.Name = "panelChooseOption";
            this.panelChooseOption.Size = new System.Drawing.Size(473, 649);
            this.panelChooseOption.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.clearClassBtn);
            this.panel4.Controls.Add(this.removeClassBtn);
            this.panel4.Controls.Add(this.editClassBtn);
            this.panel4.Controls.Add(this.addClassBtn);
            this.panel4.Location = new System.Drawing.Point(10, 538);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(452, 55);
            this.panel4.TabIndex = 22;
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
            this.clearClassBtn.Click += new System.EventHandler(this.clearClassBtn_Click);
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
            this.removeClassBtn.Click += new System.EventHandler(this.removeClassBtn_Click);
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
            this.editClassBtn.Click += new System.EventHandler(this.editClassBtn_Click);
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
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Department ID";
            // 
            // schoolYearTxt
            // 
            this.schoolYearTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.schoolYearTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearTxt.Location = new System.Drawing.Point(40, 306);
            this.schoolYearTxt.Multiline = true;
            this.schoolYearTxt.Name = "schoolYearTxt";
            this.schoolYearTxt.Size = new System.Drawing.Size(327, 34);
            this.schoolYearTxt.TabIndex = 19;
            this.schoolYearTxt.TextChanged += new System.EventHandler(this.schoolYearTxt_TextChanged);
            this.schoolYearTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.schoolYearTxt_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "School Year";
            // 
            // teacherIDTxt
            // 
            this.teacherIDTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teacherIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIDTxt.Location = new System.Drawing.Point(40, 205);
            this.teacherIDTxt.Multiline = true;
            this.teacherIDTxt.Name = "teacherIDTxt";
            this.teacherIDTxt.Size = new System.Drawing.Size(327, 34);
            this.teacherIDTxt.TabIndex = 17;
            this.teacherIDTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teacherIDTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Teacher ID";
            // 
            // classIDTxt
            // 
            this.classIDTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classIDTxt.Location = new System.Drawing.Point(40, 96);
            this.classIDTxt.Multiline = true;
            this.classIDTxt.Name = "classIDTxt";
            this.classIDTxt.Size = new System.Drawing.Size(327, 34);
            this.classIDTxt.TabIndex = 15;
            this.classIDTxt.TextChanged += new System.EventHandler(this.classIDTxt_TextChanged);
            this.classIDTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.classIDTxt_KeyDown);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(45, 56);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(94, 25);
            this.firstNameLbl.TabIndex = 14;
            this.firstNameLbl.Text = "Class ID";
            // 
            // searchClassID
            // 
            this.searchClassID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchClassID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchClassID.Image = global::WindowClassProject.Properties.Resources.icons8_search_32px;
            this.searchClassID.Location = new System.Drawing.Point(377, 95);
            this.searchClassID.Name = "searchClassID";
            this.searchClassID.Size = new System.Drawing.Size(75, 35);
            this.searchClassID.TabIndex = 23;
            this.searchClassID.UseVisualStyleBackColor = true;
            this.searchClassID.Click += new System.EventHandler(this.searchClassID_Click);
            // 
            // departmentSelectBox
            // 
            this.departmentSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentSelectBox.FormattingEnabled = true;
            this.departmentSelectBox.Location = new System.Drawing.Point(40, 435);
            this.departmentSelectBox.Name = "departmentSelectBox";
            this.departmentSelectBox.Size = new System.Drawing.Size(316, 33);
            this.departmentSelectBox.TabIndex = 24;
            this.departmentSelectBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.departmentIDTxt_KeyDown);
            // 
            // ClassPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.panel1);
            this.Name = "ClassPanelForm";
            this.Text = "ClassPanelForm";
            this.Load += new System.EventHandler(this.ClassPanelForm_Load);
            this.Click += new System.EventHandler(this.ClassPanelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataShowGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panelChooseOption.ResumeLayout(false);
            this.panelChooseOption.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button studentOfClassShowBtn;
        private System.Windows.Forms.Button showClassBtn;
        private System.Windows.Forms.DataGridView dataShowGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelChooseOption;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button clearClassBtn;
        private System.Windows.Forms.Button removeClassBtn;
        private System.Windows.Forms.Button editClassBtn;
        private System.Windows.Forms.Button addClassBtn;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox schoolYearTxt;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox teacherIDTxt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox classIDTxt;
        public System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Button searchClassID;
        private System.Windows.Forms.ComboBox departmentSelectBox;
    }
}