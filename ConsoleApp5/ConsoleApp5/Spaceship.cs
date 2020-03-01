using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Spaceship : IJoystick
    {
        int m_sequence;

        public bool A()
        {
            if (m_sequence == 9)
                m_sequence++;
            else
                m_sequence = 0;
            return true;
        }

        public bool B()
        {
            if (m_sequence == 8)
                m_sequence++;
            else
                m_sequence = 0;
            return true;
        }

        public bool Down()
        {
            if (m_sequence == 2 || m_sequence == 3)
                m_sequence++;
            else
                m_sequence = 0;
            return true;
        }

        public bool Left()
        {
            if (m_sequence == 4 || m_sequence == 6)
                m_sequence++;
            else
                m_sequence = 0;
            return true;
        }

        public bool Right()
        {
            if (m_sequence == 5 || m_sequence == 7)
                m_sequence++;
            else
                m_sequence = 0;
            return true;
        }

        public bool Select()
        {
            m_sequence = 0;
            return true;
        }

        public bool Start()
        {
            if (m_sequence == 10)
                Console.Beep();
            else
                m_sequence = 0;
            return true;
        }

        public bool Up()
        {
            if (m_sequence == 0 || m_sequence == 1)
                m_sequence++;
            else
                m_sequence = 0;
            return true;
        }


    }
}

