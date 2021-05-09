
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
            this.dataShowGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modeClassRadio = new System.Windows.Forms.RadioButton();
            this.modeGroupRadio = new System.Windows.Forms.RadioButton();
            this.panelChooseOption = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelChooseOption);
            this.panel1.Controls.Add(this.modeGroupRadio);
            this.panel1.Controls.Add(this.modeClassRadio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 791);
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
            this.panel2.TabIndex = 1;
            // 
            // dataShowGrid
            // 
            this.dataShowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataShowGrid.Location = new System.Drawing.Point(0, 82);
            this.dataShowGrid.Name = "dataShowGrid";
            this.dataShowGrid.RowHeadersWidth = 51;
            this.dataShowGrid.RowTemplate.Height = 24;
            this.dataShowGrid.Size = new System.Drawing.Size(645, 709);
            this.dataShowGrid.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 42);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show CLass";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(430, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Group Subject";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // modeClassRadio
            // 
            this.modeClassRadio.AutoSize = true;
            this.modeClassRadio.Checked = true;
            this.modeClassRadio.Location = new System.Drawing.Point(48, 43);
            this.modeClassRadio.Name = "modeClassRadio";
            this.modeClassRadio.Size = new System.Drawing.Size(106, 21);
            this.modeClassRadio.TabIndex = 0;
            this.modeClassRadio.TabStop = true;
            this.modeClassRadio.Text = "Mode Class ";
            this.modeClassRadio.UseVisualStyleBackColor = true;
            this.modeClassRadio.CheckedChanged += new System.EventHandler(this.modeClassRadio_CheckedChanged);
            // 
            // modeGroupRadio
            // 
            this.modeGroupRadio.AutoSize = true;
            this.modeGroupRadio.Location = new System.Drawing.Point(228, 43);
            this.modeGroupRadio.Name = "modeGroupRadio";
            this.modeGroupRadio.Size = new System.Drawing.Size(159, 21);
            this.modeGroupRadio.TabIndex = 1;
            this.modeGroupRadio.Text = "Mode Group Subject";
            this.modeGroupRadio.UseVisualStyleBackColor = true;
            this.modeGroupRadio.CheckedChanged += new System.EventHandler(this.modeGroupRadio_CheckedChanged);
            // 
            // panelChooseOption
            // 
            this.panelChooseOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChooseOption.Location = new System.Drawing.Point(0, 142);
            this.panelChooseOption.Name = "panelChooseOption";
            this.panelChooseOption.Size = new System.Drawing.Size(473, 649);
            this.panelChooseOption.TabIndex = 2;
            // 
            // ClassPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClassPanelForm";
            this.Text = "ClassPanelForm";
            this.Load += new System.EventHandler(this.ClassPanelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataShowGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton modeGroupRadio;
        private System.Windows.Forms.RadioButton modeClassRadio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataShowGrid;
        private System.Windows.Forms.Panel panelChooseOption;
    }
}