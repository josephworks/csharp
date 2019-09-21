using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClick
{
    class CookieClicker
    {
        int m_cookies;
        int m_cpc = 1;

        public void Click()
        {
            m_cookies += m_cpc;
        }
        public void Upgrade()
        {
            if (m_cookies >= 10)
            {
                m_cpc += m_cookies * 2;
                m_cookies += m_cookies / 100;
            }
            if (m_cookies >= 105)
            {
                m_cpc += m_cookies * 20;
                m_cookies = 0;
            }
            if (m_cookies >= 123)
            {
                m_cpc += m_cookies * 2000;
                m_cookies = 1000000;
            }
        }
        public string Score()
        {
            return m_cookies + " Cookies";
        }
        public string Cpc()
        {
            return m_cpc + " cookies per click";
        }
    }
}
