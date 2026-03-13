using System;

namespace DesignPatterns.structural.composite
{
    public class SmartLight : IDevice
    {
        private string name;

        public SmartLight(string name)
        {
            this.name = name;
        }

        public void Execute()
        {
            Console.WriteLine($"Light {name} turned OFF");
        }
    }
}
