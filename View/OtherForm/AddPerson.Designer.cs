
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
            this.fullAddPanel = new System.Windows.Forms.Panel();
            this.footerChoosePanel = new System.Windows.Forms.Panel();
            this.contentAddPersonPanel = new System.Windows.Forms.Panel();
            this.upImageBtn = new System.Windows.Forms.Button();
            this.pictureAccount = new System.Windows.Forms.PictureBox();
            this.FeMaleRadio = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.genderLbl = new System.Windows.Forms.Label();
            this.cmndTxt = new System.Windows.Forms.TextBox();
            this.cmndLbl = new System.Windows.Forms.Label();
            this.pictureLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.birthLbl = new System.Windows.Forms.Label();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.IDLbl = new System.Windows.Forms.Label();
            this.topAddPersonPanel = new System.Windows.Forms.Panel();
            this.backPageBtn = new System.Windows.Forms.Button();
            this.backPagePanel = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.fullAddPanel.SuspendLayout();
            this.contentAddPersonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).BeginInit();
            this.topAddPersonPanel.SuspendLayout();
            this.backPagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullAddPanel
            // 
            this.fullAddPanel.BackColor = System.Drawing.Color.White;
            this.fullAddPanel.Controls.Add(this.footerChoosePanel);
            this.fullAddPanel.Controls.Add(this.contentAddPersonPanel);
            this.fullAddPanel.Controls.Add(this.topAddPersonPanel);
            this.fullAddPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullAddPanel.Location = new System.Drawing.Point(0, 0);
            this.fullAddPanel.Name = "fullAddPanel";
            this.fullAddPanel.Size = new System.Drawing.Size(1136, 838);
            this.fullAddPanel.TabIndex = 0;
            this.fullAddPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fullAddPanel_Paint);
            // 
            // footerChoosePanel
            // 
            this.footerChoosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerChoosePanel.Location = new System.Drawing.Point(0, 672);
            this.footerChoosePanel.Name = "footerChoosePanel";
            this.footerChoosePanel.Size = new System.Drawing.Size(1136, 166);
            this.footerChoosePanel.TabIndex = 2;
            this.footerChoosePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.footerChoosePanel_Paint);
            // 
            // contentAddPersonPanel
            // 
            this.contentAddPersonPanel.Controls.Add(this.upImageBtn);
            this.contentAddPersonPanel.Controls.Add(this.pictureAccount);
            this.contentAddPersonPanel.Controls.Add(this.FeMaleRadio);
            this.contentAddPersonPanel.Controls.Add(this.male);
            this.contentAddPersonPanel.Controls.Add(this.birthDatePicker);
            this.contentAddPersonPanel.Controls.Add(this.genderLbl);
            this.contentAddPersonPanel.Controls.Add(this.cmndTxt);
            this.contentAddPersonPanel.Controls.Add(this.cmndLbl);
            this.contentAddPersonPanel.Controls.Add(this.pictureLbl);
            this.contentAddPersonPanel.Controls.Add(this.emailTxt);
            this.contentAddPersonPanel.Controls.Add(this.emailLbl);
            this.contentAddPersonPanel.Controls.Add(this.phoneTxt);
            this.contentAddPersonPanel.Controls.Add(this.phoneLbl);
            this.contentAddPersonPanel.Controls.Add(this.addressTxt);
            this.contentAddPersonPanel.Controls.Add(this.addressLbl);
            this.contentAddPersonPanel.Controls.Add(this.birthLbl);
            this.contentAddPersonPanel.Controls.Add(this.lNameTxt);
            this.contentAddPersonPanel.Controls.Add(this.lNameLbl);
            this.contentAddPersonPanel.Controls.Add(this.fNameTxt);
            this.contentAddPersonPanel.Controls.Add(this.firstNameLbl);
            this.contentAddPersonPanel.Controls.Add(this.IDTxt);
            this.contentAddPersonPanel.Controls.Add(this.IDLbl);
            this.contentAddPersonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentAddPersonPanel.Location = new System.Drawing.Point(0, 100);
            this.contentAddPersonPanel.Name = "contentAddPersonPanel";
            this.contentAddPersonPanel.Size = new System.Drawing.Size(1136, 572);
            this.contentAddPersonPanel.TabIndex = 1;
            this.contentAddPersonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentAddPersonPanel_Paint);
            // 
            // upImageBtn
            // 
            this.upImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upImageBtn.Location = new System.Drawing.Point(189, 488);
            this.upImageBtn.Name = "upImageBtn";
            this.upImageBtn.Size = new System.Drawing.Size(116, 55);
            this.upImageBtn.TabIndex = 27;
            this.upImageBtn.Text = "Upload Image";
            this.upImageBtn.UseVisualStyleBackColor = true;
            this.upImageBtn.Click += new System.EventHandler(this.upImageBtn_Click);
            // 
            // pictureAccount
            // 
            this.pictureAccount.Location = new System.Drawing.Point(29, 488);
            this.pictureAccount.Name = "pictureAccount";
            this.pictureAccount.Size = new System.Drawing.Size(120, 68);
            this.pictureAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureAccount.TabIndex = 26;
            this.pictureAccount.TabStop = false;
            this.pictureAccount.Click += new System.EventHandler(this.pictureAccount_Click);
            // 
            // FeMaleRadio
            // 
            this.FeMaleRadio.AutoSize = true;
            this.FeMaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeMaleRadio.Location = new System.Drawing.Point(909, 269);
            this.FeMaleRadio.Name = "FeMaleRadio";
            this.FeMaleRadio.Size = new System.Drawing.Size(95, 28);
            this.FeMaleRadio.TabIndex = 25;
            this.FeMaleRadio.TabStop = true;
            this.FeMaleRadio.Text = "FeMale";
            this.FeMaleRadio.UseVisualStyleBackColor = true;
            this.FeMaleRadio.CheckedChanged += new System.EventHandler(this.FeMaleRadio_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(803, 269);
            this.male.Name = "male";
            this.male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.male.Size = new System.Drawing.Size(72, 28);
            this.male.TabIndex = 24;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDatePicker.Location = new System.Drawing.Point(39, 269);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 34);
            this.birthDatePicker.TabIndex = 22;
            this.birthDatePicker.ValueChanged += new System.EventHandler(this.birthDatePicker_ValueChanged);
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(798, 229);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(83, 25);
            this.genderLbl.TabIndex = 20;
            this.genderLbl.Text = "Gender:";
            this.genderLbl.Click += new System.EventHandler(this.genderLbl_Click);
            // 
            // cmndTxt
            // 
            this.cmndTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmndTxt.Location = new System.Drawing.Point(793, 401);
            this.cmndTxt.Multiline = true;
            this.cmndTxt.Name = "cmndTxt";
            this.cmndTxt.Size = new System.Drawing.Size(327, 34);
            this.cmndTxt.TabIndex = 19;
            this.cmndTxt.TextChanged += new System.EventHandler(this.cmndTxt_TextChanged);
            // 
            // cmndLbl
            // 
            this.cmndLbl.AutoSize = true;
            this.cmndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmndLbl.Location = new System.Drawing.Point(798, 370);
            this.cmndLbl.Name = "cmndLbl";
            this.cmndLbl.Size = new System.Drawing.Size(72, 25);
            this.cmndLbl.TabIndex = 18;
            this.cmndLbl.Text = "CMND";
            this.cmndLbl.Click += new System.EventHandler(this.cmndLbl_Click);
            // 
            // pictureLbl
            // 
            this.pictureLbl.AutoSize = true;
            this.pictureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLbl.Location = new System.Drawing.Point(34, 460);
            this.pictureLbl.Name = "pictureLbl";
            this.pictureLbl.Size = new System.Drawing.Size(72, 25);
            this.pictureLbl.TabIndex = 14;
            this.pictureLbl.Text = "Picture";
            this.pictureLbl.Click += new System.EventHandler(this.pictureLbl_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(419, 401);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(345, 34);
            this.emailTxt.TabIndex = 13;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(424, 370);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(60, 25);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email";
            this.emailLbl.Click += new System.EventHandler(this.emailLbl_Click);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(29, 401);
            this.phoneTxt.Multiline = true;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(345, 34);
            this.phoneTxt.TabIndex = 11;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(34, 370);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(69, 25);
            this.phoneLbl.TabIndex = 10;
            this.phoneLbl.Text = "Phone";
            this.phoneLbl.Click += new System.EventHandler(this.phoneLbl_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(419, 267);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(345, 34);
            this.addressTxt.TabIndex = 9;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(424, 229);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(85, 25);
            this.addressLbl.TabIndex = 8;
            this.addressLbl.Text = "Address";
            this.addressLbl.Click += new System.EventHandler(this.addressLbl_Click);
            // 
            // birthLbl
            // 
            this.birthLbl.AutoSize = true;
            this.birthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLbl.Location = new System.Drawing.Point(34, 229);
            this.birthLbl.Name = "birthLbl";
            this.birthLbl.Size = new System.Drawing.Size(97, 25);
            this.birthLbl.TabIndex = 6;
            this.birthLbl.Text = "Birth Date";
            this.birthLbl.Click += new System.EventHandler(this.birthLbl_Click);
            // 
            // lNameTxt
            // 
            this.lNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTxt.Location = new System.Drawing.Point(419, 160);
            this.lNameTxt.Multiline = true;
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(345, 34);
            this.lNameTxt.TabIndex = 5;
            this.lNameTxt.TextChanged += new System.EventHandler(this.lNameTxt_TextChanged);
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(424, 120);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(106, 25);
            this.lNameLbl.TabIndex = 4;
            this.lNameLbl.Text = "Last Name";
            this.lNameLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // fNameTxt
            // 
            this.fNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTxt.Location = new System.Drawing.Point(29, 160);
            this.fNameTxt.Multiline = true;
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(345, 34);
            this.fNameTxt.TabIndex = 3;
            this.fNameTxt.TextChanged += new System.EventHandler(this.fNameTxt_TextChanged);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(34, 120);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(106, 25);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "First Name";
            this.firstNameLbl.Click += new System.EventHandler(this.firstNameLbl_Click);
            // 
            // IDTxt
            // 
            this.IDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTxt.Location = new System.Drawing.Point(29, 63);
            this.IDTxt.Multiline = true;
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(345, 34);
            this.IDTxt.TabIndex = 1;
            this.IDTxt.TextChanged += new System.EventHandler(this.IDTxt_TextChanged);
            // 
            // IDLbl
            // 
            this.IDLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLbl.Location = new System.Drawing.Point(34, 16);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(31, 25);
            this.IDLbl.TabIndex = 0;
            this.IDLbl.Text = "ID";
            this.IDLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // topAddPersonPanel
            // 
            this.topAddPersonPanel.Controls.Add(this.backPageBtn);
            this.topAddPersonPanel.Controls.Add(this.backPagePanel);
            this.topAddPersonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topAddPersonPanel.Location = new System.Drawing.Point(0, 0);
            this.topAddPersonPanel.Name = "topAddPersonPanel";
            this.topAddPersonPanel.Size = new System.Drawing.Size(1136, 100);
            this.topAddPersonPanel.TabIndex = 0;
            this.topAddPersonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topAddPersonPanel_Paint);
            // 
            // backPageBtn
            // 
            this.backPageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backPageBtn.Location = new System.Drawing.Point(0, 0);
            this.backPageBtn.Name = "backPageBtn";
            this.backPageBtn.Size = new System.Drawing.Size(184, 100);
            this.backPageBtn.TabIndex = 1;
            this.backPageBtn.Text = "Back";
            this.backPageBtn.UseVisualStyleBackColor = true;
            this.backPageBtn.Click += new System.EventHandler(this.backPageBtn_Click);
            // 
            // backPagePanel
            // 
            this.backPagePanel.Controls.Add(this.titleLbl);
            this.backPagePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.backPagePanel.Location = new System.Drawing.Point(423, 0);
            this.backPagePanel.Name = "backPagePanel";
            this.backPagePanel.Size = new System.Drawing.Size(713, 100);
            this.backPagePanel.TabIndex = 0;
            this.backPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backPagePanel_Paint);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(0, 67);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(92, 33);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "label1";
            this.titleLbl.Click += new System.EventHandler(this.titleLbl_Click);
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fullAddPanel);
            this.Name = "AddPerson";
            this.Size = new System.Drawing.Size(1136, 838);
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.fullAddPanel.ResumeLayout(false);
            this.contentAddPersonPanel.ResumeLayout(false);
            this.contentAddPersonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).EndInit();
            this.topAddPersonPanel.ResumeLayout(false);
            this.backPagePanel.ResumeLayout(false);
            this.backPagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel fullAddPanel;
        public System.Windows.Forms.Panel contentAddPersonPanel;
        public System.Windows.Forms.Panel topAddPersonPanel;
        public System.Windows.Forms.Button backPageBtn;
        public System.Windows.Forms.Panel backPagePanel;
        public System.Windows.Forms.Label titleLbl;
        public System.Windows.Forms.TextBox IDTxt;
        public System.Windows.Forms.Label IDLbl;
        public System.Windows.Forms.Label genderLbl;
        public System.Windows.Forms.TextBox cmndTxt;
        public System.Windows.Forms.Label cmndLbl;
        public System.Windows.Forms.Label pictureLbl;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.Label emailLbl;
        public System.Windows.Forms.TextBox phoneTxt;
        public System.Windows.Forms.Label phoneLbl;
        public System.Windows.Forms.TextBox addressTxt;
        public System.Windows.Forms.Label addressLbl;
        public System.Windows.Forms.Label birthLbl;
        public System.Windows.Forms.TextBox lNameTxt;
        public System.Windows.Forms.Label lNameLbl;
        public System.Windows.Forms.TextBox fNameTxt;
        public System.Windows.Forms.Label firstNameLbl;
        public System.Windows.Forms.RadioButton FeMaleRadio;
        public System.Windows.Forms.RadioButton male;
        public System.Windows.Forms.DateTimePicker birthDatePicker;
        public System.Windows.Forms.Button upImageBtn;
        public System.Windows.Forms.PictureBox pictureAccount;
        public System.Windows.Forms.Panel footerChoosePanel;
    }
}
