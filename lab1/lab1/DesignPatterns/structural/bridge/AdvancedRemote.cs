using System;

namespace DesignPatterns.structural.bridge
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            device.SetVolume(0);
            Console.WriteLine("Device muted");
        }
    }
}
