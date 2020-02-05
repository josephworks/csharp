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
        ITV tv = new MyTV();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Beep();
            ChannelLabel.Text = "1";
            tv.SetChannel(1);
            VolumeLabel.Text = "20";
            tv.VolumeUp();
            PowerLabel.Text = "Off";
            tv.Power(false);
        }

        private void ChannelUp_Click(object sender, EventArgs e)
        {
            tv.ChannelUp();
            ChannelLabel.Text = tv.GetChannel().ToString();
        }

        private void ChannelDown_Click(object sender, EventArgs e)
        {
            tv.ChannelDown();
            ChannelLabel.Text = tv.GetChannel().ToString();
        }

        private void VolumeUp_Click(object sender, EventArgs e)
        {
            tv.VolumeUp();
            VolumeLabel.Text = tv.GetVolume().ToString();
        }

        private void VolumeDown_Click(object sender, EventArgs e)
        {
            tv.VolumeDown();
            VolumeLabel.Text = tv.GetVolume().ToString();
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            string powerTv = tv.GetPower().ToString();
            string powerStatus = "";
            if (powerTv == "true")
            {
                powerStatus = "On";
                tv.Power(true);
            }
            else
            {
                powerStatus = "Off";
                tv.Power(false);
            }
            PowerLabel.Text = powerStatus;
        }

        //private static void Main(string[] args)
        //{
            //SpaceShip s = new SpaceShip();

            //Console.Beep(2000, 3000);

            //s.Up();
            //s.Down();
            //s.Left();
            //s.Right();
            //s.A();
            //s.B();
            //IAccount a = new MyAccount();
            //Console.WriteLine(a.GetBalance());
            //a.Deposit(100);
            //Console.WriteLine(a.GetBalance());
            //a.Withdraw(50);
            //Console.WriteLine(a.GetBalance());
            //a.Withdraw(60);
            //Console.WriteLine(a.GetBalance());
            //Console.ReadLine();
        //}
    }
}
