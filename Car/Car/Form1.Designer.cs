namespace Car
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
            this.fillbutton = new System.Windows.Forms.Button();
            this.filltextBox = new System.Windows.Forms.TextBox();
            this.drivetextBox = new System.Windows.Forms.TextBox();
            this.drivebutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.odometerlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mpglabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.speedtextBox = new System.Windows.Forms.TextBox();
            this.speedbutton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fillbutton
            // 
            this.fillbutton.Location = new System.Drawing.Point(24, 30);
            this.fillbutton.Name = "fillbutton";
            this.fillbutton.Size = new System.Drawing.Size(75, 23);
            this.fillbutton.TabIndex = 0;
            this.fillbutton.Text = "Fill";
            this.fillbutton.UseVisualStyleBackColor = true;
            this.fillbutton.Click += new System.EventHandler(this.fillbutton_Click);
            // 
            // filltextBox
            // 
            this.filltextBox.Location = new System.Drawing.Point(117, 32);
            this.filltextBox.Name = "filltextBox";
            this.filltextBox.Size = new System.Drawing.Size(100, 20);
            this.filltextBox.TabIndex = 1;
            // 
            // drivetextBox
            // 
            this.drivetextBox.Location = new System.Drawing.Point(117, 70);
            this.drivetextBox.Name = "drivetextBox";
            this.drivetextBox.Size = new System.Drawing.Size(100, 20);
            this.drivetextBox.TabIndex = 3;
            // 
            // drivebutton
            // 
            this.drivebutton.Location = new System.Drawing.Point(24, 68);
            this.drivebutton.Name = "drivebutton";
            this.drivebutton.Size = new System.Drawing.Size(75, 23);
            this.drivebutton.TabIndex = 2;
            this.drivebutton.Text = "Drive";
            this.drivebutton.UseVisualStyleBackColor = true;
            this.drivebutton.Click += new System.EventHandler(this.drivebutton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(713, 36);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(33, 13);
            this.namelabel.TabIndex = 7;
            this.namelabel.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gas:";
            // 
            // odometerlabel
            // 
            this.odometerlabel.AutoSize = true;
            this.odometerlabel.Location = new System.Drawing.Point(228, 393);
            this.odometerlabel.Name = "odometerlabel";
            this.odometerlabel.Size = new System.Drawing.Size(26, 13);
            this.odometerlabel.TabIndex = 11;
            this.odometerlabel.Text = "0 mi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Odometer:";
            // 
            // mpglabel
            // 
            this.mpglabel.AutoSize = true;
            this.mpglabel.Location = new System.Drawing.Point(713, 85);
            this.mpglabel.Name = "mpglabel";
            this.mpglabel.Size = new System.Drawing.Size(36, 13);
            this.mpglabel.TabIndex = 13;
            this.mpglabel.Text = "0 mpg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gas Mileage:";
            // 
            // speedtextBox
            // 
            this.speedtextBox.Location = new System.Drawing.Point(117, 110);
            this.speedtextBox.Name = "speedtextBox";
            this.speedtextBox.Size = new System.Drawing.Size(100, 20);
            this.speedtextBox.TabIndex = 15;
            // 
            // speedbutton
            // 
            this.speedbutton.Location = new System.Drawing.Point(24, 108);
            this.speedbutton.Name = "speedbutton";
            this.speedbutton.Size = new System.Drawing.Size(75, 23);
            this.speedbutton.TabIndex = 14;
            this.speedbutton.Text = "Set Speed";
            this.speedbutton.UseVisualStyleBackColor = true;
            this.speedbutton.Click += new System.EventHandler(this.speedbutton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(411, 378);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car.Properties.Resources._105_6789_cb;
            this.pictureBox1.Location = new System.Drawing.Point(304, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(406, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 45);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.speedtextBox);
            this.Controls.Add(this.speedbutton);
            this.Controls.Add(this.mpglabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.odometerlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drivetextBox);
            this.Controls.Add(this.drivebutton);
            this.Controls.Add(this.filltextBox);
            this.Controls.Add(this.fillbutton);
            this.Name = "Form1";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fillbutton;
        private System.Windows.Forms.TextBox filltextBox;
        private System.Windows.Forms.TextBox drivetextBox;
        private System.Windows.Forms.Button drivebutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label odometerlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mpglabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox speedtextBox;
        private System.Windows.Forms.Button speedbutton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

