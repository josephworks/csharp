using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        CookieClicker CookieClass = new CookieClicker();
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = CookieClass.getAmmount();
            cookies
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
