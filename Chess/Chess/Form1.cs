using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
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
            foreach (ChessSquare s in b.GetSquare(4, 4).GetChessPiece().GetSquares())
            {

            }
            drawBoard();

        }
        private void LoadBoard()
        {
            PictureBox[,] pictureBoxes = new PictureBox[8, 8];
            pictureBoxes[0, 0] = pictureBox1;
            pictureBoxes[0, 1] = pictureBox2;
            pictureBoxes[0, 2] = pictureBox3;
            pictureBoxes[0, 3] = pictureBox4;
            pictureBoxes[0, 4] = pictureBox5;
            pictureBoxes[0, 5] = pictureBox6;
            pictureBoxes[0, 6] = pictureBox7;
            pictureBoxes[0, 7] = pictureBox8;

            pictureBoxes[1, 0] = pictureBox9;
            pictureBoxes[1, 1] = pictureBox10;
            pictureBoxes[1, 2] = pictureBox11;
            pictureBoxes[1, 3] = pictureBox12;
            pictureBoxes[1, 4] = pictureBox13;
            pictureBoxes[1, 5] = pictureBox14;
            pictureBoxes[1, 6] = pictureBox15;
            pictureBoxes[1, 7] = pictureBox16;

            pictureBoxes[2, 0] = pictureBox17;
            pictureBoxes[2, 1] = pictureBox18;
            pictureBoxes[2, 2] = pictureBox19;
            pictureBoxes[2, 3] = pictureBox20;
            pictureBoxes[2, 4] = pictureBox21;
            pictureBoxes[2, 5] = pictureBox22;
            pictureBoxes[2, 6] = pictureBox23;
            pictureBoxes[2, 7] = pictureBox24;

            pictureBoxes[3, 0] = pictureBox25;
            pictureBoxes[3, 1] = pictureBox26;
            pictureBoxes[3, 2] = pictureBox27;
            pictureBoxes[3, 3] = pictureBox28;
            pictureBoxes[3, 4] = pictureBox29;
            pictureBoxes[3, 5] = pictureBox30;
            pictureBoxes[3, 6] = pictureBox31;
            pictureBoxes[3, 7] = pictureBox32;

            pictureBoxes[4, 0] = pictureBox33;
            pictureBoxes[4, 1] = pictureBox34;
            pictureBoxes[4, 2] = pictureBox35;
            pictureBoxes[4, 3] = pictureBox36;
            pictureBoxes[4, 4] = pictureBox37;
            pictureBoxes[4, 5] = pictureBox38;
            pictureBoxes[4, 6] = pictureBox39;
            pictureBoxes[4, 7] = pictureBox40;

            pictureBoxes[5, 0] = pictureBox41;
            pictureBoxes[5, 1] = pictureBox42;
            pictureBoxes[5, 2] = pictureBox43;
            pictureBoxes[5, 3] = pictureBox44;
            pictureBoxes[5, 4] = pictureBox45;
            pictureBoxes[5, 5] = pictureBox46;
            pictureBoxes[5, 6] = pictureBox47;
            pictureBoxes[5, 7] = pictureBox48;

            pictureBoxes[6, 0] = pictureBox49;
            pictureBoxes[6, 1] = pictureBox50;
            pictureBoxes[6, 2] = pictureBox51;
            pictureBoxes[6, 3] = pictureBox52;
            pictureBoxes[6, 4] = pictureBox53;
            pictureBoxes[6, 5] = pictureBox54;
            pictureBoxes[6, 6] = pictureBox55;
            pictureBoxes[6, 7] = pictureBox56;

            pictureBoxes[7, 0] = pictureBox57;
            pictureBoxes[7, 1] = pictureBox58;
            pictureBoxes[7, 2] = pictureBox59;
            pictureBoxes[7, 3] = pictureBox60;
            pictureBoxes[7, 4] = pictureBox61;
            pictureBoxes[7, 5] = pictureBox62;
            pictureBoxes[7, 6] = pictureBox63;
            pictureBoxes[7, 7] = pictureBox64;
            b = new ChessBoard(pictureBoxes);
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
    }
}
