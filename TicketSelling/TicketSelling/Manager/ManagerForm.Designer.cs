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
            this.ControlBt = new System.Windows.Forms.Button();
            this.ReportBt = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(255, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(758, 649);
            this.RightPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ManagerLb);
            this.LeftPanel.Controls.Add(this.ControlBt);
            this.LeftPanel.Controls.Add(this.ReportBt);
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
            // ControlBt
            // 
            this.ControlBt.Location = new System.Drawing.Point(0, 78);
            this.ControlBt.Name = "ControlBt";
            this.ControlBt.Size = new System.Drawing.Size(253, 51);
            this.ControlBt.TabIndex = 7;
            this.ControlBt.Text = "Control";
            this.ControlBt.UseVisualStyleBackColor = true;
            this.ControlBt.Click += new System.EventHandler(this.ControlBt_Click);
            // 
            // ReportBt
            // 
            this.ReportBt.Location = new System.Drawing.Point(0, 135);
            this.ReportBt.Name = "ReportBt";
            this.ReportBt.Size = new System.Drawing.Size(253, 51);
            this.ReportBt.TabIndex = 6;
            this.ReportBt.Text = "Report";
            this.ReportBt.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 649);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label ManagerLb;
        private System.Windows.Forms.Button ControlBt;
        private System.Windows.Forms.Button ReportBt;
    }
}