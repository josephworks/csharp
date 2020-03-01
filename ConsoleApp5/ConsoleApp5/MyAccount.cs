using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyAccount : IAccount
    {
        double m_balance;
        public void deposit(double amount)
        {
            m_balance += amount;
        }

        public double getBalance()
        {
            return m_balance;
        }

        public void withdraw(double amount)
        {
           m_balance -= amount;
            if (m_balance < 0)
            {
                m_balance -= 20;
            }
        }
    }
}
