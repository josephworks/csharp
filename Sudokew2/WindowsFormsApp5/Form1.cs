using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        TextBox[,] m_vals = new TextBox[9, 9];
        public Form1()
        {
            InitializeComponent();
            int r, c;
            GetRowCol(textBox21, out r, out c);
        }
        public void fillArray()
        {
            int r = 0;
            int c = 0;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    m_vals[r++, c] = (TextBox)x;
                    if (r == 8)
                    {
                        r = 0;
                        c++;
                    }
                }
            }
        }
        public void clearBoard()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
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
                int.TryParse(num.Substring(0, 1), out pos);
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
            Console.Beep();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new AboutBox());
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                clearBoard();
            }
        }
    }
}
