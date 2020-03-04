namespace AltairRealtors2
{
    partial class AltairRealtor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvwProperties = new System.Windows.Forms.ListView();
            this.colPropertyNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPropertyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZIPCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBedrooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBathrooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarketValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewProperty = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altair Realtors - Properties Listing";
            // 
            // lvwProperties
            // 
            this.lvwProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPropertyNumber,
            this.colPropertyType,
            this.colAddress,
            this.colCity,
            this.colState,
            this.colZIPCode,
            this.colBedrooms,
            this.colBathrooms,
            this.colMarketValue});
            this.lvwProperties.FullRowSelect = true;
            this.lvwProperties.GridLines = true;
            this.lvwProperties.HideSelection = false;
            this.lvwProperties.Location = new System.Drawing.Point(13, 57);
            this.lvwProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwProperties.Name = "lvwProperties";
            this.lvwProperties.Size = new System.Drawing.Size(1050, 329);
            this.lvwProperties.TabIndex = 1;
            this.lvwProperties.UseCompatibleStateImageBehavior = false;
            this.lvwProperties.View = System.Windows.Forms.View.Details;
            this.lvwProperties.DoubleClick += new System.EventHandler(this.lvwProperties_DoubleClick);
            // 
            // colPropertyNumber
            // 
            this.colPropertyNumber.Text = "Prop #";
            this.colPropertyNumber.Width = 82;
            // 
            // colPropertyType
            // 
            this.colPropertyType.Text = "Property Type";
            this.colPropertyType.Width = 102;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 162;
            // 
            // colCity
            // 
            this.colCity.Text = "City";
            this.colCity.Width = 80;
            // 
            // colState
            // 
            this.colState.Text = "State";
            this.colState.Width = 76;
            // 
            // colZIPCode
            // 
            this.colZIPCode.Text = "ZIP Code";
            this.colZIPCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colZIPCode.Width = 91;
            // 
            // colBedrooms
            // 
            this.colBedrooms.Text = "Beds";
            this.colBedrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colBedrooms.Width = 40;
            // 
            // colBathrooms
            // 
            this.colBathrooms.Text = "Baths";
            this.colBathrooms.Width = 40;
            // 
            // colMarketValue
            // 
            this.colMarketValue.Text = "Market Value";
            this.colMarketValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colMarketValue.Width = 75;
            // 
            // btnNewProperty
            // 
            this.btnNewProperty.Location = new System.Drawing.Point(13, 394);
            this.btnNewProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewProperty.Name = "btnNewProperty";
            this.btnNewProperty.Size = new System.Drawing.Size(136, 28);
            this.btnNewProperty.TabIndex = 2;
            this.btnNewProperty.Text = "New Property...";
            this.btnNewProperty.UseVisualStyleBackColor = true;
            this.btnNewProperty.Click += new System.EventHandler(this.btnNewProperty_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(963, 394);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AltairRealtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 437);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewProperty);
            this.Controls.Add(this.lvwProperties);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AltairRealtor";
            this.Text = "Altair Realtors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwProperties;
        private System.Windows.Forms.ColumnHeader colPropertyNumber;
        private System.Windows.Forms.ColumnHeader colPropertyType;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colCity;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colZIPCode;
        private System.Windows.Forms.ColumnHeader colBedrooms;
        private System.Windows.Forms.ColumnHeader colBathrooms;
        private System.Windows.Forms.ColumnHeader colMarketValue;
        private System.Windows.Forms.Button btnNewProperty;
        private System.Windows.Forms.Button btnClose;
    }
}

