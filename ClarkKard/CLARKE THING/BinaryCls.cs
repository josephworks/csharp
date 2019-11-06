namespace CLARKE_THING
{
    internal class BinaryCls
    {
        private int[] m_Data = new int[16];

        public BinaryCls(int num)
        {
            int rem = 0;
            int div = 0;
            for (int i = 0; i < m_Data.Length; i++)
            {
                div = num / 2;
                rem = num % 2;
                m_Data[i] = rem;
                num = div;
            }
        }

        public override string ToString()
        {
            string retVal = "";
            for (int i = 0; i < m_Data.Length; i++)
            {
                retVal = m_Data[i] + retVal;
            }
            return retVal;
        }

        public string ToOctal()
        {
            string retVal = "";
            for (int i = 0; i < m_Data.Length; i = i + 3)
            {
                retVal = m_Data[i] + retVal;
            }
            return retVal;
        }
    }
}