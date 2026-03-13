using System;

namespace DesignPatterns.structural.composite
{
    public class Zone : IDevice
    {
        private string name;
        private List<IDevice> devices = new List<IDevice>();

        public Zone(string name)
        {
            this.name = name;
        }

        public void Add(IDevice device)
        {
            devices.Add(device);
        }

        public void Remove(IDevice device)
        {
            devices.Remove(device);
        }

        public void Execute()
        {
            Console.WriteLine($"Executing zone: {name}");

            foreach (var device in devices)
            {
                device.Execute();
            }
        }
    }
}