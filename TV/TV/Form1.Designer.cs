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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.ChannelUp = new System.Windows.Forms.Button();
            this.ChannelDown = new System.Windows.Forms.Button();
            this.VolumeUp = new System.Windows.Forms.Button();
            this.VolumeDown = new System.Windows.Forms.Button();
            this.PowerButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Power:";
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(62, 26);
            this.ChannelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(72, 13);
            this.ChannelLabel.TabIndex = 4;
            this.ChannelLabel.Text = "ChannelLabel";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(62, 50);
            this.VolumeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(68, 13);
            this.VolumeLabel.TabIndex = 5;
            this.VolumeLabel.Text = "VolumeLabel";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(62, 75);
            this.PowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(63, 13);
            this.PowerLabel.TabIndex = 6;
            this.PowerLabel.Text = "PowerLabel";
            // 
            // ChannelUp
            // 
            this.ChannelUp.Location = new System.Drawing.Point(138, 24);
            this.ChannelUp.Margin = new System.Windows.Forms.Padding(2);
            this.ChannelUp.Name = "ChannelUp";
            this.ChannelUp.Size = new System.Drawing.Size(74, 19);
            this.ChannelUp.TabIndex = 7;
            this.ChannelUp.Text = "Channel Up";
            this.ChannelUp.UseVisualStyleBackColor = true;
            this.ChannelUp.Click += new System.EventHandler(this.ChannelUp_Click);
            // 
            // ChannelDown
            // 
            this.ChannelDown.Location = new System.Drawing.Point(215, 24);
            this.ChannelDown.Margin = new System.Windows.Forms.Padding(2);
            this.ChannelDown.Name = "ChannelDown";
            this.ChannelDown.Size = new System.Drawing.Size(89, 19);
            this.ChannelDown.TabIndex = 8;
            this.ChannelDown.Text = "Channel Down";
            this.ChannelDown.UseVisualStyleBackColor = true;
            this.ChannelDown.Click += new System.EventHandler(this.ChannelDown_Click);
            // 
            // VolumeUp
            // 
            this.VolumeUp.Location = new System.Drawing.Point(138, 47);
            this.VolumeUp.Margin = new System.Windows.Forms.Padding(2);
            this.VolumeUp.Name = "VolumeUp";
            this.VolumeUp.Size = new System.Drawing.Size(74, 19);
            this.VolumeUp.TabIndex = 9;
            this.VolumeUp.Text = "Volume Up";
            this.VolumeUp.UseVisualStyleBackColor = true;
            this.VolumeUp.Click += new System.EventHandler(this.VolumeUp_Click);
            // 
            // VolumeDown
            // 
            this.VolumeDown.Location = new System.Drawing.Point(215, 47);
            this.VolumeDown.Margin = new System.Windows.Forms.Padding(2);
            this.VolumeDown.Name = "VolumeDown";
            this.VolumeDown.Size = new System.Drawing.Size(89, 19);
            this.VolumeDown.TabIndex = 10;
            this.VolumeDown.Text = "VolumeDown";
            this.VolumeDown.UseVisualStyleBackColor = true;
            this.VolumeDown.Click += new System.EventHandler(this.VolumeDown_Click);
            // 
            // PowerButton
            // 
            this.PowerButton.Location = new System.Drawing.Point(138, 72);
            this.PowerButton.Margin = new System.Windows.Forms.Padding(2);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(159, 19);
            this.PowerButton.TabIndex = 11;
            this.PowerButton.Text = "Power";
            this.PowerButton.UseVisualStyleBackColor = true;
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 149);
            this.Controls.Add(this.PowerButton);
            this.Controls.Add(this.VolumeDown);
            this.Controls.Add(this.VolumeUp);
            this.Controls.Add(this.ChannelDown);
            this.Controls.Add(this.ChannelUp);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.ChannelLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "TVInterface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Button ChannelUp;
        private System.Windows.Forms.Button ChannelDown;
        private System.Windows.Forms.Button VolumeUp;
        private System.Windows.Forms.Button VolumeDown;
        private System.Windows.Forms.Button PowerButton;
    }
}

