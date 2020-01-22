using System;

namespace Interfaces
{
    internal interface IJoystick
    {
        Boolean Up();

        Boolean Down();

        Boolean Left();

        Boolean Right();

        Boolean A();

        Boolean B();

        Boolean Select();

        Boolean Start();
    }
}