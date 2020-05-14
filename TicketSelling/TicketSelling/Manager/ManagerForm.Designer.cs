namespace TicketSelling
{
    partial class ManagerForm
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
            this.RightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ManagerLb = new System.Windows.Forms.Label();
            this.TripBt = new System.Windows.Forms.Button();
            this.UserBt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DriverBt = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.AutoSize = true;
            this.RightPanel.Location = new System.Drawing.Point(255, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(758, 649);
            this.RightPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ManagerLb);
            this.LeftPanel.Controls.Add(this.TripBt);
            this.LeftPanel.Controls.Add(this.UserBt);
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.DriverBt);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(254, 649);
            this.LeftPanel.TabIndex = 1;
            // 
            // ManagerLb
            // 
            this.ManagerLb.AutoSize = true;
            this.ManagerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLb.Location = new System.Drawing.Point(3, 8);
            this.ManagerLb.Name = "ManagerLb";
            this.ManagerLb.Size = new System.Drawing.Size(151, 39);
            this.ManagerLb.TabIndex = 8;
            this.ManagerLb.Text = "Manager";
            // 
            // TripBt
            // 
            this.TripBt.Location = new System.Drawing.Point(0, 78);
            this.TripBt.Name = "TripBt";
            this.TripBt.Size = new System.Drawing.Size(253, 51);
            this.TripBt.TabIndex = 7;
            this.TripBt.Text = "Trip";
            this.TripBt.UseVisualStyleBackColor = true;
            this.TripBt.Click += new System.EventHandler(this.TripBt_Click);
            // 
            // UserBt
            // 
            this.UserBt.Location = new System.Drawing.Point(0, 192);
            this.UserBt.Name = "UserBt";
            this.UserBt.Size = new System.Drawing.Size(253, 51);
            this.UserBt.TabIndex = 6;
            this.UserBt.Text = "User";
            this.UserBt.UseVisualStyleBackColor = true;
            this.UserBt.Click += new System.EventHandler(this.UserBt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DriverBt_Click);
            // 
            // DriverBt
            // 
            this.DriverBt.Location = new System.Drawing.Point(0, 135);
            this.DriverBt.Name = "DriverBt";
            this.DriverBt.Size = new System.Drawing.Size(253, 51);
            this.DriverBt.TabIndex = 6;
            this.DriverBt.Text = "Driver";
            this.DriverBt.UseVisualStyleBackColor = true;
            this.DriverBt.Click += new System.EventHandler(this.DriverBt_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 649);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label ManagerLb;
        private System.Windows.Forms.Button TripBt;
        private System.Windows.Forms.Button DriverBt;
        private System.Windows.Forms.Button UserBt;
        private System.Windows.Forms.Button button1;
    }
}