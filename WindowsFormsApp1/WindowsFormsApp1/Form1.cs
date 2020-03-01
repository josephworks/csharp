using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        VMachine v = new VMachine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            v.addNickel();
            UpdateBal();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            v.addDime();
            UpdateBal();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            v.addQuarter();
            UpdateBal();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            v.addDollar();
            UpdateBal();
        }

        public void UpdateBal()
        {
            textBox1.Text = v.getAmount();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            v.buyItem(1);
            UpdateBal();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            v.buyItem(2);
            UpdateBal();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            v.buyItem(3);
            UpdateBal();
        }
    }
}
