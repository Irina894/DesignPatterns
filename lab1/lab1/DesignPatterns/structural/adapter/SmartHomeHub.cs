using System;

namespace DesignPatterns.structural.adapter
{
    public class SmartHomeHub
    {
        public void ActivateDevice(IDevice device)
        {
            Console.WriteLine("Hub activating device...");
            device.TurnOn();
        }
    }
}