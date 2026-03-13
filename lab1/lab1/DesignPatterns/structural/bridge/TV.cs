using System;

namespace DesignPatterns.structural.bridge
{
    public class TV : IDevice
    {
        private bool enabled = false;
        private int volume = 50;

        public bool IsEnabled()
        {
            return enabled;
        }

        public void Enable()
        {
            enabled = true;
            Console.WriteLine("TV turned ON");
        }

        public void Disable()
        {
            enabled = false;
            Console.WriteLine("TV turned OFF");
        }

        public void SetVolume(int percent)
        {
            volume = percent;
            Console.WriteLine($"TV volume set to {volume}");
        }
    }
}
