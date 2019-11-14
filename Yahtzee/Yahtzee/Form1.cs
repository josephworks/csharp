using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        SetOfDice s = new SetOfDice();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
                s.keep(0);
            if (checkBox2.Checked)
                s.keep(1);
            if (checkBox3.Checked)
                s.keep(2);
            if (checkBox4.Checked)
                s.keep(3);
            if (checkBox5.Checked)
                s.keep(4);
            s.Roll();
            textBox1.Text = s.getvalue(0).ToString();
            textBox2.Text = s.getvalue(1).ToString();
            textBox3.Text = s.getvalue(2).ToString();
            textBox4.Text = s.getvalue(3).ToString();
            textBox5.Text = s.getvalue(4).ToString();
            textBox6.Text = s.ToString();
            if (s.HasThreeOfAKind())
                this.BackColor = Color.Aqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.reset();
        }
    }
}
