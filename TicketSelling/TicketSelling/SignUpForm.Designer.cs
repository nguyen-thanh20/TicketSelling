namespace TicketSelling
{
    partial class SignUpForm
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkPwLb = new System.Windows.Forms.Label();
            this.ConfirmBt = new System.Windows.Forms.Button();
            this.DoBTb = new System.Windows.Forms.DateTimePicker();
            this.GenderListBox = new System.Windows.Forms.ComboBox();
            this.PwCfTb = new System.Windows.Forms.TextBox();
            this.PwTb = new System.Windows.Forms.TextBox();
            this.UsTb = new System.Windows.Forms.TextBox();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.confirmpwlb = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.UsernameLb = new System.Windows.Forms.Label();
            this.DoBLb = new System.Windows.Forms.Label();
            this.GenderLb = new System.Windows.Forms.Label();
            this.EmailLb = new System.Windows.Forms.Label();
            this.AddressLb = new System.Windows.Forms.Label();
            this.LastNameLb = new System.Windows.Forms.Label();
            this.PhoneLb = new System.Windows.Forms.Label();
            this.FirstNameLb = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkPwLb);
            this.panel1.Controls.Add(this.ConfirmBt);
            this.panel1.Controls.Add(this.DoBTb);
            this.panel1.Controls.Add(this.GenderListBox);
            this.panel1.Controls.Add(this.PwCfTb);
            this.panel1.Controls.Add(this.PwTb);
            this.panel1.Controls.Add(this.UsTb);
            this.panel1.Controls.Add(this.EmailTb);
            this.panel1.Controls.Add(this.AddressTb);
            this.panel1.Controls.Add(this.PhoneTb);
            this.panel1.Controls.Add(this.LastNameTb);
            this.panel1.Controls.Add(this.FirstNameTb);
            this.panel1.Controls.Add(this.confirmpwlb);
            this.panel1.Controls.Add(this.PasswordLb);
            this.panel1.Controls.Add(this.UsernameLb);
            this.panel1.Controls.Add(this.DoBLb);
            this.panel1.Controls.Add(this.GenderLb);
            this.panel1.Controls.Add(this.EmailLb);
            this.panel1.Controls.Add(this.AddressLb);
            this.panel1.Controls.Add(this.LastNameLb);
            this.panel1.Controls.Add(this.PhoneLb);
            this.panel1.Controls.Add(this.FirstNameLb);
            this.panel1.Controls.Add(this.SignUpLabel);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 401);
            this.panel1.TabIndex = 0;
            // 
            // checkPwLb
            // 
            this.checkPwLb.AutoSize = true;
            this.checkPwLb.ForeColor = System.Drawing.Color.Red;
            this.checkPwLb.Location = new System.Drawing.Point(537, 225);
            this.checkPwLb.Name = "checkPwLb";
            this.checkPwLb.Size = new System.Drawing.Size(194, 17);
            this.checkPwLb.TabIndex = 22;
            this.checkPwLb.Text = "Wrong cormfirmed password!!";
            this.checkPwLb.Visible = false;
            // 
            // ConfirmBt
            // 
            this.ConfirmBt.Location = new System.Drawing.Point(268, 344);
            this.ConfirmBt.Name = "ConfirmBt";
            this.ConfirmBt.Size = new System.Drawing.Size(178, 36);
            this.ConfirmBt.TabIndex = 19;
            this.ConfirmBt.Text = "Confirm";
            this.ConfirmBt.UseVisualStyleBackColor = true;
            this.ConfirmBt.Click += new System.EventHandler(this.Confirm_click);
            // 
            // DoBTb
            // 
            this.DoBTb.Location = new System.Drawing.Point(123, 280);
            this.DoBTb.Name = "DoBTb";
            this.DoBTb.Size = new System.Drawing.Size(227, 22);
            this.DoBTb.TabIndex = 18;
            // 
            // GenderListBox
            // 
            this.GenderListBox.FormattingEnabled = true;
            this.GenderListBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderListBox.Location = new System.Drawing.Point(123, 232);
            this.GenderListBox.Name = "GenderListBox";
            this.GenderListBox.Size = new System.Drawing.Size(113, 24);
            this.GenderListBox.TabIndex = 17;
            // 
            // PwCfTb
            // 
            this.PwCfTb.Location = new System.Drawing.Point(533, 194);
            this.PwCfTb.MaxLength = 20;
            this.PwCfTb.Name = "PwCfTb";
            this.PwCfTb.Size = new System.Drawing.Size(212, 22);
            this.PwCfTb.TabIndex = 16;
            this.PwCfTb.UseSystemPasswordChar = true;
            this.PwCfTb.TextChanged += new System.EventHandler(this.PwCfTb_TextChanged);
            // 
            // PwTb
            // 
            this.PwTb.Location = new System.Drawing.Point(533, 151);
            this.PwTb.MaxLength = 20;
            this.PwTb.Name = "PwTb";
            this.PwTb.Size = new System.Drawing.Size(212, 22);
            this.PwTb.TabIndex = 15;
            this.PwTb.UseSystemPasswordChar = true;
            // 
            // UsTb
            // 
            this.UsTb.Location = new System.Drawing.Point(533, 104);
            this.UsTb.MaxLength = 20;
            this.UsTb.Name = "UsTb";
            this.UsTb.Size = new System.Drawing.Size(212, 22);
            this.UsTb.TabIndex = 14;
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(123, 190);
            this.EmailTb.MaxLength = 20;
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(227, 22);
            this.EmailTb.TabIndex = 13;
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(123, 145);
            this.AddressTb.MaxLength = 20;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(227, 22);
            this.AddressTb.TabIndex = 12;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(123, 107);
            this.PhoneTb.MaxLength = 20;
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(227, 22);
            this.PhoneTb.TabIndex = 11;
            this.PhoneTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneTb_KeyDown);
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(533, 60);
            this.LastNameTb.MaxLength = 20;
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(212, 22);
            this.LastNameTb.TabIndex = 10;
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(123, 60);
            this.FirstNameTb.MaxLength = 20;
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(227, 22);
            this.FirstNameTb.TabIndex = 10;
            // 
            // confirmpwlb
            // 
            this.confirmpwlb.AutoSize = true;
            this.confirmpwlb.Location = new System.Drawing.Point(394, 197);
            this.confirmpwlb.Name = "confirmpwlb";
            this.confirmpwlb.Size = new System.Drawing.Size(123, 17);
            this.confirmpwlb.TabIndex = 9;
            this.confirmpwlb.Text = "Comfirm password";
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(394, 155);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(69, 17);
            this.PasswordLb.TabIndex = 8;
            this.PasswordLb.Text = "Password";
            // 
            // UsernameLb
            // 
            this.UsernameLb.AutoSize = true;
            this.UsernameLb.Location = new System.Drawing.Point(394, 107);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(73, 17);
            this.UsernameLb.TabIndex = 7;
            this.UsernameLb.Text = "Username";
            // 
            // DoBLb
            // 
            this.DoBLb.AutoSize = true;
            this.DoBLb.Location = new System.Drawing.Point(28, 280);
            this.DoBLb.Name = "DoBLb";
            this.DoBLb.Size = new System.Drawing.Size(86, 17);
            this.DoBLb.TabIndex = 6;
            this.DoBLb.Text = "Date of birth";
            // 
            // GenderLb
            // 
            this.GenderLb.AutoSize = true;
            this.GenderLb.Location = new System.Drawing.Point(28, 235);
            this.GenderLb.Name = "GenderLb";
            this.GenderLb.Size = new System.Drawing.Size(56, 17);
            this.GenderLb.TabIndex = 5;
            this.GenderLb.Text = "Gender";
            // 
            // EmailLb
            // 
            this.EmailLb.AutoSize = true;
            this.EmailLb.Location = new System.Drawing.Point(28, 193);
            this.EmailLb.Name = "EmailLb";
            this.EmailLb.Size = new System.Drawing.Size(42, 17);
            this.EmailLb.TabIndex = 4;
            this.EmailLb.Text = "Email";
            // 
            // AddressLb
            // 
            this.AddressLb.AutoSize = true;
            this.AddressLb.Location = new System.Drawing.Point(28, 150);
            this.AddressLb.Name = "AddressLb";
            this.AddressLb.Size = new System.Drawing.Size(60, 17);
            this.AddressLb.TabIndex = 3;
            this.AddressLb.Text = "Address";
            // 
            // LastNameLb
            // 
            this.LastNameLb.AutoSize = true;
            this.LastNameLb.Location = new System.Drawing.Point(394, 61);
            this.LastNameLb.Name = "LastNameLb";
            this.LastNameLb.Size = new System.Drawing.Size(74, 17);
            this.LastNameLb.TabIndex = 1;
            this.LastNameLb.Text = "Last name";
            // 
            // PhoneLb
            // 
            this.PhoneLb.AutoSize = true;
            this.PhoneLb.Location = new System.Drawing.Point(28, 107);
            this.PhoneLb.Name = "PhoneLb";
            this.PhoneLb.Size = new System.Drawing.Size(49, 17);
            this.PhoneLb.TabIndex = 2;
            this.PhoneLb.Text = "Phone";
            // 
            // FirstNameLb
            // 
            this.FirstNameLb.AutoSize = true;
            this.FirstNameLb.Location = new System.Drawing.Point(28, 63);
            this.FirstNameLb.Name = "FirstNameLb";
            this.FirstNameLb.Size = new System.Drawing.Size(74, 17);
            this.FirstNameLb.TabIndex = 1;
            this.FirstNameLb.Text = "First name";
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(22, 12);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(82, 25);
            this.SignUpLabel.TabIndex = 0;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DoBTb;
        private System.Windows.Forms.ComboBox GenderListBox;
        private System.Windows.Forms.TextBox PwCfTb;
        private System.Windows.Forms.TextBox PwTb;
        private System.Windows.Forms.TextBox UsTb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.Label confirmpwlb;
        private System.Windows.Forms.Label PasswordLb;
        private System.Windows.Forms.Label UsernameLb;
        private System.Windows.Forms.Label DoBLb;
        private System.Windows.Forms.Label GenderLb;
        private System.Windows.Forms.Label EmailLb;
        private System.Windows.Forms.Label AddressLb;
        private System.Windows.Forms.Label PhoneLb;
        private System.Windows.Forms.Label FirstNameLb;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button ConfirmBt;
        private System.Windows.Forms.Label checkPwLb;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.Label LastNameLb;
    }
}