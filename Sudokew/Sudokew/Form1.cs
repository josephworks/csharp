using System;
using System.Windows.Forms;

namespace Sudokew
{
    public partial class Form1 : Form
    {
        TextBox[,] m_vals = new TextBox[9, 9];
        public Form1()
        {
            InitializeComponent();
            fillArray();
            Console.Beep();
        }
        // Connect text boxes to array
        public void fillArray()
        {
            int r = 0;
            int c = 0;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    GetRowCol((TextBox) x,out r,out c);
                    m_vals[r, c] = (TextBox)x;
                }
            }
        }
        public void clearBoard()
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    m_vals[i, j].Text = "";
                }
            }
        }
        public void GetRowCol(TextBox c, out int row, out int col)
        {
            string n = c.Name;
            string num = n.Substring(n.Length - 2);
            int pos;
            int.TryParse(num, out pos);
            if (pos == 0)
            {
                int.TryParse(num.Substring(1, 1), out pos);
            }
            pos--;
            row = pos / 9;
            col = pos % 9;
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new AboutBox());
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            clearBoard();
        }

        int getVal(int r, int c)
        {
            if (m_vals[r, c].Text == "")
                return 0;
            int v = 0;
            v = int.Parse(m_vals[r, c].Text);
            return v;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // Don't do anything if it's empty
            if (((TextBox)sender).Text == "")
                return;

            int row;
            int col;
            string val = ((TextBox)sender).Text;
            GetRowCol(((TextBox)sender), out row, out col);
            //check row
            int[] bro = new int[9];
            for (int i = 0; i < 9; i++)
            {
                bro[i] = getVal(row, i);
            }
            Sudoku r = new Sudoku(bro);

            //check column
            int[] orb = new int[9];
            for (int i = 0; i < 9; i++)
            {
                orb[i] = getVal(i, col);
            }
            Sudoku c = new Sudoku(orb);

            //check square
            int[] sq = new int[9];
            int x = row / 3;
            int y = col / 3;
            int z = 0;
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    sq[z++] = getVal(i, j);
                }
            }
            Sudoku s = new Sudoku(sq);

            if (r.isValid() && c.isValid() && s.isValid())
            {
                //its valid
            }
            else
            {
                ((TextBox)sender).Text = "";
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearBoard();
        }
    }
}
