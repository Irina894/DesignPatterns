using System;

namespace DesignPatterns.structural.bridge
{
    public class Remote
    {
        protected IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
                device.Disable();
            else
                device.Enable();
        }

        public void VolumeUp()
        {
            device.SetVolume(70);
        }

        public void VolumeDown()
        {
            device.SetVolume(20);
        }
    }
}