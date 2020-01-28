using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class MyAccount
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
    }
}
