using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class VMachine
    {
        int m_dollars = 10;
        int m_nickels = 10;
        int m_dimes = 10;
        int m_quarters = 10;
        int m_item1 = 10;
        int m_item2 = 10;
        int m_item3 = 10;
        decimal m_money;
        const decimal PRICE1 = .5m;
        const decimal PRICE2 = 1m;
        const decimal PRICE3 = .75m;


        public VMachine()
        {

        }
        public void addDollar()
        {
            m_dollars++;
            m_money += 1;
        }
        public void addQuarter()
        {
            m_quarters++;
            m_money += .25m;
        }
        public void addDime()
        {
            m_dimes++;
            m_money += .1m;
        }
        public void addNickel()
        {
            m_nickels++;
            m_money += .05m;
        }
        public void buyItem(int item)
        {
            switch (item)
            {
                case 1:
                    if (m_money >= PRICE1 && m_item1 > 0)
                    {
                        m_item1--;
                        m_money -= PRICE1;
                    }
                    break;
                case 2:
                    if (m_money >= PRICE2 && m_item2 > 0)
                    {
                        m_item2--;
                        m_money -= PRICE2;
                    }
                    break;
                case 3:
                    if (m_money >= PRICE3 && m_item3 > 0)
                    {
                        m_item3--;
                        m_money -= PRICE3;
                    }
                    break;
            }
        }
        public string getAmount()
        {
            return string.Format("{0:C2}", m_money);
        }
        public void getChange()
        {
            m_money = 0;

        }
    }
}
