namespace HelloWorld
{
	partial class Window1
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
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(124, 66);
			this.comboBox1.Margin = new Wisej.Web.Padding(9, 0, 9, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(297, 45);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBox1.Watermark = "Pick a location";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(124, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(297, 98);
			this.button1.TabIndex = 2;
			this.button1.Text = "Hello World!";
			this.button1.Anchor = Wisej.Web.AnchorStyles.None;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Window1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 373);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new Wisej.Web.Padding(9, 0, 9, 0);
			this.MinimizeBox = false;
			this.Name = "Window1";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Window1";
			this.Load += new System.EventHandler(this.Window1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.ComboBox comboBox1;
		private Wisej.Web.Button button1;
	}
}

