using System;
using System.Windows.Forms;
using static System.Console;

namespace ChessGame
{
    public partial class Form1 : Form
    {
        ChessBoard b = new ChessBoard();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            King k = new King(Color.eBLACK, b.GetSquare(4, 4));
            drawBoard();

        }
        private void drawBoard()
        {
            pictureBox29.Image = b.GetSquare(4, 4).GetChessPiece().m_image;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
