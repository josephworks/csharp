namespace TV
{
    class MyTV : ITV
    {
        private int m_prev;
        private int m_volume;
        private int m_channel;
        private bool m_power;
        public bool Power(bool b)
        {
            m_power = b;
            m_power = !m_power;
            return b;
        }

        public string GetPower()
        {
            return Power(m_power).ToString();
        }

        public int Mute()
        {
            m_volume = 0;
            return m_volume;
        }

        public int VolumeUp()
        {
            if (m_volume <= 100)
                m_volume++;
            return m_volume;
        }

        public int VolumeDown()
        {
            if (m_volume >= 0)
            {
                m_volume--;
            }

            return m_volume;
        }

        public int GetVolume()
        {
            return m_volume;
        }

        public int ChannelUp()
        {
            m_prev = m_channel;
            m_channel++;
            return m_channel;
        }

        public int ChannelDown()
        {
            m_prev = m_channel;
            m_channel--;
            return m_channel;
        }

        public int GetChannel()
        {
            return m_channel;
        }

        public int Previous()
        {
            m_channel = m_prev;
            return m_channel;
        }

        public void SetChannel(int channel)
        {
            m_prev = m_channel;
            m_channel = channel;
        }
    }
}
