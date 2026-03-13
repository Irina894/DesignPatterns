using System;

namespace DesignPatterns.structural.bridge
{
    public class Client
    {
        public static void Run()
        {

            IDevice tv = new TV();
            Remote remote = new Remote(tv);

            remote.TogglePower();
            remote.VolumeUp();

            Console.WriteLine();

            IDevice radio = new Radio();
            AdvancedRemote advancedRemote = new AdvancedRemote(radio);

            advancedRemote.TogglePower();
            advancedRemote.Mute();

            Console.WriteLine();
        }
    }
}
