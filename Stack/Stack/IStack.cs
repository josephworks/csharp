using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    interface IStack
    {
        void push(int n);
        int pop();
        int peek();
        int size();
    }
}
