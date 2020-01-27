namespace InterfacesStuff
{
    class MyAccount : IAccount
    {
        private double m_balance;
        public MyAccount()
        {

        }

        public void deposit(double amount)
        {
            if (amount > 0) { m_balance += amount; }
            //throw new NotImplementedException("Sentence", new Exception("Sentence 2", new Exception("Sentence 3")));
        }

        public double getBalance()
        {
            return m_balance;
        }

        public void withdraw(double amount)
        {
            if (amount > 0)
            {
                m_balance -= amount;
                if (m_balance < 0) { m_balance -= 20; }
            }
        }
    }
}
