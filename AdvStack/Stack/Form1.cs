using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        StringStack s = new StringStack();
        public Form1()
        {
            InitializeComponent();
        }

        private void popbutton_Click(object sender, System.EventArgs e)
        {
            countlabel.Text = s.pop();
        }

        private void pushbutton_Click(object sender, System.EventArgs e)
        {
            s.push(pushtextBox.Text);
            pushtextBox.Clear();
        }

        private void peekbutton_Click(object sender, System.EventArgs e)
        {
            countlabel.Text = s.peek();
        }

        private void sizebutton_Click(object sender, System.EventArgs e)
        {
            countlabel.Text = s.size().ToString();
        }
    }
}
