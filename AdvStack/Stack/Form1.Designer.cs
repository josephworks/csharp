namespace Stack
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
            this.popbutton = new System.Windows.Forms.Button();
            this.pushbutton = new System.Windows.Forms.Button();
            this.peekbutton = new System.Windows.Forms.Button();
            this.sizebutton = new System.Windows.Forms.Button();
            this.pushtextBox = new System.Windows.Forms.TextBox();
            this.countlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // popbutton
            // 
            this.popbutton.Location = new System.Drawing.Point(84, 50);
            this.popbutton.Name = "popbutton";
            this.popbutton.Size = new System.Drawing.Size(75, 23);
            this.popbutton.TabIndex = 0;
            this.popbutton.Text = "Pop";
            this.popbutton.UseVisualStyleBackColor = true;
            this.popbutton.Click += new System.EventHandler(this.popbutton_Click);
            // 
            // pushbutton
            // 
            this.pushbutton.Location = new System.Drawing.Point(84, 79);
            this.pushbutton.Name = "pushbutton";
            this.pushbutton.Size = new System.Drawing.Size(75, 23);
            this.pushbutton.TabIndex = 1;
            this.pushbutton.Text = "Push";
            this.pushbutton.UseVisualStyleBackColor = true;
            this.pushbutton.Click += new System.EventHandler(this.pushbutton_Click);
            // 
            // peekbutton
            // 
            this.peekbutton.Location = new System.Drawing.Point(84, 108);
            this.peekbutton.Name = "peekbutton";
            this.peekbutton.Size = new System.Drawing.Size(75, 23);
            this.peekbutton.TabIndex = 2;
            this.peekbutton.Text = "Peek";
            this.peekbutton.UseVisualStyleBackColor = true;
            this.peekbutton.Click += new System.EventHandler(this.peekbutton_Click);
            // 
            // sizebutton
            // 
            this.sizebutton.Location = new System.Drawing.Point(84, 137);
            this.sizebutton.Name = "sizebutton";
            this.sizebutton.Size = new System.Drawing.Size(75, 23);
            this.sizebutton.TabIndex = 3;
            this.sizebutton.Text = "Size";
            this.sizebutton.UseVisualStyleBackColor = true;
            this.sizebutton.Click += new System.EventHandler(this.sizebutton_Click);
            // 
            // pushtextBox
            // 
            this.pushtextBox.Location = new System.Drawing.Point(180, 82);
            this.pushtextBox.Name = "pushtextBox";
            this.pushtextBox.Size = new System.Drawing.Size(100, 20);
            this.pushtextBox.TabIndex = 4;
            // 
            // countlabel
            // 
            this.countlabel.AutoSize = true;
            this.countlabel.Location = new System.Drawing.Point(352, 89);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(35, 13);
            this.countlabel.TabIndex = 5;
            this.countlabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countlabel);
            this.Controls.Add(this.pushtextBox);
            this.Controls.Add(this.sizebutton);
            this.Controls.Add(this.peekbutton);
            this.Controls.Add(this.pushbutton);
            this.Controls.Add(this.popbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button popbutton;
        private System.Windows.Forms.Button pushbutton;
        private System.Windows.Forms.Button peekbutton;
        private System.Windows.Forms.Button sizebutton;
        private System.Windows.Forms.TextBox pushtextBox;
        private System.Windows.Forms.Label countlabel;
    }
}

