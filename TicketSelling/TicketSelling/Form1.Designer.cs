namespace TicketSelling
{
    partial class Form1
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
            this.LoginPn = new System.Windows.Forms.Panel();
            this.LoginBt = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.LoginLb = new System.Windows.Forms.Label();
            this.LoginPn.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPn
            // 
            this.LoginPn.Controls.Add(this.LoginBt);
            this.LoginPn.Controls.Add(this.PasswordLabel);
            this.LoginPn.Controls.Add(this.UsernameLabel);
            this.LoginPn.Controls.Add(this.PasswordTextbox);
            this.LoginPn.Controls.Add(this.UsernameTextbox);
            this.LoginPn.Controls.Add(this.LoginLb);
            this.LoginPn.Location = new System.Drawing.Point(67, 55);
            this.LoginPn.Name = "LoginPn";
            this.LoginPn.Size = new System.Drawing.Size(298, 440);
            this.LoginPn.TabIndex = 0;
            // 
            // LoginBt
            // 
            this.LoginBt.Location = new System.Drawing.Point(85, 212);
            this.LoginBt.Name = "LoginBt";
            this.LoginBt.Size = new System.Drawing.Size(131, 37);
            this.LoginBt.TabIndex = 5;
            this.LoginBt.Text = "Login";
            this.LoginBt.UseVisualStyleBackColor = true;
            this.LoginBt.Click += new System.EventHandler(this.LoginBt_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(20, 138);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(20, 93);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(73, 17);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(99, 135);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(159, 22);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(99, 93);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(159, 22);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // LoginLb
            // 
            this.LoginLb.AutoSize = true;
            this.LoginLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLb.Location = new System.Drawing.Point(33, 46);
            this.LoginLb.Name = "LoginLb";
            this.LoginLb.Size = new System.Drawing.Size(60, 25);
            this.LoginLb.TabIndex = 0;
            this.LoginLb.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 586);
            this.Controls.Add(this.LoginPn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPn.ResumeLayout(false);
            this.LoginPn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPn;
        private System.Windows.Forms.Button LoginBt;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label LoginLb;
    }
}

