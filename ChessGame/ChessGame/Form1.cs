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
            Beep();
        }
    }
}
