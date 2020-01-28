using InterfacesStuff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        private ICarInterface m_car;
        public Form1()
        {
            m_car = new Car(15, 30, "Example Car");
            m_car.setSpeed(30);
            InitializeComponent();
            UpdateForm();
        }

        public void UpdateForm()
        {
            carName.Text = m_car.getName();
            speed.Text = m_car.getSpeed().ToString();
            mpg.Text = m_car.getMPG().ToString("N2");
            gas.Text = m_car.gasLeft().ToString("N2");
            capacity.Text = m_car.getCapacity().ToString("N2");
            miles.Text = m_car.getMiles().ToString("N2");
            gasBar.Maximum = (int)m_car.getCapacity();
            gasBar.Value = (int)m_car.gasLeft();
            speedBar.Value = m_car.getSpeed();
            if (m_car.gasLeft() < 2) { gasLight.Visible = true; }
            else { gasLight.Visible = false; }
            //minTB.Text = "0";
            //galTB.Text = "0";
            //speedTB.Text = "0";
        }

        private void newCar_Click(object sender, EventArgs e)
        {
            NewCar c = new NewCar();
            c.ShowDialog();
            if (c.getCar() != null)
            {
                m_car = c.getCar();
                UpdateForm();
            }
        }

        private void driveB_Click(object sender, EventArgs e)
        {
            try
            {
            m_car.drive(int.Parse(minTB.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Parameters.");
            }
            UpdateForm();
        }

        private void fillB_Click(object sender, EventArgs e)
        {
            try
            {
            m_car.fill(int.Parse(galTB.Text));

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Parameters.");
            }
            UpdateForm();
        }

        private void setSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                int speed = int.Parse(speedTB.Text);
                if (speed > 100) { speed = 100; }
                if (speed < 0) { speed = 0; }
                m_car.setSpeed(speed);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Parameters");
            }
            UpdateForm();
        }
    }
}
