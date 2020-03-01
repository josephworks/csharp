using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        CookieClicker c = new CookieClicker();
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            c.Click();
            label1.Text = c.Score();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            c.Upgrade();
            label1.Text = c.Score();
            label2.Text = c.CPC();
        }
    }
}
