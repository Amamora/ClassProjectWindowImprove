
namespace WindowClassProject.View.OtherForm
{
    partial class ChartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.data = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart ";
            // 
            // data
            // 
            this.data.animationEnabled = false;
            this.data.AxisLineColor = System.Drawing.Color.LightGray;
            this.data.AxisXFontColor = System.Drawing.Color.Gray;
            this.data.AxisXGridColor = System.Drawing.Color.Gray;
            this.data.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data.AxisYFontColor = System.Drawing.Color.Gray;
            this.data.AxisYGridColor = System.Drawing.Color.Gray;
            this.data.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.data.Location = new System.Drawing.Point(239, 189);
            this.data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(655, 398);
            this.data.TabIndex = 1;
            this.data.Theme = Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._theme.theme1;
            this.data.Title = "";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 791);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel1);
            this.Name = "ChartForm";
            this.Text = "View Chart";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced data;
    }
}