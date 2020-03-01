using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface IAccount
    {
        double getBalance();

        void deposit(double amount);

        void withdraw(double amount);

    }
}
