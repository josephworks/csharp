using System;
using System.Windows.Forms;

namespace DBTest
{
    public partial class Form1 : Form
    {
        ComboBox[,] m_vals = new ComboBox[9, 9];
        public Form1()
        {
            InitializeComponent();
            foreach (System.Windows.Forms.Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is System.Windows.Forms.ComboBox)
                {
                    ((System.Windows.Forms.ComboBox)c).SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
                }
            }
            fillArray();
            Generate();
        }


        public void fillArray()
        {
            int r = 0;
            int c = 0;

            foreach (Control ctl in tableLayoutPanel1.Controls)
            {
                if (ctl is ComboBox)
                {
                    getRowCol((ComboBox)ctl, out r, out c);
                    m_vals[r, c] = (ComboBox)ctl;
                }
            }
        }

        public void Generate()
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(25, 51); i++)
            {
                ComboBox c = m_vals[r.Next(0, 9), r.Next(0, 9)];
                if (c.SelectedIndex < 0)
                {
                    c.SelectedIndex = r.Next(0, 9);
                    if (setNumber(c)) { c.Enabled = false; }
                }
            }
        }

        public bool isValid(int row, int col, int val)
        {
            SudokuClass testRow = new SudokuClass(getRow(row, col));
            SudokuClass testCol = new SudokuClass(getCol(row, col));
            SudokuClass testSquare = new SudokuClass(getSquare(row, col));
            return testRow.place(val) && testCol.place(val) && testSquare.place(val);
        }

        public int[] getRow(int row, int col)
        {
            int[] nums = new int[9];
            for (int i = 0; i < 9; i++)
            {
                int result;
                int.TryParse(m_vals[row, i].Text, out result);
                nums[i] = result;
            }
            return nums;
        }

        public int[] getCol(int row, int col)
        {
            int[] nums = new int[9];
            for (int i = 0; i < 9; i++)
            {
                int result;
                int.TryParse(m_vals[i, col].Text, out result);
                nums[i] = result;
            }
            return nums;
        }

        public int[] getSquare(int row, int col)
        {
            int[] nums = new int[9];
            int r_ind = row / 3;
            int c_ind = col / 3;
            int count = 0;
            for (int i = r_ind * 3; i < r_ind * 3 + 3; i++)
            {
                for (int j = c_ind * 3; j < c_ind * 3 + 3; j++)
                {
                    int result;
                    int.TryParse(m_vals[i, j].Text, out result);
                    nums[count++] = result;
                }
            }
            return nums;
        }
        public void getRowCol(ComboBox c, out int row, out int col)
        {
            int pos;
            getVal(c, out pos);
            pos--;
            row = pos / 9;
            col = pos % 9;
        }

        public void getVal(ComboBox c, out int pos)
        {
            string n = c.Name.Substring(c.Name.Length - 2);
            int p;
            int.TryParse(n, out p);
            if (p == 0)
            {
                n = c.Name.Substring(c.Name.Length - 1);
                int.TryParse(n, out p);
            }
            pos = p;
        }

        public void ClearBoard()
        {
            comboBox1.Text = "";
            foreach (Control ctl in tableLayoutPanel1.Controls)
            {
                if (ctl is ComboBox)
                {
                    ComboBox c = (ComboBox)ctl;
                    c.SelectedIndex = -1;
                    c.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = true;
            ClearBoard();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setNumber(sender);
            if (checkIfFin())
            {
                tableLayoutPanel1.Enabled = false;
                DialogResult res = MessageBox.Show("Congratulations, you beat the puzzle! Do you want to play again?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    button2_Click(sender, e);
                }


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            Generate();
        }

        private bool setNumber(object sender)
        {
            if (((ComboBox)sender).SelectedIndex > -1)
            {
                int row;
                int col;
                string val = ((ComboBox)sender).Text;
                getRowCol((ComboBox)sender, out row, out col);

                if (isValid(row, col, int.Parse(((ComboBox)sender).Text)))
                {
                    return true;
                }
                else
                {
                    ((ComboBox)sender).SelectedIndex = -1;
                    return false;
                }

            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (ComboBox item in m_vals)
            {
                if (item.Enabled)
                {
                    item.SelectedIndex = -1;
                }
            }
        }

        private bool checkIfFin()
        {
            foreach (ComboBox item in m_vals)
            {
                if (item.SelectedIndex < 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (ComboBox item in m_vals)
            {
                item.SelectedIndex = 1;
            }
            comboBox1_SelectedIndexChanged(m_vals[0,0], e);
        }
    }
}
