using System;

namespace DesignPatterns.structural.bridge
{
    public class SmartLight : IDevice
    {
        private bool enabled = false;

        public bool IsEnabled()
        {
            return enabled;
        }

        public void Enable()
        {
            enabled = true;
            Console.WriteLine("Smart Light turned ON");
        }

        public void Disable()
        {
            enabled = false;
            Console.WriteLine("Smart Light turned OFF");
        }

        public void SetVolume(int percent)
        {
            Console.WriteLine($"Brightness set to {percent}%");
        }
    }
}
