using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClick
{
    public partial class MainForm : Form
    {
        CookieClicker c = new CookieClicker();
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            c.Click();
            ScoreLabel.Text = c.Score();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            c.Upgrade();
            ScoreLabel.Text = c.Score();
            cpslabel.Text = c.Cpc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScoreLabel.Text = c.Score();
            cpslabel.Text = c.Cpc();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            c.Click();
            ScoreLabel.Text = c.Score();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            c.Upgrade();
            ScoreLabel.Text = c.Score();
            cpslabel.Text = c.Cpc();
        }
    }
}
