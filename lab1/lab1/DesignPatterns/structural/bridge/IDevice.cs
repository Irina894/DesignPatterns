using System;

namespace DesignPatterns.structural.bridge
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        void SetVolume(int percent);
    }
}