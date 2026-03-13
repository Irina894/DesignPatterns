using System;

namespace DesignPatterns.structural.bridge
{
    public class Radio : IDevice
    {
        private bool enabled = false;
        private int volume = 30;

        public bool IsEnabled()
        {
            return enabled;
        }

        public void Enable()
        {
            enabled = true;
            Console.WriteLine("Radio turned ON");
        }

        public void Disable()
        {
            enabled = false;
            Console.WriteLine("Radio turned OFF");
        }

        public void SetVolume(int percent)
        {
            volume = percent;
            Console.WriteLine($"Radio volume set to {volume}");
        }
    }
}
