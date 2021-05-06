
namespace WindowClassProject.View.ViewStudent
{
    partial class AddStudentPanelForm
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
            this.addPerson1 = new WindowClassProject.View.OtherForm.AddPerson();
            this.studentExtra1 = new WindowClassProject.View.OtherForm.studentExtra();
            this.SuspendLayout();
            // 
            // addPerson1
            // 
            this.addPerson1.BackColor = System.Drawing.Color.White;
            this.addPerson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPerson1.Location = new System.Drawing.Point(0, 0);
            this.addPerson1.Name = "addPerson1";
            this.addPerson1.Size = new System.Drawing.Size(1118, 791);
            this.addPerson1.TabIndex = 0;
            // 
            // studentExtra1
            // 
            this.studentExtra1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentExtra1.Location = new System.Drawing.Point(0, 685);
            this.studentExtra1.Name = "studentExtra1";
            this.studentExtra1.Size = new System.Drawing.Size(1118, 106);
            this.studentExtra1.TabIndex = 1;
            // 
            // AddStudentPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.studentExtra1);
            this.Controls.Add(this.addPerson1);
            this.Name = "AddStudentPanelForm";
            this.Text = "AddStudentPanelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private OtherForm.AddPerson addPerson1;
        private OtherForm.studentExtra studentExtra1;
    }
}