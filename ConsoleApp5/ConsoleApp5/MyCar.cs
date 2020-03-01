using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyCar : ICarInterface
    {
        string m_name;
        int m_gas;
        int m_mpg;
        int m_tank;
        int m_speed;
        int m_distance;

        public void drive(int minutes)
        {
            if (m_gas > 0)
            {
                m_distance = m_speed / 60 * minutes;
                m_gas -= m_distance / m_mpg;
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
