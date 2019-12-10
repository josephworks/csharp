using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Console;

namespace ChessGame
{
    public partial class Form1 : Form
    {
        ChessBoard b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBoard();
            King k1 = new King(Color.eBLACK, b.GetSquare(4, 7));
            King k2 = new King(Color.eBLACK, b.GetSquare(4, 6));
            King k3 = new King(Color.eBLACK, b.GetSquare(4, 5));
            King k4 = new King(Color.eBLACK, b.GetSquare(4, 4));
            foreach (ChessSquare s in b.GetSquare(4,4).GetChessPiece().GetSquares())
            {
              
            }
            drawBoard();

        }
        private void LoadBoard()
        {
            PictureBox[,] pictureBoxes = new PictureBox[8, 8];
            pictureBoxes[0, 0] = pictureBox1;
            
        }
        private Bitmap MergedBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            Bitmap result = new Bitmap(Math.Max(bmp1.Width, bmp2.Width), Math.Max(bmp1.Height, bmp2.Height));
            using (Graphics g = Graphics.FromImage(result)) 
            {
                g.DrawImage(bmp2, Point.Empty);
                g.DrawImage(bmp1, Point.Empty);
            } return result;
        }
        private void drawBoard()
        {
            pictureBox26.Image = b.GetSquare(4, 7).GetChessPiece().m_image;
            pictureBox27.Image = b.GetSquare(4, 6).GetChessPiece().m_image;
            pictureBox28.Image = b.GetSquare(4, 5).GetChessPiece().m_image;
            pictureBox29.Image = b.GetSquare(4, 4).GetChessPiece().m_image;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
