using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class MyTV : ITV
    {
        public int m_channel = 1;
        int m_volume = 0;
        int m_prev;
        bool m_power = false;
        public int ChannelDown()
        {
            m_prev = m_channel;
            if (m_channel > 1)
                m_channel--;
            else
                m_channel = 5;
            return m_channel;
        }

        public int ChannelUp()
        {
            m_prev = m_channel;
            if (m_channel < 5)
                m_channel++;
            else
                m_channel = 1;
            return m_channel;
        }

        public int Mute()
        {
            m_volume = 0;
            return m_volume;
        }

        public bool Power()
        {
            if (m_power)
                m_power = false;
            else
                m_power = true;
            return m_power;
        }

        public int Previous()
        {
            m_channel = m_prev;
            return m_channel;
        }

        public int SetChannel(int channel)
        {
            m_prev = m_channel;
            m_channel = channel;
            return m_channel;
        }

        public int VolumeDown()
        {
            if (m_volume >= 0)
                m_volume--;
            return m_volume;
        }

        public int VolumeUp()
        {
            if (m_volume <= 100)
                m_volume++;
            return m_volume;
        }

        public int GetChannel()
        {
            return m_channel;
        }

        public int GetVolume()
        {
            return m_volume;
        }
    }
}
