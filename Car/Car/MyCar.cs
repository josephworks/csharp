using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class MyCar : ICarInterface
    {
        public string m_name;
        public int m_gas;
        public int m_mpg;
        public int m_tank;
        public int m_speed;
        public int m_distance;

        public void drive(int minutes)
        {
            if (m_gas > 0)
            {
                m_distance = m_speed / 60 * minutes;
                if (m_distance <= m_gas * m_mpg)
                    m_gas -= m_distance / m_mpg;
                else
                    m_distance = 0;
            }
        }

        public void fill(int gals)
        {
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
            m_tank = gals;
        }
    }
}
