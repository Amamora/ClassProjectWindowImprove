
namespace WindowClassProject.View.ViewScore
{
    partial class AddScorePanelForm
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
            this.selectSearchBox = new System.Windows.Forms.ComboBox();
            this.showScoreDataBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.showStudentDataBtn = new System.Windows.Forms.Button();
            this.dataSubScoreView = new System.Windows.Forms.DataGridView();
            this.selectGroupID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avgByScoreBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editScoreBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubScoreView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectSearchBox);
            this.panel1.Controls.Add(this.showScoreDataBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.showStudentDataBtn);
            this.panel1.Controls.Add(this.dataSubScoreView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 620);
            this.panel1.TabIndex = 22;
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
            this.showScoreDataBtn.Location = new System.Drawing.Point(322, 12);
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
            this.showStudentDataBtn.Location = new System.Drawing.Point(48, 12);
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
            this.dataSubScoreView.AllowUserToDeleteRows = false;
            this.dataSubScoreView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSubScoreView.BackgroundColor = System.Drawing.Color.White;
            this.dataSubScoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubScoreView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataSubScoreView.Location = new System.Drawing.Point(0, 147);
            this.dataSubScoreView.Name = "dataSubScoreView";
            this.dataSubScoreView.RowHeadersWidth = 51;
            this.dataSubScoreView.RowTemplate.Height = 24;
            this.dataSubScoreView.Size = new System.Drawing.Size(599, 473);
            this.dataSubScoreView.TabIndex = 0;
            this.dataSubScoreView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSubScoreView_CellDoubleClick);
            // 
            // selectGroupID
            // 
            this.selectGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGroupID.FormattingEnabled = true;
            this.selectGroupID.Location = new System.Drawing.Point(183, 147);
            this.selectGroupID.Name = "selectGroupID";
            this.selectGroupID.Size = new System.Drawing.Size(389, 37);
            this.selectGroupID.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Select GroupID";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(183, 356);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(390, 100);
            this.descriptionTxt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Evaluate";
            // 
            // scoreTxt
            // 
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(183, 283);
            this.scoreTxt.Multiline = true;
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(390, 43);
            this.scoreTxt.TabIndex = 17;
            this.scoreTxt.TextChanged += new System.EventHandler(this.scoreTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Score";
            // 
            // studentIDtxt
            // 
            this.studentIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDtxt.Location = new System.Drawing.Point(183, 73);
            this.studentIDtxt.Multiline = true;
            this.studentIDtxt.Name = "studentIDtxt";
            this.studentIDtxt.Size = new System.Drawing.Size(390, 33);
            this.studentIDtxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student ID";
            // 
            // avgByScoreBtn
            // 
            this.avgByScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgByScoreBtn.Location = new System.Drawing.Point(377, 572);
            this.avgByScoreBtn.Name = "avgByScoreBtn";
            this.avgByScoreBtn.Size = new System.Drawing.Size(195, 36);
            this.avgByScoreBtn.TabIndex = 26;
            this.avgByScoreBtn.Text = "Average by score";
            this.avgByScoreBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(232, 499);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(123, 41);
            this.removeBtn.TabIndex = 25;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(435, 499);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 42);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(70, 499);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 42);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editScoreBtn
            // 
            this.editScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editScoreBtn.Location = new System.Drawing.Point(70, 572);
            this.editScoreBtn.Name = "editScoreBtn";
            this.editScoreBtn.Size = new System.Drawing.Size(195, 36);
            this.editScoreBtn.TabIndex = 27;
            this.editScoreBtn.Text = "Edit Score";
            this.editScoreBtn.UseVisualStyleBackColor = true;
            this.editScoreBtn.Click += new System.EventHandler(this.editScoreBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 44);
            this.label6.TabIndex = 28;
            this.label6.Text = "Score";
            // 
            // AddScorePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 620);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editScoreBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectGroupID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgByScoreBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.MaximumSize = new System.Drawing.Size(1220, 667);
            this.MinimumSize = new System.Drawing.Size(1220, 667);
            this.Name = "AddScorePanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Score for Student";
            this.Load += new System.EventHandler(this.AddScorePanelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubScoreView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showScoreDataBtn;
        private System.Windows.Forms.Button showStudentDataBtn;
        private System.Windows.Forms.DataGridView dataSubScoreView;
        private System.Windows.Forms.ComboBox selectGroupID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scoreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button avgByScoreBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox selectSearchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editScoreBtn;
        private System.Windows.Forms.Label label6;
    }
}