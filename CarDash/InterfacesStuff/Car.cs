namespace InterfacesStuff
{
    class Car : ICarInterface
    {
        private double m_capacity;
        private double m_gas;
        private string m_name;
        private double m_mpg;
        private int m_speed;
        private double m_miles;

        public Car(double capacity, double mpg, string name)
        {
            m_capacity = capacity;
            m_gas = capacity;
            m_name = name;
            m_mpg = mpg;
            m_speed = 0;
            m_miles = 0;
        }

        public void drive(int minutes)
        {
            double miles = ((double)minutes/60) * m_speed;
            double gas = miles / m_mpg;
            if (gas > m_gas)
            {
                //System.Console.WriteLine((m_gas * m_mpg) / m_speed * 60);
                drive((int)((m_gas * m_mpg) / m_speed * 60));
            }
            if (m_gas > 0) { m_gas -= gas; m_miles += miles; }
            
        }

        public void fill(int gals)
        {
            if (gals < 0) { return; }
            if (gals + m_gas > m_capacity)
            {
                fill((int)(m_capacity - m_gas));
            }
            m_gas += gals;
        }

        public double gasLeft()
        {
            return m_gas;
        }

        public string getName()
        {
            return m_name;
        }

        public int getSpeed()
        {
            return m_speed;
        }

        public void setMPG(int mpg)
        {
            m_mpg = mpg;
        }

        public void setName(string name)
        {
            m_name = name;
        }

        public void setSpeed(int speed)
        {
            m_speed = speed;
        }

        public void setTankCapacity(int gals)
        {
            m_capacity = gals;
        }

        public override string ToString()
        {
            return "Car: " + m_name + string.Format("\nGas: {0}\nCapacity: {1}\nSpeed:{2}\nMPG: {3}\nMiles: {4}", m_gas, m_capacity, m_speed, m_mpg, m_miles);
        }

        public double getMiles() { return m_miles; }
    }
}
