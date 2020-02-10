namespace Stack
{
    class Stack : IStack
    {
        private int[] m_vals = new int [10];
        private int m_count;

        public void push(int n)
        {
            m_count++;
            m_vals[m_count] = n;
        }

        public int pop()
        {
            m_count--;
            return m_vals[m_count];
        }

        public int peek()
        {
            return m_vals[m_count];
        }

        public int size()
        {
            return m_count;
        }
    }
}
