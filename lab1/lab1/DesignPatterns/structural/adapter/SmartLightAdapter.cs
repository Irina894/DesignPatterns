using System;

namespace DesignPatterns.structural.adapter
{
    public class SmartLightAdapter : IDevice
    {
        private SmartLight light;

        public SmartLightAdapter(SmartLight light)
        {
            this.light = light;
        }

        public void TurnOn()
        {
            light.Illuminate(100);
        }
    }
}