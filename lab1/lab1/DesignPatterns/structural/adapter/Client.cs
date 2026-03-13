using System;

namespace DesignPatterns.structural.adapter
{
    public class Client
    {
        public static void Run()
        {

            SmartHomeHub hub = new SmartHomeHub();

            SmartLight light = new SmartLight();

            IDevice adapter = new SmartLightAdapter(light);

            hub.ActivateDevice(adapter);

            Console.WriteLine();
        }
    }
}