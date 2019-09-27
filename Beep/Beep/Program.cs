using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioSwitcher.AudioApi.CoreAudio;
using static System.Console;

namespace Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Max volume beeps
                CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                defaultPlaybackDevice.Volume = 50;
                WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                Console.Beep(1000, 100);
                //System.Threading.Thread.Sleep(1000);
                defaultPlaybackDevice.Volume = 75;
                WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                Console.Beep(2000, 100);
                //System.Threading.Thread.Sleep(1000);
                defaultPlaybackDevice.Volume = 100;
                WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                Console.Beep(3000, 100);
                //System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
