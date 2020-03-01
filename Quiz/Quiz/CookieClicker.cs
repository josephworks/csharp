using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class CookieClicker
    {
        int m_cookies;
        int m_cpc = 1;
        public CookieClicker()
        {

        }
        public void Click()
        {
            m_cookies += m_cpc;
        }
        public void Upgrade()
        {
            if (m_cookies >= 10)
            {
                m_cpc += m_cookies / 100;
                m_cookies = 0;
            }
        }
        public string Score()
        {
            return m_cookies + " Cookies";
        }
        public string CPC()
        {
            return m_cpc + " cookies per click";
        }
    }
}
