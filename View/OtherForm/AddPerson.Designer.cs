
namespace WindowClassProject.View.OtherForm
{
    partial class AddPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPersonPanelForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addPersonPanelForm
            // 
            this.addPersonPanelForm.BackColor = System.Drawing.Color.White;
            this.addPersonPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPersonPanelForm.Location = new System.Drawing.Point(0, 0);
            this.addPersonPanelForm.Name = "addPersonPanelForm";
            this.addPersonPanelForm.Size = new System.Drawing.Size(782, 564);
            this.addPersonPanelForm.TabIndex = 0;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPersonPanelForm);
            this.Name = "AddPerson";
            this.Size = new System.Drawing.Size(782, 564);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPersonPanelForm;
    }
}
