namespace Dashboard
{
    partial class NewCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCar));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mpgTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capTB = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(344, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car make and model:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(469, 40);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(229, 37);
            this.toolStripLabel1.Text = "Create a new car";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton1.Text = "Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(177, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(280, 34);
            this.nameTB.TabIndex = 3;
            this.nameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miles Per Gallon:";
            // 
            // mpgTB
            // 
            this.mpgTB.Location = new System.Drawing.Point(177, 65);
            this.mpgTB.Name = "mpgTB";
            this.mpgTB.Size = new System.Drawing.Size(280, 34);
            this.mpgTB.TabIndex = 5;
            this.mpgTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tank Capacity:";
            // 
            // capTB
            // 
            this.capTB.Location = new System.Drawing.Point(177, 100);
            this.capTB.Name = "capTB";
            this.capTB.Size = new System.Drawing.Size(280, 34);
            this.capTB.TabIndex = 7;
            this.capTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 195);
            this.Controls.Add(this.capTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mpgTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "NewCar";
            this.Text = "New Car";
            this.Load += new System.EventHandler(this.NewCar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mpgTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capTB;
    }
}