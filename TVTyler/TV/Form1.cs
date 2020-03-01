using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV
{
    public partial class Form1 : Form
    {
        MyTV v = new MyTV();
        public Form1()
        {
            InitializeComponent();
        }

        private void volupbutton_Click(object sender, EventArgs e)
        {
            volumelabel.Text = v.VolumeUp().ToString();

        }

        private void voldownbutton_Click(object sender, EventArgs e)
        {
            volumelabel.Text = v.VolumeDown().ToString();
        }

        private void chanupbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[v.ChannelUp() - 1];
        }

        private void chandownbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[v.ChannelDown() - 1];
        }

        private void prevbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[v.Previous() - 1];
        }

        private void mutebutton_Click(object sender, EventArgs e)
        {
            volumelabel.Text = v.Mute().ToString();
        }

        private void chansetbutton_Click(object sender, EventArgs e)
        {
            int c;
            c = int.Parse(chantextBox.Text);
            pictureBox1.Image = imageList1.Images[v.SetChannel(c)-1];
        }

        private void powerbutton_Click(object sender, EventArgs e)
        {
            if (v.Power())
                pictureBox1.Visible = true;
            else
                pictureBox1.Visible = false;
        }
    }
}
