using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        CardDeck c = new CardDeck();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Shuffle();
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(c.Deal().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Practice p = new Practice();
            listBox1.Items.Clear();
            foreach (int item in p.Sort())
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
