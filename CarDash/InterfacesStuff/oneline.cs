




namespace InterfacesStuff { internal class Oneline { private int m_count; public Oneline()
        {
            m_count = 0;
        }
        public void Click()
        {
            m_count++;
        }
        public void Reset()
        {
            m_count = 0;
        }
        public override string ToString() => $"Count: {m_count}"; } }