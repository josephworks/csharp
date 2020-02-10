namespace TV
{
    interface ITV
    {
        bool Power(bool b);

        string GetPower();

        int Mute();

        int VolumeUp();

        int VolumeDown();
        int GetVolume();

        int ChannelUp();

        int ChannelDown();

        int GetChannel();

        int Previous();

        void SetChannel(int channel);
    }
}
