using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IJoystick
    {
        Boolean Up();
        Boolean Down();
        Boolean Left();
        Boolean Right();
        Boolean Fire();
    }
}
