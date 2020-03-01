using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vend
    {
        decimal m_money;
        int m_item1;
        int m_item2;
        int m_item3;
        int m_nickels;
        int m_dimes;
        int m_quarters;
        public Vend()
        {
            m_item1 = 10;
            m_item2 = 10;
            m_item3 = 10;
            m_nickels = 10;
            m_dimes = 10;
            m_quarters = 10;
        }
        public void Add(decimal amt)
        {
            m_money += amt;
        }
        public void Buy(int item)
        {
            if (item == 1)
            {
                m_item1--;
                m_money -= .5m;
            }
            if (item == 2)
            {
                m_item2--;
                m_money -= 1m;
            }
            if (item == 3)
            {
                m_item3--;
                m_money -= .75m;
            }
        }
        public int getCount(int item)
        {
            if (item == 1)
                return m_item1;
            if (item == 2)
                return m_item1;
            if (item == 3)
                return m_item1;
            return 0;
        }
        public string GetAmount()
        {
            return string.Format("{0:C2}", m_money);
        }
    }
}
