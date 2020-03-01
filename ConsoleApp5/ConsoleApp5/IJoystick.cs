using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface IJoystick
    {
        Boolean Up();
        Boolean Down();
        Boolean Left();
        Boolean Right();
        Boolean A();
        Boolean B();
        Boolean Start();
        Boolean Select();
    }
}
