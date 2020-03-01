namespace Stack
{
    class MyStack : IStack
    {
        int[] m_s = new int[10];
        int m_count = 0;
        public int peek()
        {
            return m_s[m_count];
        }

        public int pop()
        {
            m_count--;
            return m_s[m_count];
        }

        public void push(int n)
        {
            m_count++;
            m_s[m_count] = n;
        }

        public int size()
        {
            return m_count;
        }
    }
}
