namespace TicketSelling.Manager
{
    partial class UserManagerForm
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
            this.DoBTb = new System.Windows.Forms.DateTimePicker();
            this.UserIDTb = new System.Windows.Forms.TextBox();
            this.UserIDLb = new System.Windows.Forms.Label();
            this.GenderLb = new System.Windows.Forms.Label();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.EmailLb = new System.Windows.Forms.Label();
            this.DetailGB = new System.Windows.Forms.GroupBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.AddressLb = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.PhoneLb = new System.Windows.Forms.Label();
            this.LastNameLb = new System.Windows.Forms.Label();
            this.FirstNameLb = new System.Windows.Forms.Label();
            this.DoBLb = new System.Windows.Forms.Label();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.SearchLb = new System.Windows.Forms.Label();
            this.SearchBt = new System.Windows.Forms.Button();
            this.DestLb = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.DataShow = new System.Windows.Forms.DataGridView();
            this.GenderListBox = new System.Windows.Forms.TextBox();
            this.warningDateInputLb = new System.Windows.Forms.Label();
            this.DetailGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // DoBTb
            // 
            this.DoBTb.Enabled = false;
            this.DoBTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DoBTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoBTb.Location = new System.Drawing.Point(10, 395);
            this.DoBTb.Name = "DoBTb";
            this.DoBTb.Size = new System.Drawing.Size(185, 26);
            this.DoBTb.TabIndex = 1;
            this.DoBTb.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // UserIDTb
            // 
            this.UserIDTb.Location = new System.Drawing.Point(10, 54);
            this.UserIDTb.Name = "UserIDTb";
            this.UserIDTb.ReadOnly = true;
            this.UserIDTb.Size = new System.Drawing.Size(185, 22);
            this.UserIDTb.TabIndex = 28;
            // 
            // UserIDLb
            // 
            this.UserIDLb.AutoSize = true;
            this.UserIDLb.Location = new System.Drawing.Point(8, 31);
            this.UserIDLb.Name = "UserIDLb";
            this.UserIDLb.Size = new System.Drawing.Size(55, 17);
            this.UserIDLb.TabIndex = 27;
            this.UserIDLb.Text = "User ID";
            // 
            // GenderLb
            // 
            this.GenderLb.AutoSize = true;
            this.GenderLb.Location = new System.Drawing.Point(9, 321);
            this.GenderLb.Name = "GenderLb";
            this.GenderLb.Size = new System.Drawing.Size(56, 17);
            this.GenderLb.TabIndex = 23;
            this.GenderLb.Text = "Gender";
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(11, 290);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.ReadOnly = true;
            this.EmailTb.Size = new System.Drawing.Size(185, 22);
            this.EmailTb.TabIndex = 22;
            // 
            // EmailLb
            // 
            this.EmailLb.AutoSize = true;
            this.EmailLb.Location = new System.Drawing.Point(9, 267);
            this.EmailLb.Name = "EmailLb";
            this.EmailLb.Size = new System.Drawing.Size(42, 17);
            this.EmailLb.TabIndex = 21;
            this.EmailLb.Text = "Email";
            // 
            // DetailGB
            // 
            this.DetailGB.BackColor = System.Drawing.SystemColors.Control;
            this.DetailGB.Controls.Add(this.GenderListBox);
            this.DetailGB.Controls.Add(this.DoBTb);
            this.DetailGB.Controls.Add(this.UserIDTb);
            this.DetailGB.Controls.Add(this.UserIDLb);
            this.DetailGB.Controls.Add(this.GenderLb);
            this.DetailGB.Controls.Add(this.EmailTb);
            this.DetailGB.Controls.Add(this.EmailLb);
            this.DetailGB.Controls.Add(this.AddressTb);
            this.DetailGB.Controls.Add(this.AddressLb);
            this.DetailGB.Controls.Add(this.PhoneTb);
            this.DetailGB.Controls.Add(this.PhoneLb);
            this.DetailGB.Controls.Add(this.LastNameLb);
            this.DetailGB.Controls.Add(this.FirstNameLb);
            this.DetailGB.Controls.Add(this.DoBLb);
            this.DetailGB.Controls.Add(this.LastNameTb);
            this.DetailGB.Controls.Add(this.FirstNameTb);
            this.DetailGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DetailGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailGB.Location = new System.Drawing.Point(532, 4);
            this.DetailGB.Name = "DetailGB";
            this.DetailGB.Size = new System.Drawing.Size(207, 595);
            this.DetailGB.TabIndex = 45;
            this.DetailGB.TabStop = false;
            this.DetailGB.Text = "Detail";
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(11, 242);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.ReadOnly = true;
            this.AddressTb.Size = new System.Drawing.Size(185, 22);
            this.AddressTb.TabIndex = 20;
            // 
            // AddressLb
            // 
            this.AddressLb.AutoSize = true;
            this.AddressLb.Location = new System.Drawing.Point(7, 222);
            this.AddressLb.Name = "AddressLb";
            this.AddressLb.Size = new System.Drawing.Size(60, 17);
            this.AddressLb.TabIndex = 19;
            this.AddressLb.Text = "Address";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(11, 197);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.ReadOnly = true;
            this.PhoneTb.Size = new System.Drawing.Size(185, 22);
            this.PhoneTb.TabIndex = 18;
            // 
            // PhoneLb
            // 
            this.PhoneLb.AutoSize = true;
            this.PhoneLb.Location = new System.Drawing.Point(8, 177);
            this.PhoneLb.Name = "PhoneLb";
            this.PhoneLb.Size = new System.Drawing.Size(49, 17);
            this.PhoneLb.TabIndex = 17;
            this.PhoneLb.Text = "Phone";
            // 
            // LastNameLb
            // 
            this.LastNameLb.AutoSize = true;
            this.LastNameLb.Location = new System.Drawing.Point(7, 129);
            this.LastNameLb.Name = "LastNameLb";
            this.LastNameLb.Size = new System.Drawing.Size(76, 17);
            this.LastNameLb.TabIndex = 12;
            this.LastNameLb.Text = "Last Name";
            // 
            // FirstNameLb
            // 
            this.FirstNameLb.AutoSize = true;
            this.FirstNameLb.Location = new System.Drawing.Point(7, 79);
            this.FirstNameLb.Name = "FirstNameLb";
            this.FirstNameLb.Size = new System.Drawing.Size(76, 17);
            this.FirstNameLb.TabIndex = 12;
            this.FirstNameLb.Text = "First Name";
            // 
            // DoBLb
            // 
            this.DoBLb.AutoSize = true;
            this.DoBLb.Location = new System.Drawing.Point(6, 372);
            this.DoBLb.Name = "DoBLb";
            this.DoBLb.Size = new System.Drawing.Size(87, 17);
            this.DoBLb.TabIndex = 14;
            this.DoBLb.Text = "Date of Birth";
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(11, 152);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.ReadOnly = true;
            this.LastNameTb.Size = new System.Drawing.Size(185, 22);
            this.LastNameTb.TabIndex = 13;
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(11, 102);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.ReadOnly = true;
            this.FirstNameTb.Size = new System.Drawing.Size(185, 22);
            this.FirstNameTb.TabIndex = 13;
            // 
            // SearchLb
            // 
            this.SearchLb.AutoSize = true;
            this.SearchLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLb.Location = new System.Drawing.Point(1, 31);
            this.SearchLb.Name = "SearchLb";
            this.SearchLb.Size = new System.Drawing.Size(62, 20);
            this.SearchLb.TabIndex = 44;
            this.SearchLb.Text = "Search";
            // 
            // SearchBt
            // 
            this.SearchBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchBt.Location = new System.Drawing.Point(445, 30);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(72, 25);
            this.SearchBt.TabIndex = 43;
            this.SearchBt.Text = "Find";
            this.SearchBt.UseVisualStyleBackColor = false;
            this.SearchBt.Click += new System.EventHandler(this.SearchBt_Click);
            // 
            // DestLb
            // 
            this.DestLb.AutoSize = true;
            this.DestLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestLb.Location = new System.Drawing.Point(205, 31);
            this.DestLb.Name = "DestLb";
            this.DestLb.Size = new System.Drawing.Size(37, 20);
            this.DestLb.TabIndex = 51;
            this.DestLb.Text = "Key";
            // 
            // SearchCB
            // 
            this.SearchCB.FormattingEnabled = true;
            this.SearchCB.Items.AddRange(new object[] {
            "ID",
            "First_Name",
            "Last_Name",
            "Phone",
            "Address",
            "Email",
            "Gender",
            "Date_Of_Birth"});
            this.SearchCB.Location = new System.Drawing.Point(81, 31);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(118, 24);
            this.SearchCB.TabIndex = 50;
            this.SearchCB.SelectedValueChanged += new System.EventHandler(this.SearchCB_SelectedValueChanged);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(248, 31);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(185, 22);
            this.SearchTb.TabIndex = 49;
            this.SearchTb.Tag = "";
            this.SearchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataShow
            // 
            this.DataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShow.Location = new System.Drawing.Point(5, 70);
            this.DataShow.Name = "DataShow";
            this.DataShow.ReadOnly = true;
            this.DataShow.RowHeadersWidth = 51;
            this.DataShow.RowTemplate.Height = 24;
            this.DataShow.Size = new System.Drawing.Size(512, 474);
            this.DataShow.TabIndex = 42;
            this.DataShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataShow_CellClick);
            // 
            // GenderListBox
            // 
            this.GenderListBox.Location = new System.Drawing.Point(11, 341);
            this.GenderListBox.Name = "GenderListBox";
            this.GenderListBox.ReadOnly = true;
            this.GenderListBox.Size = new System.Drawing.Size(185, 22);
            this.GenderListBox.TabIndex = 29;
            // 
            // warningDateInputLb
            // 
            this.warningDateInputLb.AutoSize = true;
            this.warningDateInputLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningDateInputLb.ForeColor = System.Drawing.Color.Red;
            this.warningDateInputLb.Location = new System.Drawing.Point(250, 6);
            this.warningDateInputLb.Name = "warningDateInputLb";
            this.warningDateInputLb.Size = new System.Drawing.Size(150, 18);
            this.warningDateInputLb.TabIndex = 52;
            this.warningDateInputLb.Text = "*Format YYYYmmDD";
            this.warningDateInputLb.Visible = false;
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 602);
            this.Controls.Add(this.warningDateInputLb);
            this.Controls.Add(this.DetailGB);
            this.Controls.Add(this.SearchLb);
            this.Controls.Add(this.SearchBt);
            this.Controls.Add(this.DestLb);
            this.Controls.Add(this.SearchCB);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.DataShow);
            this.Name = "UserManagerForm";
            this.Text = "UserManagerForm";
            this.DetailGB.ResumeLayout(false);
            this.DetailGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DoBTb;
        private System.Windows.Forms.TextBox UserIDTb;
        private System.Windows.Forms.Label UserIDLb;
        private System.Windows.Forms.Label GenderLb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label EmailLb;
        private System.Windows.Forms.GroupBox DetailGB;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label AddressLb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label PhoneLb;
        private System.Windows.Forms.Label LastNameLb;
        private System.Windows.Forms.Label FirstNameLb;
        private System.Windows.Forms.Label DoBLb;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.Label SearchLb;
        private System.Windows.Forms.Button SearchBt;
        private System.Windows.Forms.Label DestLb;
        private System.Windows.Forms.ComboBox SearchCB;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.DataGridView DataShow;
        private System.Windows.Forms.TextBox GenderListBox;
        private System.Windows.Forms.Label warningDateInputLb;
    }
}