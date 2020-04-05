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
            this.RoleListBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ConfirmBt = new System.Windows.Forms.Button();
            this.DoBTb = new System.Windows.Forms.DateTimePicker();
            this.GenderListBox = new System.Windows.Forms.ComboBox();
            this.PwCfTb = new System.Windows.Forms.TextBox();
            this.PwTb = new System.Windows.Forms.TextBox();
            this.UsTb = new System.Windows.Forms.TextBox();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.confirmpwlb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkPwLb);
            this.panel1.Controls.Add(this.RoleListBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ConfirmBt);
            this.panel1.Controls.Add(this.DoBTb);
            this.panel1.Controls.Add(this.GenderListBox);
            this.panel1.Controls.Add(this.PwCfTb);
            this.panel1.Controls.Add(this.PwTb);
            this.panel1.Controls.Add(this.UsTb);
            this.panel1.Controls.Add(this.EmailTb);
            this.panel1.Controls.Add(this.AddressTb);
            this.panel1.Controls.Add(this.PhoneTb);
            this.panel1.Controls.Add(this.nametb);
            this.panel1.Controls.Add(this.confirmpwlb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
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
            // RoleListBox
            // 
            this.RoleListBox.FormattingEnabled = true;
            this.RoleListBox.Items.AddRange(new object[] {
            "Manager",
            "Member"});
            this.RoleListBox.Location = new System.Drawing.Point(548, 58);
            this.RoleListBox.Name = "RoleListBox";
            this.RoleListBox.Size = new System.Drawing.Size(113, 24);
            this.RoleListBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "You are registering as";
            // 
            // ConfirmBt
            // 
            this.ConfirmBt.Location = new System.Drawing.Point(268, 344);
            this.ConfirmBt.Name = "ConfirmBt";
            this.ConfirmBt.Size = new System.Drawing.Size(178, 36);
            this.ConfirmBt.TabIndex = 19;
            this.ConfirmBt.Text = "Confirm";
            this.ConfirmBt.UseVisualStyleBackColor = true;
            this.ConfirmBt.Click += new System.EventHandler(this.button1_Click);
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
            this.UsTb.TextChanged += new System.EventHandler(this.UsTb_TextChanged);
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
            this.PhoneTb.TextChanged += new System.EventHandler(this.PhoneTb_TextChanged);
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(123, 60);
            this.nametb.MaxLength = 20;
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(227, 22);
            this.nametb.TabIndex = 10;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(394, 107);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(73, 17);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
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
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label confirmpwlb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmBt;
        private System.Windows.Forms.ComboBox RoleListBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label checkPwLb;
    }
}