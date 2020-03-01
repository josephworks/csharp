using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        MyCar c = new MyCar();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c.setName("Ford Fiesta");
            c.setMPG(33);
            c.setTankCapacity(15);
            namelabel.Text = c.m_name;
            mpglabel.Text = c.m_mpg.ToString() + " mpg";
        }

        private void fillbutton_Click(object sender, EventArgs e)
        {
            int fillamount;
            fillamount = int.Parse(filltextBox.Text);
            if (c.m_gas < c.m_tank && fillamount <= c.m_tank)
            {
                c.fill(fillamount);
                trackBar1.Value = Convert.ToInt32(c.gasLeft());
            }
        }

        private void speedbutton_Click(object sender, EventArgs e)
        {
            c.setSpeed(int.Parse(speedtextBox.Text));
            textBox1.Text = c.m_speed.ToString();
        }

        private void drivebutton_Click(object sender, EventArgs e)
        {
            c.drive(int.Parse(drivetextBox.Text));
            odometerlabel.Text = c.m_distance.ToString() + " mi";
            trackBar1.Value = Convert.ToInt32(c.gasLeft());
        }
    }
}
