using System;
using Wisej.Web;

namespace HelloWorld
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }
}
