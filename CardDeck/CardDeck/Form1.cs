using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
namespace Thing_While_Clarke_Was_Gone
{
    public partial class Form1 : Form
    {
        public int RNG1 = 0;
        public int RNG2 = 0;
        public Random rnd = new Random();
        public bool tf = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int card = rnd.Next(52);
            if (tf == true)
            {
                pictureBox2.Image = imageList1.Images[card];
                tf = false;
                RNG1 = card;
            }
            else
            {
                pictureBox3.Image = imageList1.Images[card];
                tf = true;
                RNG2 = card;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int card = rnd.Next(52);
            if (tf == true)
            {
                pictureBox2.Image = imageList1.Images[card];
                tf = false;
                RNG1 = card;
            }
            else
            {
                pictureBox3.Image = imageList1.Images[card];
                tf = true;
                RNG2 = card;
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int card = rnd.Next(52);
            if (tf == true)
            {
                pictureBox2.Image = imageList1.Images[card];
                tf = false;
                RNG1 = card;
            }
            else
            {
                pictureBox3.Image = imageList1.Images[card];
                tf = true;
                RNG2 = card;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Beep();
        }
    }
}
