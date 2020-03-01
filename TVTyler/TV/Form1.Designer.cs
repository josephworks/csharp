namespace TV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volupbutton = new System.Windows.Forms.Button();
            this.voldownbutton = new System.Windows.Forms.Button();
            this.chanupbutton = new System.Windows.Forms.Button();
            this.chandownbutton = new System.Windows.Forms.Button();
            this.prevbutton = new System.Windows.Forms.Button();
            this.chansetbutton = new System.Windows.Forms.Button();
            this.chantextBox = new System.Windows.Forms.TextBox();
            this.mutebutton = new System.Windows.Forms.Button();
            this.powerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.volumelabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::TV.Properties.Resources._36190303rickandmorty1280_1553711361899;
            this.pictureBox1.Location = new System.Drawing.Point(90, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // volupbutton
            // 
            this.volupbutton.Location = new System.Drawing.Point(644, 91);
            this.volupbutton.Name = "volupbutton";
            this.volupbutton.Size = new System.Drawing.Size(89, 23);
            this.volupbutton.TabIndex = 1;
            this.volupbutton.Text = "Volume Up";
            this.volupbutton.UseVisualStyleBackColor = true;
            this.volupbutton.Click += new System.EventHandler(this.volupbutton_Click);
            // 
            // voldownbutton
            // 
            this.voldownbutton.Location = new System.Drawing.Point(644, 136);
            this.voldownbutton.Name = "voldownbutton";
            this.voldownbutton.Size = new System.Drawing.Size(89, 23);
            this.voldownbutton.TabIndex = 2;
            this.voldownbutton.Text = "Volume Down";
            this.voldownbutton.UseVisualStyleBackColor = true;
            this.voldownbutton.Click += new System.EventHandler(this.voldownbutton_Click);
            // 
            // chanupbutton
            // 
            this.chanupbutton.Location = new System.Drawing.Point(644, 186);
            this.chanupbutton.Name = "chanupbutton";
            this.chanupbutton.Size = new System.Drawing.Size(89, 23);
            this.chanupbutton.TabIndex = 3;
            this.chanupbutton.Text = "Channel Up";
            this.chanupbutton.UseVisualStyleBackColor = true;
            this.chanupbutton.Click += new System.EventHandler(this.chanupbutton_Click);
            // 
            // chandownbutton
            // 
            this.chandownbutton.Location = new System.Drawing.Point(644, 234);
            this.chandownbutton.Name = "chandownbutton";
            this.chandownbutton.Size = new System.Drawing.Size(89, 23);
            this.chandownbutton.TabIndex = 4;
            this.chandownbutton.Text = "Channel Down";
            this.chandownbutton.UseVisualStyleBackColor = true;
            this.chandownbutton.Click += new System.EventHandler(this.chandownbutton_Click);
            // 
            // prevbutton
            // 
            this.prevbutton.Location = new System.Drawing.Point(644, 286);
            this.prevbutton.Name = "prevbutton";
            this.prevbutton.Size = new System.Drawing.Size(89, 23);
            this.prevbutton.TabIndex = 5;
            this.prevbutton.Text = "Previous";
            this.prevbutton.UseVisualStyleBackColor = true;
            this.prevbutton.Click += new System.EventHandler(this.prevbutton_Click);
            // 
            // chansetbutton
            // 
            this.chansetbutton.Location = new System.Drawing.Point(644, 331);
            this.chansetbutton.Name = "chansetbutton";
            this.chansetbutton.Size = new System.Drawing.Size(89, 23);
            this.chansetbutton.TabIndex = 6;
            this.chansetbutton.Text = "Set Channel";
            this.chansetbutton.UseVisualStyleBackColor = true;
            this.chansetbutton.Click += new System.EventHandler(this.chansetbutton_Click);
            // 
            // chantextBox
            // 
            this.chantextBox.Location = new System.Drawing.Point(644, 374);
            this.chantextBox.Name = "chantextBox";
            this.chantextBox.Size = new System.Drawing.Size(100, 20);
            this.chantextBox.TabIndex = 7;
            // 
            // mutebutton
            // 
            this.mutebutton.Location = new System.Drawing.Point(644, 48);
            this.mutebutton.Name = "mutebutton";
            this.mutebutton.Size = new System.Drawing.Size(89, 23);
            this.mutebutton.TabIndex = 8;
            this.mutebutton.Text = "Mute";
            this.mutebutton.UseVisualStyleBackColor = true;
            this.mutebutton.Click += new System.EventHandler(this.mutebutton_Click);
            // 
            // powerbutton
            // 
            this.powerbutton.Location = new System.Drawing.Point(242, 331);
            this.powerbutton.Name = "powerbutton";
            this.powerbutton.Size = new System.Drawing.Size(89, 23);
            this.powerbutton.TabIndex = 9;
            this.powerbutton.Text = "Power";
            this.powerbutton.UseVisualStyleBackColor = true;
            this.powerbutton.Click += new System.EventHandler(this.powerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume:";
            // 
            // volumelabel
            // 
            this.volumelabel.AutoSize = true;
            this.volumelabel.Location = new System.Drawing.Point(290, 390);
            this.volumelabel.Name = "volumelabel";
            this.volumelabel.Size = new System.Drawing.Size(13, 13);
            this.volumelabel.TabIndex = 11;
            this.volumelabel.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "36190303rickandmorty1280-1553711361899.jpg");
            this.imageList1.Images.SetKeyName(1, "fox-scoreboard.png");
            this.imageList1.Images.SetKeyName(2, "f9fec31e-6521-448d-a610-c52558170ed7.jpeg");
            this.imageList1.Images.SetKeyName(3, "maxresdefault.jpg");
            this.imageList1.Images.SetKeyName(4, "maxresdefault (1).jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volumelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerbutton);
            this.Controls.Add(this.mutebutton);
            this.Controls.Add(this.chantextBox);
            this.Controls.Add(this.chansetbutton);
            this.Controls.Add(this.prevbutton);
            this.Controls.Add(this.chandownbutton);
            this.Controls.Add(this.chanupbutton);
            this.Controls.Add(this.voldownbutton);
            this.Controls.Add(this.volupbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "TV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button volupbutton;
        private System.Windows.Forms.Button voldownbutton;
        private System.Windows.Forms.Button chanupbutton;
        private System.Windows.Forms.Button chandownbutton;
        private System.Windows.Forms.Button prevbutton;
        private System.Windows.Forms.Button chansetbutton;
        private System.Windows.Forms.TextBox chantextBox;
        private System.Windows.Forms.Button mutebutton;
        private System.Windows.Forms.Button powerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label volumelabel;
        private System.Windows.Forms.ImageList imageList1;
    }
}

