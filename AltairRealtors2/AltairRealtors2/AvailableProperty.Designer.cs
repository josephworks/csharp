namespace AltairRealtors2
{
    partial class AvailableProperty
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
            this.txtPropertyNumber = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPropertyTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStates = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZIPCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarketValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property #:";
            // 
            // txtPropertyNumber
            // 
            this.txtPropertyNumber.Location = new System.Drawing.Point(107, 23);
            this.txtPropertyNumber.Name = "txtPropertyNumber";
            this.txtPropertyNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPropertyNumber.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(321, 202);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(402, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Property Type:";
            // 
            // cbxPropertyTypes
            // 
            this.cbxPropertyTypes.AccessibleDescription = "";
            this.cbxPropertyTypes.FormattingEnabled = true;
            this.cbxPropertyTypes.Items.AddRange(new object[] {
            "Unknown",
            "Single Family",
            "Townhouse",
            "Condominium"});
            this.cbxPropertyTypes.Location = new System.Drawing.Point(344, 23);
            this.cbxPropertyTypes.Name = "cbxPropertyTypes";
            this.cbxPropertyTypes.Size = new System.Drawing.Size(121, 21);
            this.cbxPropertyTypes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(107, 73);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(358, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(107, 112);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "State:";
            // 
            // cbxStates
            // 
            this.cbxStates.AccessibleDescription = "cbxPropertyTypes";
            this.cbxStates.FormattingEnabled = true;
            this.cbxStates.Items.AddRange(new object[] {
            "DC",
            "MD",
            "PA",
            "VA",
            "WV"});
            this.cbxStates.Location = new System.Drawing.Point(275, 112);
            this.cbxStates.Name = "cbxStates";
            this.cbxStates.Size = new System.Drawing.Size(52, 21);
            this.cbxStates.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ZIP Code:";
            // 
            // txtZIPCode
            // 
            this.txtZIPCode.Location = new System.Drawing.Point(402, 112);
            this.txtZIPCode.Name = "txtZIPCode";
            this.txtZIPCode.Size = new System.Drawing.Size(75, 20);
            this.txtZIPCode.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bedrooms:";
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Location = new System.Drawing.Point(86, 157);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(45, 20);
            this.txtBedrooms.TabIndex = 15;
            this.txtBedrooms.Text = "0";
            this.txtBedrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBathrooms
            // 
            this.txtBathrooms.Location = new System.Drawing.Point(234, 157);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.Size = new System.Drawing.Size(45, 20);
            this.txtBathrooms.TabIndex = 17;
            this.txtBathrooms.Text = "1.0";
            this.txtBathrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bathrooms:";
            // 
            // txtMarketValue
            // 
            this.txtMarketValue.Location = new System.Drawing.Point(96, 202);
            this.txtMarketValue.Name = "txtMarketValue";
            this.txtMarketValue.Size = new System.Drawing.Size(45, 20);
            this.txtMarketValue.TabIndex = 19;
            this.txtMarketValue.Text = "0.00";
            this.txtMarketValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Market Value:";
            // 
            // AvailableProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 238);
            this.Controls.Add(this.txtMarketValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBathrooms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBedrooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtZIPCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxStates);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPropertyTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPropertyNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AvailableProperty";
            this.ShowInTaskbar = false;
            this.Text = "Altair Realtors - Available Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPropertyNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbxPropertyTypes;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxStates;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtZIPCode;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtBedrooms;
        public System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtMarketValue;
        private System.Windows.Forms.Label label9;
    }
}