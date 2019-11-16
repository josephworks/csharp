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
            BackColor = Color.Linen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar2.Value = 0;
            toolStripProgressBar3.Value = 0;
            toolStripProgressBar4.Value = 0;
            toolStripProgressBar5.Value = 0;
            BackColor = Color.Linen;
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
            {
                BackColor = Color.Aqua;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
            }

            if (s.HasFourOfAKind())
            {
                BackColor = Color.Blue;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
            }

            if (s.HasFiveOfAKind())
            {
                BackColor = Color.CadetBlue;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
                toolStripProgressBar5.Value = 100;
            }

            if (s.HasFullHouse())
            {
                BackColor = Color.Aquamarine;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar5.Value = 100;
            }

            if (s.HasLargeStraight())
            {
                BackColor = Color.DeepSkyBlue;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
            }
            if (s.HasYahtzee())
            {
                BackColor = Color.White;
                Console.Beep();
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
                toolStripProgressBar5.Value = 100;
                BackColor = Color.Black;
                Console.Beep();
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar2.Value = 0;
                toolStripProgressBar3.Value = 0;
                toolStripProgressBar4.Value = 0;
                toolStripProgressBar5.Value = 0;
                BackColor = Color.White;
                Console.Beep();
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
                toolStripProgressBar5.Value = 100;
                BackColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
            s.Reset();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            //clear dice numbers
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar2.Value = 0;
            toolStripProgressBar3.Value = 0;
            toolStripProgressBar4.Value = 0;
            toolStripProgressBar5.Value = 0;
            BackColor = Color.Linen;
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
            {
                BackColor = Color.Aqua;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
            }

            if (s.HasFourOfAKind())
            {
                BackColor = Color.Blue;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
            }

            if (s.HasFiveOfAKind())
            {
                BackColor = Color.CadetBlue;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
                toolStripProgressBar5.Value = 100;
            }

            if (s.HasFullHouse())
            {
                BackColor = Color.Aquamarine;
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar5.Value = 100;
            }

            if (s.HasLargeStraight())
            {
                BackColor = Color.DeepSkyBlue;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
            }
            if (s.HasYahtzee())
            {
                BackColor = Color.White;
                Console.Beep();
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
                toolStripProgressBar5.Value = 100;
                BackColor = Color.Black;
                Console.Beep();
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar2.Value = 0;
                toolStripProgressBar3.Value = 0;
                toolStripProgressBar4.Value = 0;
                toolStripProgressBar5.Value = 0;
                BackColor = Color.White;
                Console.Beep();
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar2.Value = 100;
                toolStripProgressBar3.Value = 100;
                toolStripProgressBar4.Value = 100;
                toolStripProgressBar5.Value = 100;
                BackColor = Color.Black;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
            s.Reset();
        }
    }
}