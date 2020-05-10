namespace TicketSelling.Manager
{
    partial class ControlForm
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
            this.DataShow = new System.Windows.Forms.DataGridView();
            this.DetailGB = new System.Windows.Forms.GroupBox();
            this.DateTripTb = new System.Windows.Forms.DateTimePicker();
            this.DriverIDTb = new System.Windows.Forms.TextBox();
            this.DriverID = new System.Windows.Forms.Label();
            this.DiscountTb = new System.Windows.Forms.TextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TotalSeatTb = new System.Windows.Forms.TextBox();
            this.TotalSLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeTb = new System.Windows.Forms.TextBox();
            this.ArrivalLabel = new System.Windows.Forms.Label();
            this.StartTimeTb = new System.Windows.Forms.TextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.saveBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.SourceTb = new System.Windows.Forms.TextBox();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.SearchLb = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.SearchBt = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.AddBt = new System.Windows.Forms.Button();
            this.EditBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).BeginInit();
            this.DetailGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataShow
            // 
            this.DataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShow.Location = new System.Drawing.Point(12, 76);
            this.DataShow.Name = "DataShow";
            this.DataShow.RowHeadersWidth = 51;
            this.DataShow.RowTemplate.Height = 24;
            this.DataShow.Size = new System.Drawing.Size(512, 474);
            this.DataShow.TabIndex = 1;
            this.DataShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataShow_CellClick);
            // 
            // DetailGB
            // 
            this.DetailGB.BackColor = System.Drawing.SystemColors.Control;
            this.DetailGB.Controls.Add(this.DateTripTb);
            this.DetailGB.Controls.Add(this.DriverIDTb);
            this.DetailGB.Controls.Add(this.DriverID);
            this.DetailGB.Controls.Add(this.DiscountTb);
            this.DetailGB.Controls.Add(this.DiscountLabel);
            this.DetailGB.Controls.Add(this.PriceTb);
            this.DetailGB.Controls.Add(this.PriceLabel);
            this.DetailGB.Controls.Add(this.TotalSeatTb);
            this.DetailGB.Controls.Add(this.TotalSLabel);
            this.DetailGB.Controls.Add(this.ArrivalTimeTb);
            this.DetailGB.Controls.Add(this.ArrivalLabel);
            this.DetailGB.Controls.Add(this.StartTimeTb);
            this.DetailGB.Controls.Add(this.StartLabel);
            this.DetailGB.Controls.Add(this.SourceLabel);
            this.DetailGB.Controls.Add(this.DestinationLabel);
            this.DetailGB.Controls.Add(this.DateLabel);
            this.DetailGB.Controls.Add(this.saveBt);
            this.DetailGB.Controls.Add(this.cancelBt);
            this.DetailGB.Controls.Add(this.DestinationTb);
            this.DetailGB.Controls.Add(this.SourceTb);
            this.DetailGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DetailGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailGB.Location = new System.Drawing.Point(530, 12);
            this.DetailGB.Name = "DetailGB";
            this.DetailGB.Size = new System.Drawing.Size(207, 595);
            this.DetailGB.TabIndex = 2;
            this.DetailGB.TabStop = false;
            this.DetailGB.Text = "Detail";
            // 
            // DateTripTb
            // 
            this.DateTripTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTripTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTripTb.Location = new System.Drawing.Point(11, 154);
            this.DateTripTb.Name = "DateTripTb";
            this.DateTripTb.Size = new System.Drawing.Size(185, 26);
            this.DateTripTb.TabIndex = 1;
            this.DateTripTb.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // DriverIDTb
            // 
            this.DriverIDTb.Location = new System.Drawing.Point(11, 466);
            this.DriverIDTb.Name = "DriverIDTb";
            this.DriverIDTb.Size = new System.Drawing.Size(185, 22);
            this.DriverIDTb.TabIndex = 28;
            // 
            // DriverID
            // 
            this.DriverID.AutoSize = true;
            this.DriverID.Location = new System.Drawing.Point(9, 443);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(63, 17);
            this.DriverID.TabIndex = 27;
            this.DriverID.Text = "Driver ID";
            // 
            // DiscountTb
            // 
            this.DiscountTb.Location = new System.Drawing.Point(11, 414);
            this.DiscountTb.Name = "DiscountTb";
            this.DiscountTb.Size = new System.Drawing.Size(185, 22);
            this.DiscountTb.TabIndex = 26;
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(9, 391);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(63, 17);
            this.DiscountLabel.TabIndex = 25;
            this.DiscountLabel.Text = "Discount";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(11, 362);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(185, 22);
            this.PriceTb.TabIndex = 24;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(9, 339);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(40, 17);
            this.PriceLabel.TabIndex = 23;
            this.PriceLabel.Text = "Price";
            // 
            // TotalSeatTb
            // 
            this.TotalSeatTb.Location = new System.Drawing.Point(11, 310);
            this.TotalSeatTb.Name = "TotalSeatTb";
            this.TotalSeatTb.Size = new System.Drawing.Size(185, 22);
            this.TotalSeatTb.TabIndex = 22;
            // 
            // TotalSLabel
            // 
            this.TotalSLabel.AutoSize = true;
            this.TotalSLabel.Location = new System.Drawing.Point(9, 287);
            this.TotalSLabel.Name = "TotalSLabel";
            this.TotalSLabel.Size = new System.Drawing.Size(73, 17);
            this.TotalSLabel.TabIndex = 21;
            this.TotalSLabel.Text = "Total Seat";
            // 
            // ArrivalTimeTb
            // 
            this.ArrivalTimeTb.Location = new System.Drawing.Point(11, 258);
            this.ArrivalTimeTb.Name = "ArrivalTimeTb";
            this.ArrivalTimeTb.Size = new System.Drawing.Size(185, 22);
            this.ArrivalTimeTb.TabIndex = 20;
            // 
            // ArrivalLabel
            // 
            this.ArrivalLabel.AutoSize = true;
            this.ArrivalLabel.Location = new System.Drawing.Point(9, 235);
            this.ArrivalLabel.Name = "ArrivalLabel";
            this.ArrivalLabel.Size = new System.Drawing.Size(83, 17);
            this.ArrivalLabel.TabIndex = 19;
            this.ArrivalLabel.Text = "Arrival Time";
            // 
            // StartTimeTb
            // 
            this.StartTimeTb.Location = new System.Drawing.Point(11, 206);
            this.StartTimeTb.Name = "StartTimeTb";
            this.StartTimeTb.Size = new System.Drawing.Size(185, 22);
            this.StartTimeTb.TabIndex = 18;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(7, 183);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(73, 17);
            this.StartLabel.TabIndex = 17;
            this.StartLabel.Text = "Start Time";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(7, 27);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(53, 17);
            this.SourceLabel.TabIndex = 10;
            this.SourceLabel.Text = "Source";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(7, 79);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(79, 17);
            this.DestinationLabel.TabIndex = 12;
            this.DestinationLabel.Text = "Destination";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(7, 131);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(67, 17);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Date Trip";
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
            // 
            // DestinationTb
            // 
            this.DestinationTb.Location = new System.Drawing.Point(11, 102);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(185, 22);
            this.DestinationTb.TabIndex = 13;
            // 
            // SourceTb
            // 
            this.SourceTb.Location = new System.Drawing.Point(11, 50);
            this.SourceTb.Name = "SourceTb";
            this.SourceTb.Size = new System.Drawing.Size(185, 22);
            this.SourceTb.TabIndex = 11;
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(204, 49);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(185, 22);
            this.SearchTb.TabIndex = 29;
            this.SearchTb.Tag = "";
            this.SearchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchLb
            // 
            this.SearchLb.AutoSize = true;
            this.SearchLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLb.Location = new System.Drawing.Point(12, 50);
            this.SearchLb.Name = "SearchLb";
            this.SearchLb.Size = new System.Drawing.Size(62, 20);
            this.SearchLb.TabIndex = 30;
            this.SearchLb.Text = "Search";
            // 
            // SearchCB
            // 
            this.SearchCB.FormattingEnabled = true;
            this.SearchCB.Location = new System.Drawing.Point(80, 48);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(118, 24);
            this.SearchCB.TabIndex = 31;
            // 
            // SearchBt
            // 
            this.SearchBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchBt.Location = new System.Drawing.Point(395, 49);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(72, 25);
            this.SearchBt.TabIndex = 9;
            this.SearchBt.Text = "Find";
            this.SearchBt.UseVisualStyleBackColor = false;
            // 
            // DeleteBt
            // 
            this.DeleteBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBt.Location = new System.Drawing.Point(453, 556);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(71, 26);
            this.DeleteBt.TabIndex = 8;
            this.DeleteBt.Text = "Delete";
            this.DeleteBt.UseVisualStyleBackColor = false;
            // 
            // AddBt
            // 
            this.AddBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBt.Location = new System.Drawing.Point(12, 556);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(72, 26);
            this.AddBt.TabIndex = 9;
            this.AddBt.Text = "Add";
            this.AddBt.UseVisualStyleBackColor = false;
            // 
            // EditBt
            // 
            this.EditBt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditBt.Location = new System.Drawing.Point(226, 556);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(72, 26);
            this.EditBt.TabIndex = 9;
            this.EditBt.Text = "Edit";
            this.EditBt.UseVisualStyleBackColor = false;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 602);
            this.Controls.Add(this.SearchCB);
            this.Controls.Add(this.DetailGB);
            this.Controls.Add(this.SearchLb);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.DataShow);
            this.Controls.Add(this.SearchBt);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.DeleteBt);
            this.Name = "ControlForm";
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).EndInit();
            this.DetailGB.ResumeLayout(false);
            this.DetailGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataShow;
        private System.Windows.Forms.GroupBox DetailGB;
        private System.Windows.Forms.DateTimePicker DateTripTb;
        private System.Windows.Forms.TextBox DriverIDTb;
        private System.Windows.Forms.Label DriverID;
        private System.Windows.Forms.TextBox DiscountTb;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox TotalSeatTb;
        private System.Windows.Forms.Label TotalSLabel;
        private System.Windows.Forms.TextBox ArrivalTimeTb;
        private System.Windows.Forms.Label ArrivalLabel;
        private System.Windows.Forms.TextBox StartTimeTb;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.TextBox SourceTb;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Label SearchLb;
        private System.Windows.Forms.ComboBox SearchCB;
        private System.Windows.Forms.Button SearchBt;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button EditBt;
    }
}