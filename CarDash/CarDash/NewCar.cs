using InterfacesStuff;
using System;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class NewCar : Form
    {
        private ICarInterface m_car;

        public NewCar()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ICarInterface getCar()
        {
            return m_car;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m_car = new Car(double.Parse(capTB.Text), double.Parse(mpgTB.Text), nameTB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Parameters. Car cannot be created.");
                return;
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (nameTB.Text.Length > 0 && mpgTB.Text.Length > 0 && capTB.Text.Length > 0)
            {
                button1.Enabled = true;
            }
        }

        private void NewCar_Load(object sender, EventArgs e)
        {
        }
    }
}