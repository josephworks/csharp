using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    interface ITV
    {
        bool Power();

        int VolumeUp();

        int VolumeDown();

        int ChannelUp();

        int ChannelDown();

        int Previous();

        int SetChannel(int channel);

        int Mute();

        int GetChannel();

        int GetVolume();
    }
}
