namespace TicketSelling
{
    partial class fSignUp
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
            this.checkPwLb = new System.Windows.Forms.Label();
            this.ConfirmBt = new System.Windows.Forms.Button();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbCfPass = new System.Windows.Forms.TextBox();
            this.tbPassSignUp = new System.Windows.Forms.TextBox();
            this.tbUserSignUp = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.confirmpwlb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkPwLb);
            this.panel1.Controls.Add(this.ConfirmBt);
            this.panel1.Controls.Add(this.dtDOB);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.tbCfPass);
            this.panel1.Controls.Add(this.tbPassSignUp);
            this.panel1.Controls.Add(this.tbUserSignUp);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.confirmpwlb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 459);
            this.panel1.TabIndex = 1;
            // 
            // checkPwLb
            // 
            this.checkPwLb.AutoSize = true;
            this.checkPwLb.ForeColor = System.Drawing.Color.Red;
            this.checkPwLb.Location = new System.Drawing.Point(420, 199);
            this.checkPwLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkPwLb.Name = "checkPwLb";
            this.checkPwLb.Size = new System.Drawing.Size(196, 19);
            this.checkPwLb.TabIndex = 22;
            this.checkPwLb.Text = "Wrong cormfirmed password!!";
            this.checkPwLb.Visible = false;
            this.checkPwLb.Click += new System.EventHandler(this.checkPwLb_Click);
            // 
            // ConfirmBt
            // 
            this.ConfirmBt.Location = new System.Drawing.Point(242, 404);
            this.ConfirmBt.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmBt.Name = "ConfirmBt";
            this.ConfirmBt.Size = new System.Drawing.Size(134, 29);
            this.ConfirmBt.TabIndex = 11;
            this.ConfirmBt.Text = "Confirm";
            this.ConfirmBt.UseVisualStyleBackColor = true;
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(107, 346);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(255, 26);
            this.dtDOB.TabIndex = 7;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(106, 301);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(86, 27);
            this.cbGender.TabIndex = 6;
            // 
            // tbCfPass
            // 
            this.tbCfPass.Location = new System.Drawing.Point(456, 143);
            this.tbCfPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbCfPass.MaxLength = 20;
            this.tbCfPass.Name = "tbCfPass";
            this.tbCfPass.Size = new System.Drawing.Size(160, 26);
            this.tbCfPass.TabIndex = 10;
            this.tbCfPass.UseSystemPasswordChar = true;
            this.tbCfPass.TextChanged += new System.EventHandler(this.PwCfTb_TextChanged);
            // 
            // tbPassSignUp
            // 
            this.tbPassSignUp.Location = new System.Drawing.Point(456, 102);
            this.tbPassSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassSignUp.MaxLength = 20;
            this.tbPassSignUp.Name = "tbPassSignUp";
            this.tbPassSignUp.Size = new System.Drawing.Size(160, 26);
            this.tbPassSignUp.TabIndex = 9;
            this.tbPassSignUp.UseSystemPasswordChar = true;
            this.tbPassSignUp.TextChanged += new System.EventHandler(this.PwTb_TextChanged);
            // 
            // tbUserSignUp
            // 
            this.tbUserSignUp.Location = new System.Drawing.Point(456, 63);
            this.tbUserSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserSignUp.MaxLength = 20;
            this.tbUserSignUp.Name = "tbUserSignUp";
            this.tbUserSignUp.Size = new System.Drawing.Size(160, 26);
            this.tbUserSignUp.TabIndex = 8;
            this.tbUserSignUp.TextChanged += new System.EventHandler(this.UsTb_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(106, 258);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.MaxLength = 20;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(171, 26);
            this.tbEmail.TabIndex = 5;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(106, 210);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.MaxLength = 20;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(171, 26);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.TextChanged += new System.EventHandler(this.AddressTb_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(106, 165);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(171, 26);
            this.tbPhone.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(106, 118);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(171, 26);
            this.tbLastName.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(107, 67);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(171, 26);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // confirmpwlb
            // 
            this.confirmpwlb.AutoSize = true;
            this.confirmpwlb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpwlb.Location = new System.Drawing.Point(306, 150);
            this.confirmpwlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmpwlb.Name = "confirmpwlb";
            this.confirmpwlb.Size = new System.Drawing.Size(125, 19);
            this.confirmpwlb.TabIndex = 9;
            this.confirmpwlb.Text = "Comfirm password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(307, 77);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 19);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // fSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 481);
            this.Controls.Add(this.panel1);
            this.Name = "fSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label checkPwLb;
        private System.Windows.Forms.Button ConfirmBt;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbCfPass;
        private System.Windows.Forms.TextBox tbPassSignUp;
        private System.Windows.Forms.TextBox tbUserSignUp;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFirstName;
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
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label8;
    }
}