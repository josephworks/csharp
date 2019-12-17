using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Console;

namespace ChessGame
{
    public partial class Form1 : Form
    {
        ChessBoard b;
        PictureBox[,] pictureBoxes = new PictureBox[8, 8];
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
            drawBoard();

        }
        private void LoadBoard()
        {
            b = new ChessBoard(pictureBoxes);
            int i = 0, j = 0;
            foreach (Control x in this.Controls)
            {

                if (j == 8)
                {
                    i++;
                    j = 0;
                }
                if (i == 8)
                {
                    break;
                }
                if (x is PictureBox)
                {
                    pictureBoxes[i, j] = (PictureBox)x;
                }
                j++;
            }
        }
        private Bitmap MergedBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            Bitmap result = new Bitmap(Math.Max(bmp1.Width, bmp2.Width), Math.Max(bmp1.Height, bmp2.Height));
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp2, Point.Empty);
                g.DrawImage(bmp1, Point.Empty);
            }
            return result;
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
