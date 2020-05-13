namespace TicketSelling
{
    partial class DriverManager
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
            this.SearchLb = new System.Windows.Forms.Label();
            this.DataShow = new System.Windows.Forms.DataGridView();
            this.SearchBt = new System.Windows.Forms.Button();
            this.DetailGB = new System.Windows.Forms.GroupBox();
            this.GenderListBox = new System.Windows.Forms.ComboBox();
            this.DoBTb = new System.Windows.Forms.DateTimePicker();
            this.DriverIDTb = new System.Windows.Forms.TextBox();
            this.DriverID = new System.Windows.Forms.Label();
            this.GenderLb = new System.Windows.Forms.Label();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.EmailLb = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.AddressLb = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.PhoneLb = new System.Windows.Forms.Label();
            this.LastNameLb = new System.Windows.Forms.Label();
            this.FirstNameLb = new System.Windows.Forms.Label();
            this.DoBLb = new System.Windows.Forms.Label();
            this.saveBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.EditBt = new System.Windows.Forms.Button();
            this.AddBt = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.DestLb = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.warningDateInputLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).BeginInit();
            this.DetailGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchLb
            // 
            this.SearchLb.AutoSize = true;
            this.SearchLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLb.Location = new System.Drawing.Point(8, 39);
            this.SearchLb.Name = "SearchLb";
            this.SearchLb.Size = new System.Drawing.Size(62, 20);
            this.SearchLb.TabIndex = 33;
            this.SearchLb.Text = "Search";
            // 
            // DataShow
            // 
            this.DataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShow.Location = new System.Drawing.Point(12, 78);
            this.DataShow.Name = "DataShow";
            this.DataShow.ReadOnly = true;
            this.DataShow.RowHeadersWidth = 51;
            this.DataShow.RowTemplate.Height = 24;
            this.DataShow.Size = new System.Drawing.Size(512, 474);
            this.DataShow.TabIndex = 31;
            this.DataShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataShow_CellClick);
            // 
            // SearchBt
            // 
            this.SearchBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchBt.Location = new System.Drawing.Point(452, 38);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(72, 25);
            this.SearchBt.TabIndex = 32;
            this.SearchBt.Text = "Find";
            this.SearchBt.UseVisualStyleBackColor = false;
            this.SearchBt.Click += new System.EventHandler(this.SearchBt_Click);
            // 
            // DetailGB
            // 
            this.DetailGB.BackColor = System.Drawing.SystemColors.Control;
            this.DetailGB.Controls.Add(this.GenderListBox);
            this.DetailGB.Controls.Add(this.DoBTb);
            this.DetailGB.Controls.Add(this.DriverIDTb);
            this.DetailGB.Controls.Add(this.DriverID);
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
            this.DetailGB.Controls.Add(this.saveBt);
            this.DetailGB.Controls.Add(this.cancelBt);
            this.DetailGB.Controls.Add(this.LastNameTb);
            this.DetailGB.Controls.Add(this.FirstNameTb);
            this.DetailGB.Enabled = false;
            this.DetailGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DetailGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailGB.Location = new System.Drawing.Point(539, 12);
            this.DetailGB.Name = "DetailGB";
            this.DetailGB.Size = new System.Drawing.Size(207, 595);
            this.DetailGB.TabIndex = 34;
            this.DetailGB.TabStop = false;
            this.DetailGB.Text = "Detail";
            // 
            // GenderListBox
            // 
            this.GenderListBox.FormattingEnabled = true;
            this.GenderListBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderListBox.Location = new System.Drawing.Point(12, 341);
            this.GenderListBox.Name = "GenderListBox";
            this.GenderListBox.Size = new System.Drawing.Size(183, 24);
            this.GenderListBox.TabIndex = 30;
            // 
            // DoBTb
            // 
            this.DoBTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DoBTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoBTb.Location = new System.Drawing.Point(10, 395);
            this.DoBTb.Name = "DoBTb";
            this.DoBTb.Size = new System.Drawing.Size(185, 26);
            this.DoBTb.TabIndex = 1;
            this.DoBTb.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // DriverIDTb
            // 
            this.DriverIDTb.Location = new System.Drawing.Point(10, 54);
            this.DriverIDTb.Name = "DriverIDTb";
            this.DriverIDTb.Size = new System.Drawing.Size(185, 22);
            this.DriverIDTb.TabIndex = 28;
            // 
            // DriverID
            // 
            this.DriverID.AutoSize = true;
            this.DriverID.Location = new System.Drawing.Point(8, 31);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(63, 17);
            this.DriverID.TabIndex = 27;
            this.DriverID.Text = "Driver ID";
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
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(11, 242);
            this.AddressTb.Name = "AddressTb";
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
            this.PhoneTb.Size = new System.Drawing.Size(185, 22);
            this.PhoneTb.TabIndex = 18;
            this.PhoneTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneTb_KeyDown);
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
            // saveBt
            // 
            this.saveBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveBt.Location = new System.Drawing.Point(10, 545);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(72, 26);
            this.saveBt.TabIndex = 9;
            this.saveBt.Text = "Save";
            this.saveBt.UseVisualStyleBackColor = false;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBt.Location = new System.Drawing.Point(125, 544);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(71, 26);
            this.cancelBt.TabIndex = 8;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = false;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(11, 152);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(185, 22);
            this.LastNameTb.TabIndex = 13;
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(11, 102);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(185, 22);
            this.FirstNameTb.TabIndex = 13;
            // 
            // EditBt
            // 
            this.EditBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditBt.Location = new System.Drawing.Point(226, 558);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(72, 26);
            this.EditBt.TabIndex = 37;
            this.EditBt.Text = "Edit";
            this.EditBt.UseVisualStyleBackColor = false;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // AddBt
            // 
            this.AddBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBt.Location = new System.Drawing.Point(12, 558);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(72, 26);
            this.AddBt.TabIndex = 36;
            this.AddBt.Text = "Add";
            this.AddBt.UseVisualStyleBackColor = false;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBt.Location = new System.Drawing.Point(453, 558);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(71, 26);
            this.DeleteBt.TabIndex = 35;
            this.DeleteBt.Text = "Delete";
            this.DeleteBt.UseVisualStyleBackColor = false;
            // 
            // DestLb
            // 
            this.DestLb.AutoSize = true;
            this.DestLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestLb.Location = new System.Drawing.Point(212, 39);
            this.DestLb.Name = "DestLb";
            this.DestLb.Size = new System.Drawing.Size(37, 20);
            this.DestLb.TabIndex = 41;
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
            this.SearchCB.Location = new System.Drawing.Point(76, 39);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(118, 24);
            this.SearchCB.TabIndex = 40;
            this.SearchCB.SelectedValueChanged += new System.EventHandler(this.SearchCB_SelectedValueChanged);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(255, 39);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(185, 22);
            this.SearchTb.TabIndex = 39;
            this.SearchTb.Tag = "";
            this.SearchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // warningDateInputLb
            // 
            this.warningDateInputLb.AutoSize = true;
            this.warningDateInputLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningDateInputLb.ForeColor = System.Drawing.Color.Red;
            this.warningDateInputLb.Location = new System.Drawing.Point(252, 12);
            this.warningDateInputLb.Name = "warningDateInputLb";
            this.warningDateInputLb.Size = new System.Drawing.Size(150, 18);
            this.warningDateInputLb.TabIndex = 53;
            this.warningDateInputLb.Text = "*Format YYYYmmDD";
            this.warningDateInputLb.Visible = false;
            // 
            // DriverManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 602);
            this.Controls.Add(this.warningDateInputLb);
            this.Controls.Add(this.DestLb);
            this.Controls.Add(this.SearchCB);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.DetailGB);
            this.Controls.Add(this.SearchLb);
            this.Controls.Add(this.DataShow);
            this.Controls.Add(this.SearchBt);
            this.Name = "DriverManager";
            this.Text = "DriverManager";
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).EndInit();
            this.DetailGB.ResumeLayout(false);
            this.DetailGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLb;
        private System.Windows.Forms.DataGridView DataShow;
        private System.Windows.Forms.Button SearchBt;
        private System.Windows.Forms.GroupBox DetailGB;
        private System.Windows.Forms.DateTimePicker DoBTb;
        private System.Windows.Forms.TextBox DriverIDTb;
        private System.Windows.Forms.Label DriverID;
        private System.Windows.Forms.Label GenderLb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label EmailLb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label AddressLb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label PhoneLb;
        private System.Windows.Forms.Label FirstNameLb;
        private System.Windows.Forms.Label DoBLb;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Label LastNameLb;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.ComboBox GenderListBox;
        private System.Windows.Forms.Label DestLb;
        private System.Windows.Forms.ComboBox SearchCB;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Label warningDateInputLb;
    }
}