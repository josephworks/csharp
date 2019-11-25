namespace ChessGame
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bishop_Black.gif");
            this.imageList1.Images.SetKeyName(1, "Bishop_White.gif");
            this.imageList1.Images.SetKeyName(2, "King_Black.gif");
            this.imageList1.Images.SetKeyName(3, "King_White.gif");
            this.imageList1.Images.SetKeyName(4, "Knight_Black.gif");
            this.imageList1.Images.SetKeyName(5, "Knight_White.gif");
            this.imageList1.Images.SetKeyName(6, "Pawn_Black.gif");
            this.imageList1.Images.SetKeyName(7, "Pawn_White.gif");
            this.imageList1.Images.SetKeyName(8, "Queen_Black.gif");
            this.imageList1.Images.SetKeyName(9, "Queen_White.gif");
            this.imageList1.Images.SetKeyName(10, "Rook_Black.gif");
            this.imageList1.Images.SetKeyName(11, "Rook_White.gif");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
    }
}

