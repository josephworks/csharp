using System;
using System.Drawing;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        private SetOfDice s = new SetOfDice();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Linen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Linen;
            if (checkBox1.Checked)
                s.Keep(0);
            if (checkBox2.Checked)
                s.Keep(1);
            if (checkBox3.Checked)
                s.Keep(2);
            if (checkBox4.Checked)
                s.Keep(3);
            if (checkBox5.Checked)
                s.Keep(4);
            s.Roll();
            textBox1.Text = s.Getvalue(0).ToString();
            textBox2.Text = s.Getvalue(1).ToString();
            textBox3.Text = s.Getvalue(2).ToString();
            textBox4.Text = s.Getvalue(3).ToString();
            textBox5.Text = s.Getvalue(4).ToString();
            textBox6.Text = s.ToString();
            if (s.HasThreeOfAKind())
                this.BackColor = Color.Aqua;
            if (s.HasFourOfAKind())
                this.BackColor = Color.Blue;
            if (s.HasFiveOfAKind())
                this.BackColor = Color.CadetBlue;
            if (s.HasFullHouse())
                this.BackColor = Color.Aquamarine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.Reset();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show(this);
        }
    }
}