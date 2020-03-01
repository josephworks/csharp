using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int score = 0;
        SetofDice s = new SetofDice();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Form1.DefaultBackColor;
            if (checkBox1.Checked) s.Keep(0);
            if (checkBox2.Checked) s.Keep(1);
            if (checkBox3.Checked) s.Keep(2);
            if (checkBox4.Checked) s.Keep(3);
            if (checkBox5.Checked) s.Keep(4);
            s.Roll();
            pictureBox1.Image = imageList1.Images[s.getValue(0) - 1];
            pictureBox2.Image = imageList1.Images[s.getValue(1) - 1];
            pictureBox3.Image = imageList1.Images[s.getValue(2) - 1];
            pictureBox4.Image = imageList1.Images[s.getValue(3) - 1];
            pictureBox5.Image = imageList1.Images[s.getValue(4) - 1];
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
        }

        private void Reset()
        {
            this.BackColor = Form1.DefaultBackColor;
            s.Reset();
            totaltextBox.Text = score.ToString();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
            }
            else
            {
                checkBox5.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (s.threeOfaKind())
            {
                score += s.score();
                threeofakindtextBox.Text = s.score().ToString();
            }
            else
            {
                threeofakindtextBox.Text = "0";
            }
            threeofakindbutton.Enabled = false;
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s.fourOfaKind())
            {
                score += s.score();
                fourofakindtextBox.Text = s.score().ToString();
            }
            else
            {
                fourofakindtextBox.Text = "0";
            }
            fourofakindbutton.Enabled = false;
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s.fullHouse())
            {
                score += 25;
                fhousetextBox.Text = "25";
            }
            else
            {
                fhousetextBox.Text = "0";
            }
            fhousebutton.Enabled = false;
            Reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s.smallStraight())
            {
                score += 40;
                sstraighttextBox.Text = "40";
            }
            else
            {
                sstraighttextBox.Text = "0";
            }
            sstraightbutton.Enabled = false;
            Reset();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (s.smallStraight())
            {
                score += 50;
                lstraighttextBox.Text = "50";
            }
            else
            {
                lstraighttextBox.Text = "0";
            }
            lstraightbutton.Enabled = false;
            Reset();
        }

        private void chancebutton_Click(object sender, EventArgs e)
        {
            score += s.score();
            chancetextBox.Text = s.score().ToString();
            chancebutton.Enabled = false;
            Reset();
        }

        private void yahtzeebutton_Click(object sender, EventArgs e)
        {
            if (s.Yahtzee())
            {
                score += 50;
                yahtzeetextBox.Text = "50";
            }
            else
            {
                yahtzeetextBox.Text = "0";
            }
            yahtzeebutton.Enabled = false;
            Reset();
        }
    }
}
