namespace ClassPractice
{
    internal class Beeper
    {
        public int m_duration;
        public int m_pitch;

        public Beeper()
        {
            m_duration = 500;
            m_pitch = 1000;
        }

        public void Beep()
        {
            System.Console.Beep();
        }

        public void multiBeep(int count)
        {
            for (int i = 0; i < count; i++)
            {
                System.Threading.Thread.Sleep(100);
                Beep();
            }
        }

        public void superBeep(int p, int f)
        {
            System.Console.Beep(f, p);
        }
    }
}