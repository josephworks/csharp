namespace TV
{
    interface ITV
    {
        void Power();

        int Mute();

        int VolumeUp();

        int VolumeDown();

        int ChannelUp();

        int ChannelDown();

        int Previous();

        void SetChannel(int channel);
    }
}
