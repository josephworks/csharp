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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Power:";
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(83, 32);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(95, 17);
            this.ChannelLabel.TabIndex = 4;
            this.ChannelLabel.Text = "ChannelLabel";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(83, 49);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(90, 17);
            this.VolumeLabel.TabIndex = 5;
            this.VolumeLabel.Text = "VolumeLabel";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(83, 66);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(82, 17);
            this.PowerLabel.TabIndex = 6;
            this.PowerLabel.Text = "PowerLabel";
            // 
            // ChannelUp
            // 
            this.ChannelUp.Location = new System.Drawing.Point(184, 29);
            this.ChannelUp.Name = "ChannelUp";
            this.ChannelUp.Size = new System.Drawing.Size(99, 23);
            this.ChannelUp.TabIndex = 7;
            this.ChannelUp.Text = "Channel Up";
            this.ChannelUp.UseVisualStyleBackColor = true;
            // 
            // ChannelDown
            // 
            this.ChannelDown.Location = new System.Drawing.Point(289, 29);
            this.ChannelDown.Name = "ChannelDown";
            this.ChannelDown.Size = new System.Drawing.Size(111, 23);
            this.ChannelDown.TabIndex = 8;
            this.ChannelDown.Text = "Channel Down";
            this.ChannelDown.UseVisualStyleBackColor = true;
            // 
            // VolumeUp
            // 
            this.VolumeUp.Location = new System.Drawing.Point(184, 49);
            this.VolumeUp.Name = "VolumeUp";
            this.VolumeUp.Size = new System.Drawing.Size(99, 23);
            this.VolumeUp.TabIndex = 9;
            this.VolumeUp.Text = "Volume Up";
            this.VolumeUp.UseVisualStyleBackColor = true;
            // 
            // VolumeDown
            // 
            this.VolumeDown.Location = new System.Drawing.Point(290, 48);
            this.VolumeDown.Name = "VolumeDown";
            this.VolumeDown.Size = new System.Drawing.Size(110, 23);
            this.VolumeDown.TabIndex = 10;
            this.VolumeDown.Text = "VolumeDown";
            this.VolumeDown.UseVisualStyleBackColor = true;
            // 
            // PowerButton
            // 
            this.PowerButton.Location = new System.Drawing.Point(184, 78);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(75, 23);
            this.PowerButton.TabIndex = 11;
            this.PowerButton.Text = "Power";
            this.PowerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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

